using BimBot.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BimBot.Database
{
    public class DatabaseManager
    {
        internal static string? SroVtAccountConnectionString = "";
        internal static string? SroVtLogConnectionString = "";
        internal static string? SroVtShardConnectionString = "";
        internal static string? SroVtBimBotConnectionString = "";
        internal static string? VanGuardConnectionString = "";

        private readonly ILogger _logger;

        public DatabaseManager(IConfigurationRoot _config, IServiceProvider services)
        {
            _logger = services.GetRequiredService<ILogger<CommandHandler>>();

            // string address, int port, string username, string password, string sharDb, string logDb, string accountDb, string proxyDb
            SroVtAccountConnectionString =
                $"data source={_config["SqlIP"]},{_config["SqlPort"]};initial catalog={_config["AccountDB"]};persist security info =True; User Id={_config["Username"]};Password={_config["Password"]};MultipleActiveResultSets=True;App=DuckSoupEntityFramework;Encrypt=False;";
            SroVtShardConnectionString =
                $"data source={_config["SqlIP"]},{_config["SqlPort"]};initial catalog={_config["ShardDB"]};persist security info =True; User Id={_config["Username"]};Password={_config["Password"]};MultipleActiveResultSets=True;App=DuckSoupEntityFramework;Encrypt=False;";
            SroVtLogConnectionString =
                $"data source={_config["SqlIP"]},{_config["SqlPort"]};initial catalog={_config["LogDB"]};persist security info =True; User Id={_config["Username"]};Password={_config["Password"]};MultipleActiveResultSets=True;App=DuckSoupEntityFramework;Encrypt=False;";
            SroVtBimBotConnectionString =
                $"data source={_config["SqlIP"]},{_config["SqlPort"]};initial catalog=SILKROAD_R_BIMBOT;persist security info =True; User Id={_config["Username"]};Password={_config["Password"]};MultipleActiveResultSets=True;App=DuckSoupEntityFramework;Encrypt=False;";
            VanGuardConnectionString =
               $"data source={_config["SqlIP"]},{_config["SqlPort"]};initial catalog=VanGuard;persist security info =True; User Id={_config["Username"]};Password={_config["Password"]};MultipleActiveResultSets=True;App=DuckSoupEntityFramework;Encrypt=False;";

            try
            {
                using var context = new Context.SRO_VT_BIMBOT();
                context.Database.Migrate();
                context.SaveChanges();

                if (CheckConnection())
                {
                    _logger.LogInformation("Succesfully connected to the database.");
                }
                else
                {
                    _logger.LogError("An error occured while connecting to the database!");
                    return;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex + " An error occurred while migrating the database");
            }
        }

        public bool CheckConnection()
        {
            bool acc, shard, log, bot;

            using (var db = new Context.SILKROAD_R_ACCOUNT())
            {
                acc = db.Database.CanConnect();

                if (!acc) return false;
            }

            using (var db = new Context.SILKROAD_R_SHARD())
            {
                shard = db.Database.CanConnect();

                if (!shard) return false;
            }

            using (var db = new Context.SILKROAD_R_LOG())
            {
                log = db.Database.CanConnect();

                if (!log) return false;
            }

            using (var db = new Context.SRO_VT_BIMBOT())
            {
                bot = db.Database.CanConnect();

                if (!bot) return false;
            }

            using (var db = new Context.VanGuard())
            {
                bot = db.Database.CanConnect();

                if (!bot) return false;
            }

            return true;
        }

        public void Dispose()
        {
            SroVtAccountConnectionString = null;
            SroVtLogConnectionString = null;
            SroVtShardConnectionString = null;
            SroVtBimBotConnectionString = null;
            VanGuardConnectionString = null;
        }
    }
}
