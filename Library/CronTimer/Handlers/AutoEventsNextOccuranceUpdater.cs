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
                        DateTime nextOccur = GetNextOccurrence(e.CronTimerFormat, DateTime.UtcNow)
                            ?? throw new Exception("Invalid cron expression or no next occurrence.");

                        // Store the difference in seconds until the next occurrence
                        e.NextOccurance = Convert.ToInt32((nextOccur - DateTime.UtcNow).TotalSeconds);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error processing event {e.ID}: {ex.Message}");
                    }
                }

                await van.SaveChangesAsync();
            }
        }

        public static DateTime? GetNextOccurrence(string cronExpression, DateTime fromTime)
        {
            try
            {
                // Ensure the cron expression is valid
                var expression = new CronExpression(cronExpression);
                return expression.GetNextValidTimeAfter(fromTime)?.UtcDateTime;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Invalid cron expression: {ex.Message}");
                return null;
            }
        }
    }
}
