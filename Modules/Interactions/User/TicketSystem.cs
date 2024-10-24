using BimBot.Database.Context;
using Discord;
using Discord.Interactions;
using Discord.WebSocket;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Text;

namespace BimBot.Modules.Interactions.User
{
    public class TicketSystem : InteractionModuleBase<ShardedInteractionContext>
    {
        private static bool _isLinked = false;
        private static DiscordShardedClient _client;
        private readonly IConfigurationRoot _config;
        private readonly ILogger<TicketSystem> _logger;

        public TicketSystem(IServiceProvider services)
        {
            _client = services.GetRequiredService<DiscordShardedClient>();

            _logger = services.GetRequiredService<ILogger<TicketSystem>>();

            if (!_isLinked)
            {
                _client.ShardReady += ReadyAsync;
                _client.ReactionAdded += ReactionAddedHandler;
            }

            _isLinked = true;

            _config = services.GetRequiredService<IConfigurationRoot>();

            _logger.LogInformation("TicketSystem module loaded!");
        }

        private async Task ReadyAsync(DiscordSocketClient client)
        {
            await Task.Run(async () =>
            {
                foreach (var guild in client.Guilds)
                {
                    using var context = new SRO_VT_BIMBOT();

                    var defaultMessages = await context.DefaultSentMessages.ToListAsync();

                    var message = defaultMessages.FirstOrDefault(x => x.Type == SentMessagesType.TicketMessage);

                    var channel = guild.Channels.FirstOrDefault(x => x.Name.Equals(_config["TicketSystemChannelName"]));

                    if (channel != null)
                    {
                        if (message == null)
                        {
                            await SendTicketSystemMessage(channel);
                        }
                        else
                        {
                            var messages = await (channel as SocketTextChannel)!.GetMessagesAsync(100).FlattenAsync();

                            bool found = false;

                            foreach (var msg in messages)
                            {
                                if (msg.Id == message.MessageID)
                                {
                                    found = true;
                                    break;
                                }
                            }

                            if (!found)
                            {
                                context.DefaultSentMessages.Remove(message);

                                await context.SaveChangesAsync();

                                await SendTicketSystemMessage(channel);
                            }
                        }
                    }
                }
            });
        }

        public async Task ReactionAddedHandler(Cacheable<IUserMessage, ulong> react, Cacheable<IMessageChannel, ulong> chl, SocketReaction sreact)
        {
            if (chl.Value.Name.StartsWith("ticket-"))
            {
                var user = sreact.User.Value as SocketGuildUser;
                if (!user!.IsBot && sreact.Emote.Name.Equals("🔒"))
                {
                    using var context = new SRO_VT_BIMBOT();

                    var entry = await context.TicketSystem.FirstOrDefaultAsync(x => x.UserID == user.Id);

                    if (entry != null && chl.Value is SocketTextChannel channel)
                    {
                        context.TicketSystem.Remove(entry);

                        await context.SaveChangesAsync();

                        await channel.DeleteAsync();
                    }
                }
            }
        }
        private async Task SendTicketSystemMessage(SocketGuildChannel channel)
        {
            var sb = new StringBuilder();

            sb.AppendLine("To create a ticket please react with " + ":envelope_with_arrow: ");

            sb.AppendLine("You cannot have more than 1 ticket running");

            if (channel is SocketTextChannel chl)
            {
                var messagesToDelete = await chl.GetMessagesAsync(100).FlattenAsync();
                if (messagesToDelete.Count() > 0)
                {
                    await ((ITextChannel)chl).DeleteMessagesAsync(messagesToDelete);
                }

                using var context = new SRO_VT_BIMBOT();

                EmbedBuilder Embed = new EmbedBuilder();
                Embed.WithColor(255, 0, 0);
                Embed.WithTitle($"Ticket System");
                Embed.WithDescription(sb.ToString());

                var cb = new ComponentBuilder();

                var btn = new ButtonBuilder()
                    .WithCustomId($"button_ticket_system")
                    .WithLabel("Create a ticket")
                    .WithStyle(ButtonStyle.Secondary)
                    .WithEmote(new Emoji("📩"));

                cb.WithButton(btn);

                var msg = await chl.SendMessageAsync(embed: Embed.Build(), components: cb.Build());

                await context.DefaultSentMessages.AddAsync(new Database.SRO_VT_BIMBOT.DefaultSentMessages
                {
                    ChannelID = chl.Id,
                    MessageID = msg.Id,
                    Type = SentMessagesType.TicketMessage
                });

                await context.SaveChangesAsync();
            }
        }

