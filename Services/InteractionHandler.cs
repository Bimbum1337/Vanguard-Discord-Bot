using Discord;
using Discord.Interactions;
using Discord.WebSocket;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace BimBot.Services
{
    public class InteractionHandler
    {
        private readonly DiscordShardedClient _client;
        private readonly InteractionService _handler;
        private readonly IServiceProvider _services;
        private readonly IConfigurationRoot _configuration;
        private readonly ILogger _logger;

        public InteractionHandler(DiscordShardedClient client, InteractionService handler, IServiceProvider services, IConfigurationRoot config)
        {
            _client = client;
            _handler = handler;
            _services = services;
            _configuration = config;
            _logger = services.GetRequiredService<ILogger<InteractionHandler>>();
        }

        public async Task InitializeAsync()
        {
            // Process when the client is ready, so we can register our commands.
            _client.ShardReady += ReadyAsync;

            // Add the public modules that inherit InteractionModuleBase<T> to the InteractionService
            await _handler.AddModulesAsync(Assembly.GetEntryAssembly(), _services);

            // Process the InteractionCreated payloads to execute Interactions commands
            _client.InteractionCreated += HandleInteraction;
        }

        private async Task ReadyAsync(DiscordSocketClient arg)
        {
            BimBot.IsReady = true;
            // Context & Slash commands can be automatically registered, but this process needs to happen after the client enters the READY state.
            // Since Global Commands take around 1 hour to register, we should use a test guild to instantly update and test our commands.
            foreach (var guild in arg.Guilds)
            {
                await _handler.RegisterCommandsToGuildAsync(guild.Id, true);
            }

            if (Convert.ToBoolean(_configuration["IsDebug"]))
            {
                _logger.LogInformation("Debug mode is enabled!");
                await _handler.RegisterCommandsToGuildAsync(Convert.ToUInt64(_configuration["DebugGuilId"]), true);
            }
            else
            {
                await _handler.RegisterCommandsGloballyAsync(true);
            }
        }

        private async Task HandleInteraction(SocketInteraction interaction)
        {
            try
            {
                // Create an execution context that matches the generic type parameter of your InteractionModuleBase<T> modules.
                var context = new ShardedInteractionContext(
                    _client, interaction);

                // Execute the incoming command.
                var result = await _handler.ExecuteCommandAsync(context, _services);

                if (!result.IsSuccess)
                    switch (result.Error)
                    {
                        case InteractionCommandError.UnmetPrecondition:
                            // implement
                            break;
                        default:
                            break;
                    }
            }
            catch
            {
                // If Slash Command execution fails it is most likely that the original interaction acknowledgement will persist. It is a good idea to delete the original
                // response, or at least let the user know that something went wrong during the command execution.
                _logger.LogInformation($"{interaction.Type}");
                if (interaction.Type is InteractionType.ApplicationCommand)
                {
                    await interaction.GetOriginalResponseAsync().ContinueWith(async (msg) => await msg.Result.DeleteAsync());
                }
            }
        }
    }
}
