using BimBot.Database.Context;
using Microsoft.EntityFrameworkCore;
using Quartz;

namespace BimBot.Library.CronTimer.Handlers
{
    public class AutoEventsNextOccuranceUpdater : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            using var van = new VanGuard();
            var events = await van.EventSchedulings.ToListAsync();

            if (events.Any())
            {
                foreach (var e in events)
                {
                    try
                    {
                        DateTime nextOccur = (DateTime)GetNextOccurrence(e.CronTimerFormat, DateTime.Now);

                        e.NextOccurance = Convert.ToInt32(nextOccur.Subtract(DateTime.Now).TotalSeconds);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                await van.SaveChangesAsync();
            }
        }

        public static DateTime? GetNextOccurrence(string cronExpression, DateTime fromTime)
        {
            CronExpression expression = new CronExpression(cronExpression);

            return expression.GetNextValidTimeAfter(fromTime)?.UtcDateTime;
        }
    }
}