        [ComponentInteraction("button_ticket_system")]
        private async Task TicketSystemInteractionHandler()
        {
            using var context = new SRO_VT_BIMBOT();

            var tickets = await context.TicketSystem.ToListAsync();

            if (tickets.Count(x => x.IsActive) > 15)
            {
                await RespondAsync("Tickets system is currently busy, please try again later", ephemeral: true);

                await DeferAsync();

                return;
            }

            if (tickets.FirstOrDefault(x => x.UserID == Context.User.Id) != null)
            {
                await RespondAsync("Only one active ticket is allowed per user", ephemeral: true);

                await DeferAsync();

                return;
            }

            var record = new Database.SRO_VT_BIMBOT.TicketSystem
            {
                IsActive = true,
                TicketID = await context.TicketSystem.CountAsync() + 1,
                UserID = Context.User.Id,
            };

            var entry = await context.TicketSystem.AddAsync(record);

            await context.SaveChangesAsync();

            var channel = await Context.Guild.CreateTextChannelAsync($"ticket-{record.TicketID.ToString("0000")}");

            await channel.AddPermissionOverwriteAsync(Context.Guild.EveryoneRole, GetEveryOnePermissions(), null);

            await channel.AddPermissionOverwriteAsync(Context.User, GetOurUserPermission(), null);

            await channel.AddPermissionOverwriteAsync(_client.CurrentUser, GetBotPermissions(), null);

            EmbedBuilder Embed = new EmbedBuilder();
            Embed.WithColor(0, 255, 0);
            Embed.WithDescription($"Support will be with you shortly.\nTo close this ticket react with " + ":lock:");

            var message = await channel.SendMessageAsync("", false, Embed.Build());

            Emoji ticket = new Emoji("🔒");

            await message.AddReactionAsync(ticket);

            await DeferAsync();
        }

        public static OverwritePermissions GetBotPermissions()
        {
            return new OverwritePermissions(PermValue.Allow,
                                            PermValue.Allow,
                                            PermValue.Allow,
                                            PermValue.Allow,
                                            PermValue.Allow,
                                            PermValue.Allow,
                                            PermValue.Allow,
                                            PermValue.Allow,
                                            PermValue.Allow,
                                            PermValue.Allow,
                                            PermValue.Allow,
                                            PermValue.Allow,
                                            PermValue.Allow,
                                            PermValue.Allow,
                                            PermValue.Allow,
                                            PermValue.Allow,
                                            PermValue.Allow,
                                            PermValue.Allow,
                                            PermValue.Allow,
                                            PermValue.Allow);
        }
        public static OverwritePermissions GetEveryOnePermissions()
        {
            return new OverwritePermissions(PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Deny, // This parameter is for the 'viewChannel' permission
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit);
        }
        public static OverwritePermissions GetEveryOnePermissions_allow()
        {
            return new OverwritePermissions(PermValue.Deny,
                                            PermValue.Deny,
                                            PermValue.Deny,
                                            PermValue.Allow, // This parameter is for the 'viewChannel' permission
                                            PermValue.Deny,
                                            PermValue.Deny,
                                            PermValue.Deny,
                                            PermValue.Deny,
                                            PermValue.Deny,
                                            PermValue.Deny,
                                            PermValue.Deny,
                                            PermValue.Deny,
                                            PermValue.Deny,
                                            PermValue.Deny,
                                            PermValue.Deny,
                                            PermValue.Deny,
                                            PermValue.Deny,
                                            PermValue.Deny,
                                            PermValue.Deny,
                                            PermValue.Deny);
        }
        public static OverwritePermissions GetOurUserPermission()
        {
            return new OverwritePermissions(PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Allow, // This parameter is for the 'viewChannel' permission
                                            PermValue.Allow, // This parameter is for the 'SendMessage' permission
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit,
                                            PermValue.Inherit);
        }
    }
}
