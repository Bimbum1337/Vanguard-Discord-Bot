using BimBot.Database.Context;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Quartz;

namespace BimBot.Library.CronTimer.Handlers
{
    public class EventExecuter : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            try
            {
                JobDataMap dataMap = context.JobDetail.JobDataMap;

                int? Id = (int?)dataMap["Id"];

                using var van = new VanGuard();

                var entry = await van.EventSchedulings.FirstOrDefaultAsync(x => x.ID == Id - 7);

                if (entry != null)
                {
                    van.Database.SetCommandTimeout(entry.QueryTimeOutSeconds);

                    await van.Database.ExecuteSqlRawAsync($"EXEC {entry.QueryName} @param",
                    new SqlParameter("@param", Id - 7));
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
