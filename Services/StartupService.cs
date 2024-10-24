using Discord;
using Discord.WebSocket;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BimBot.Services
{
    public class StartupService
    {
        private readonly DiscordShardedClient _discord;
        private readonly IConfigurationRoot _config;
        private readonly IServiceProvider _services;
        private readonly ILogger<StartupService> _logger;

        public StartupService(IServiceProvider services)
        {
            _services = services;
            _config = _services.GetRequiredService<IConfigurationRoot>();
            _discord = _services.GetRequiredService<DiscordShardedClient>();
            _logger = services.GetRequiredService<ILogger<StartupService>>();
        }

        public async Task StartAsync()
        {
            try
            {
                string? discordToken = _config["Token"];
                if (string.IsNullOrWhiteSpace(discordToken))
                {
                    throw new Exception("Token missing from config.json! Please enter your token there (root directory)");
                }
                _discord.Log += Client_Log;
                await _discord.LoginAsync(TokenType.Bot, discordToken);
                await _discord.StartAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError("check your interneta lool ? maybe token is wronga idka xD");
                _logger.LogError(ex.Message);
            }

        }

        private static Task Client_Log(LogMessage Message)
        {
            Console.WriteLine(Message);

            var tcs = new TaskCompletionSource<bool>();
            tcs.SetResult(true);
            return tcs.Task;
        }
    }
}
