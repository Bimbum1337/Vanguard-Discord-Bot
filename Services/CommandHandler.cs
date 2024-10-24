using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BimBot.Services
{
    public class CommandHandler
    {
        private CommandService _commands;
        private DiscordShardedClient _client;
        private readonly IConfigurationRoot _config;
        private readonly ILogger _logger;
        private readonly IServiceProvider _services;

        public CommandHandler(IServiceProvider services)
        {
            _services = services;
            _config = services.GetRequiredService<IConfigurationRoot>();
            _client = services.GetRequiredService<DiscordShardedClient>();
            _commands = services.GetRequiredService<CommandService>();
            _client.MessageReceived += HandleCommand;
            _logger = services.GetRequiredService<ILogger<CommandHandler>>();
        }

        public async Task HandleCommand(SocketMessage parameterMessage)
        {
            // Don't handle the command if it is a system message            
            var message = parameterMessage as SocketUserMessage;
            if (message == null) return;

            // Don't listen to bots
            if (message.Source != MessageSource.User)
            {
                return;
            }

            // Create a Command Context
            var context = new ShardedCommandContext(_client, message);

            // Execute the Command, store the result            
            var result = await _commands.ExecuteAsync(context, 0, _services);

            await LogCommandUsage(context, result);

            // If the command failed, notify the user
            if (result.IsSuccess)
            {
                if (result.ErrorReason != "Unknown command.")
                {
                    await message.Channel.SendMessageAsync($"**Error:** {result.ErrorReason}");
                }
            }
        }

        private async Task LogCommandUsage(SocketCommandContext context, Discord.Commands.IResult result)
        {
            await Task.Run(() =>
            {
                if (context.Channel is IGuildChannel)
                {
                    var logTxt = $"User: [{context.User.Username}]<->[{context.User.Id}] Discord Server: [{context.Guild.Name}] -> [{context.Message.Content}]";
                    _logger.LogInformation(logTxt);
                }
                else
                {
                    var logTxt = $"User: [{context.User.Username}]<->[{context.User.Id}] -> [{context.Message.Content}]";
                    _logger.LogInformation(logTxt);
                }
            });
        }
    }
}
