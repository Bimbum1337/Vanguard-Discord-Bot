using BimBot.Database.Context;
using Microsoft.EntityFrameworkCore;
using Quartz;

namespace BimBot.Library.CronTimer.Events
{
    public class JackPot : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            using var van = new VanGuard();
            await van.Database.ExecuteSqlRawAsync("EXEC _ShardManagerJackpotWinners");
        }
    }
}
