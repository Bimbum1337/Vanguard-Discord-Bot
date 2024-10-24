using BimBot.Database.Context;
using BimBot.Models;
using Discord.WebSocket;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Collections.Concurrent;
using System.Text;

namespace BimBot.Modules.Interactions.User
{

    public class InviteTracker
    {
        private readonly ILogger _logger;
        private readonly IConfigurationRoot _config;
        private readonly DiscordShardedClient _client;
        private ConcurrentDictionary<string, InviteLogger> _invites = new ConcurrentDictionary<string, InviteLogger>();

        public InviteTracker(IServiceProvider _services)
        {
            _logger = _services.GetRequiredService<ILogger<UserInteraction>>();
            _config = _services.GetRequiredService<IConfigurationRoot>();

            _client = _services.GetRequiredService<DiscordShardedClient>();

            _client.UserJoined += HandleUserJoined;
            _client.InviteCreated += HandleInviteCreated;
            _client.InviteDeleted += HandleInviteDeleted;
            _client.ShardReady += ReadyAsync;

            _logger.LogInformation($"InviteTracker loaded");
        }

        private async Task ReadyAsync(DiscordSocketClient client)
        {
            await Task.Run(() =>
            {
                foreach (var guild in client.Guilds)
                {
                    var invites = guild.GetInvitesAsync().GetAwaiter().GetResult();

                    foreach (var invite in invites)
                    {
                        _invites.TryAdd(invite.Code, new InviteLogger
                        {
                            Id = invite.Inviter.Id,
                            Uses = invite.Uses ?? 0
                        });
                    }
                }

                _logger.LogInformation($"InviteTracker loaded [{_invites.Count}] invites");
            });
        }
        private async Task HandleUserJoined(SocketGuildUser user)
        {
            if (!Convert.ToBoolean(_config["AllowInviteLogger"])) return;

            await Task.Run(async () =>
            {
                try
                {
                    foreach (var guild in _client.Guilds)
                    {
                        var invites = guild.GetInvitesAsync().GetAwaiter().GetResult();

                        foreach (var invite in invites)
                        {
                            if (_invites.ContainsKey(invite.Code) && _invites[invite.Code].Uses < invite.Uses)
                            {
                                using var context = new SRO_VT_BIMBOT();

                                var entry = context.InviteLoggers.FirstOrDefault(x => x.InviterId == invite.Inviter.Id && x.InvitedId == user.Id);

                                if (entry != null) continue;

                                await context.InviteLoggers.AddAsync(new Database.SRO_VT_BIMBOT.InviteLogger
                                {
                                    InviteCode = invite.Code,
                                    InviterId = invite.Inviter.Id,
                                    InviterDisplayName = invite.Inviter.Username,
                                    InvitedId = user.Id,
                                    InvitedDisplayName = user.Username
                                });

                                await context.SaveChangesAsync();

                                _invites[invite.Code].Uses = invite.Uses ?? 0;

                                ISocketMessageChannel messageChannel;

                                var channel = user.Guild.Channels.FirstOrDefault(x => x.Name.Equals(_config["InviteLoggerChannelName"]!));

                                if (channel == null)
                                {
                                    messageChannel = user.Guild.DefaultChannel;
                                }
                                else
                                {
                                    messageChannel = channel as ISocketMessageChannel;
                                }

                                var sb = new StringBuilder();

                                sb.Append($"User {guild.GetUser(invite.Inviter.Id).Mention} has invited {user.Mention} and has now {context.InviteLoggers.Where(x => x.InviterId == invite.Inviter.Id).Count()} invites!");

                                await messageChannel.SendMessageAsync(sb.ToString(), false);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError("An error occured while trying to handle on user joined " + ex.ToString());
                }
            });
        }

        private async Task HandleInviteCreated(SocketInvite invite)
        {
            await Task.Run(() =>
            {
                try
                {
                    _invites.TryAdd(invite.Code, new InviteLogger
                    {
                        Id = invite.Inviter.Id,
                        Uses = invite.Uses
                    });
                }
                catch (Exception ex)
                {
                    _logger.LogError("An error occured while trying to add invite " + ex.ToString());
                }
            });

        }

        private async Task HandleInviteDeleted(SocketGuildChannel channel, string inviteCode)
        {
            await Task.Run(() =>
            {
                try
                {
                    _invites.TryRemove(inviteCode, out var invite);
                }
                catch (Exception ex)
                {
                    _logger.LogError("An error occured while trying to remove invite " + ex.ToString());
                }
            });
        }
    }
}
