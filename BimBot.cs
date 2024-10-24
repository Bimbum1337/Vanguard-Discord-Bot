using BimBot.Database;
using BimBot.Library.CronTimer;
using BimBot.Modules.Interactions.User;
using BimBot.Services;
using Discord;
using Discord.Commands;
using Discord.Interactions;
using Discord.WebSocket;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Http;
using Serilog;

namespace BimBot
{
    public class BimBot
    {
        private IConfigurationRoot? _config;
        public static bool IsReady;
        public async Task StartAsync()
        {
            //Build the configuration
            var _builder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile(path: "config.json");

            _config = _builder.Build();

            //Register classes
            var services = new ServiceCollection()
               .AddSingleton(new DiscordShardedClient(new DiscordSocketConfig
               {
                   GatewayIntents = GatewayIntents.All,
                   LogLevel = LogSeverity.Error,
                   MessageCacheSize = 1000,
                   AlwaysDownloadUsers = true
               }))
               .AddSingleton(_config)
               .AddSingleton(new CommandService(new CommandServiceConfig
               {
                   DefaultRunMode = Discord.Commands.RunMode.Async,
                   LogLevel = LogSeverity.Debug,
                   CaseSensitiveCommands = false,
                   ThrowOnError = false
               }))
               .AddHttpClient()
               .AddSingleton<CommandHandler>()
               .AddSingleton<DatabaseManager>()
               .AddSingleton(x => new InteractionService(x.GetRequiredService<DiscordShardedClient>()))
               .AddSingleton<StartupService>()
               .AddSingleton<InteractionHandler>()
               .AddSingleton<CronTimeManager>()
               .AddSingleton<UserInteraction>()
               .AddSingleton<Suggestions>()
               .AddSingleton<InviteTracker>();

            //Add logging      
            ConfigureServices(services);

            //Build services
            var serviceProvider = services.BuildServiceProvider();

            serviceProvider.GetRequiredService<DatabaseManager>();

            //CronTimer
            serviceProvider.GetRequiredService<CronTimeManager>();

            //Interaction testing
            await serviceProvider.GetRequiredService<InteractionHandler>()
                .InitializeAsync();

            //Start the bot
            await serviceProvider.GetRequiredService<StartupService>().StartAsync();

            //Load up services
            serviceProvider.GetRequiredService<CommandHandler>();

            //User interactions
            serviceProvider.GetRequiredService<UserInteraction>();

            //Invite Tracker
            serviceProvider.GetRequiredService<InviteTracker>();

            //Suggestions
            serviceProvider.GetRequiredService<Suggestions>();

            //Block this program until it is closed.
            await Task.Delay(-1);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            //Add SeriLog
            services.AddLogging(configure => configure.AddSerilog());
            //Remove default HttpClient logging as it is extremely verbose
            services.RemoveAll<IHttpMessageHandlerBuilderFilter>();
            //Configure logging level              
            var logLevel = "info";
            //var logLevel = Environment.GetEnvironmentVariable("NJA_LOG_LEVEL");
            var level = Serilog.Events.LogEventLevel.Error;
            if (!string.IsNullOrEmpty(logLevel))
            {
                switch (logLevel.ToLower())
                {
                    case "error":
                        {
                            level = Serilog.Events.LogEventLevel.Error;
                            break;
                        }
                    case "info":
                        {
                            level = Serilog.Events.LogEventLevel.Information;
                            break;
                        }
                    case "debug":
                        {
                            level = Serilog.Events.LogEventLevel.Debug;
                            break;
                        }
                    case "crit":
                        {
                            level = Serilog.Events.LogEventLevel.Fatal;
                            break;
                        }
                    case "warn":
                        {
                            level = Serilog.Events.LogEventLevel.Warning;
                            break;
                        }
                    case "trace":
                        {
                            level = Serilog.Events.LogEventLevel.Debug;
                            break;
                        }
                }
            }
            Log.Logger = new LoggerConfiguration()
                    .WriteTo.File("logs/bimbot.log", rollingInterval: RollingInterval.Day)
                    .WriteTo.Console()
                    .MinimumLevel.Is(level)
                    .CreateLogger();
        }
    }
}
