using Discord;
using Discord.WebSocket;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BimBot.Modules.Interactions.User
{
    public class Suggestions
    {
        private readonly ILogger _logger;
        private readonly IConfigurationRoot _config;
        private readonly DiscordShardedClient _client;

        public Suggestions(IServiceProvider _services)
        {
            _logger = _services.GetRequiredService<ILogger<UserInteraction>>();
            _config = _services.GetRequiredService<IConfigurationRoot>();

            _client = _services.GetRequiredService<DiscordShardedClient>();

            _client.MessageReceived += MessageReceivedHandler;

            _logger.LogInformation("Suggestions module loaded!");

        }

        private async Task MessageReceivedHandler(SocketMessage messageDetails)
        {
            if (Convert.ToBoolean(_config["AllowSuggestionsReactions"]) &&
                messageDetails.Channel.Name.Equals(_config["SuggestionsChannelName"]))
            {
                var emots = _config["SuggestionsReactionsEmotes"]!.Split(",");

                foreach (var emote in emots)
                {
                    try
                    {
                        await messageDetails.AddReactionAsync(emote: Emote.Parse(emote));
                    }
                    catch (Exception e)
                    {
                        _logger.LogError($"{emote}:" + e.ToString());
                    }
                }
            }

        }
    }
}
