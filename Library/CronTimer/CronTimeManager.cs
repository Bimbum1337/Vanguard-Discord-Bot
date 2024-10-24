using BimBot.Database.Context;
using BimBot.Library.CronTimer.Events;
using BimBot.Library.CronTimer.Handlers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Quartz;
using Quartz.Impl;

namespace BimBot.Library.CronTimer
{
    public class CronTimeManager
    {
        private Dictionary<string, TriggerKey> Triggers { get; set; }
        private readonly StdSchedulerFactory _schedulerFactory;
        private readonly ILogger<CronTimeManager> _logger;
        private readonly IServiceProvider _services;
        private readonly IConfigurationRoot _configuration;

        public CronTimeManager(IServiceProvider services, IConfigurationRoot config)
        {
            _services = services;

            _logger = services.GetRequiredService<ILogger<CronTimeManager>>();

            Triggers = new Dictionary<string, TriggerKey>();

            _schedulerFactory = new StdSchedulerFactory();

            _configuration = config;

            var scheduler = _schedulerFactory.GetScheduler().Result;
            scheduler.Start();

            Start();
        }

        public async void StartScheduler<T>(int index, string crontime, int? Id) where T : IJob
        {
            try
            {
                var scheduler = await _schedulerFactory.GetScheduler();

                var job = JobBuilder.Create<T>()
                    .WithIdentity($"{index}Jobs", "Timers")
                    .Build();

                job.JobDataMap["Id"] = Id;
                job.JobDataMap["Services"] = _services;

                var trigger = Quartz.TriggerBuilder.Create()
                    .WithIdentity($"{index}Triggers", "Timers")
                    .WithCronSchedule(crontime)
                    .StartNow()
                    .Build();

                Triggers.Add($"{index}Jobs", trigger.Key);

                await scheduler.ScheduleJob(job, trigger);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
            }
        }

        public void ClearScheduler()
        {
            try
            {
                foreach (var s in Triggers)
                {
                    var trigger = Triggers[s.Key];
                    if (trigger == null) continue;
                    _schedulerFactory.GetScheduler().Result.UnscheduleJob(trigger);
                    Triggers.Remove(s.Key);
                }

                Start();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
            }
        }

        public void Start()
        {
            StartScheduler<CommandExecutor>(0, "*/1 * * ? * *", 1);
            StartScheduler<Giveaway>(1, "*/3 * * ? * *", 2);

            // Auto events
            StartScheduler<AutoEventsNextOccuranceUpdater>(2, "*/1 * * ? * *", 3);
            StartScheduler<MatchingPvP>(3, "*/1 * * ? * *", 4);
            StartScheduler<MatchingUnique>(4, "*/1 * * ? * *", 5);
            StartScheduler<JackPot>(5, _configuration["JackPotCronTime"]!, 6);

            using var context = new VanGuard();

            var lst = context.EventSchedulings.ToList();

            foreach (var e in lst)
            {
                if (!string.IsNullOrEmpty(e.QueryName))
                {
                    StartScheduler<EventExecuter>(e.ID + 7, e.CronTimerFormat, e.ID + 7);
                }
            }
        }

        public void Dispose()
        {

        }
    }
}
