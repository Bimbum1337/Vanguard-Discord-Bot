using Discord;
using Discord.WebSocket;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Text;

namespace BimBot.Modules.Interactions.User
{
    public class UserInteraction
    {
        private readonly ILogger _logger;
        private readonly IConfigurationRoot _config;

        public UserInteraction(IServiceProvider _services)
        {
            _logger = _services.GetRequiredService<ILogger<UserInteraction>>();
            _config = _services.GetRequiredService<IConfigurationRoot>();

            _services.GetRequiredService<DiscordShardedClient>().UserJoined += HandleGreeting;
            _services.GetRequiredService<DiscordShardedClient>().UserLeft += HandleParting;

            _logger.LogInformation($"UserInteractions loaded");
        }

        private async Task HandleParting(SocketGuild guild, SocketUser socketUser)
        {
            if (!Convert.ToBoolean(_config["PartingPlayersOnLeave"])) return;

            await Task.Run(async () =>
            {
                var user = (SocketGuildUser)socketUser;
                var sb = new StringBuilder();
                ISocketMessageChannel messageChannel = null;
                try
                {
                    var channel = user.Guild.Channels.FirstOrDefault(x => x.Name.Equals(_config["PartingPlayersChannelName"]!));

                    if (channel == null)
                    {
                        messageChannel = user.Guild.DefaultChannel;
                    }
                    else
                    {
                        messageChannel = channel as ISocketMessageChannel;
                    }

                    if (messageChannel != null)
                    {
                        var embed = new EmbedBuilder();

                        embed.Title = $"[{user.Username}] has left [**{user.Guild.Name}**]!";
                        sb.AppendLine($"{user.Mention}");
                        sb.AppendLine($"Fine, be that way! :wave:");
                        embed.Description = sb.ToString();
                        embed.ThumbnailUrl = user.GetAvatarUrl();
                        embed.WithColor(new Color(255, 0, 0));

                        await messageChannel.SendMessageAsync("", false, embed.Build());
                    }
                }
                catch (Exception ex)
                {
                    if (messageChannel != null)
                    {
                        _logger.LogError($"Error with channel -> [{messageChannel.Name}] on [{user.Guild.Name}] -> [{user.Guild.Id}] -> [{ex.Message}]");
                    }
                    else
                    {
                        _logger.LogError($"Error with no channel -> [{user.Guild.Name}] -> [{user.Guild.Id}] -> [{ex.Message}]");
                    }
                }
            });
        }
        private async Task HandleGreeting(SocketGuildUser user)
        {
            if (!Convert.ToBoolean(_config["GreatPlayersOnJoin"])) return;

            await Task.Run(async () =>
            {
                var sb = new StringBuilder();
                ISocketMessageChannel messageChannel = null;
                try
                {
                    var channel = user.Guild.Channels.FirstOrDefault(x => x.Name.Equals(_config["GreatPlayersChannelName"]!));

                    if (channel == null)
                    {
                        messageChannel = user.Guild.DefaultChannel;
                    }
                    else
                    {
                        messageChannel = channel as ISocketMessageChannel;
                    }

                    var embed = new EmbedBuilder();

                    embed.Title = $"[{user.Username}] has joined [**{user.Guild.Name}**]!";
                    sb.AppendLine($"{user.Mention}");
                    sb.AppendLine($"Welcome him! :hugging:");
                    sb.AppendLine($"(or not, :shrug:)");
                    embed.Description = sb.ToString();
                    embed.ThumbnailUrl = user.GetAvatarUrl();
                    embed.WithColor(new Color(0, 255, 0));

                    await messageChannel.SendMessageAsync("", false, embed.Build());
                }
                catch (Exception ex)
                {
                    if (messageChannel != null)
                    {
                        _logger.LogError($"Error with channel -> [{messageChannel.Name}] on [{user.Guild.Name}] -> [{user.Guild.Id}] -> [{ex.Message}]");
                    }
                    else
                    {
                        _logger.LogError($"Error with no channel -> [{user.Guild.Name}] -> [{user.Guild.Id}] -> [{ex.Message}]");
                    }
                }
            });
        }
    }
}
