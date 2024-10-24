using BimBot.Database.Context;
using BimBot.Database.SRO_VT_BIMBOT;
using Discord;
using Discord.Interactions;
using Discord.WebSocket;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace BimBot.Modules.Interactions.Admin
{
    public class Admin : InteractionModuleBase<ShardedInteractionContext>
    {
        private static bool _isLinked = false;
        private static DiscordShardedClient _client;
        private readonly IConfigurationRoot _config;
        private readonly ILogger<Admin> _logger;

        public Admin(IServiceProvider services)
        {
            _client = services.GetRequiredService<DiscordShardedClient>();
            _logger = services.GetRequiredService<ILogger<Admin>>();
            if (!_isLinked)
            {
                _client.MessageReceived += WordFinder;
            }
            _isLinked = true;
            // _cc = services.GetRequiredService<ChannelCheck>();
            _config = services.GetRequiredService<IConfigurationRoot>();
            //   _prefix = _config["prefix"];
            _logger.LogInformation("Admin module loaded!");
        }

        private async Task WordFinder(SocketMessage messageDetails)
        {
            if (messageDetails.Content.IsNullOrEmpty()) return;

            await Task.Run(async () =>
            {
                if (!messageDetails.Author.IsBot)
                {
                    using var context = new SRO_VT_BIMBOT();

                    var words = await context.BlackListWords.ToListAsync();

                    bool wordFound = false;
                    foreach (var singleWord in words)
                    {
                        foreach (var content in messageDetails.Content.ToLower().Split(' '))
                        {
                            if (content.Contains(singleWord.Word.ToLower()))
                            {
                                wordFound = true;
                            }
                        }
                    }

                    if (wordFound)
                    {
                        await messageDetails.Channel.SendMessageAsync($"{messageDetails.Author.Mention} This message has been deleted because it contains bad words!");
                        await messageDetails.DeleteAsync();
                    }
                }
            });

        }

        [SlashCommand("show-servers", "show servers the bot is in")]
        [RequireOwner]
        public async Task ListGuilds()
        {
            StringBuilder sb = new StringBuilder();
            var guilds = _client.Guilds.ToList();
            foreach (var guild in guilds)
            {
                sb.AppendLine($"Name: {guild.Name} Id: {guild.Id} Owner: {guild.Owner}");
            }
            await RespondAsync(sb.ToString(), ephemeral: true);
        }

        [SlashCommand("kick", "kick someone!")]
        [RequireBotPermission(GuildPermission.KickMembers)]
        [DefaultMemberPermissions(GuildPermission.KickMembers)]
        public async Task KickUser(IGuildUser user, string? reason = null)
        {
            var embed = new EmbedBuilder();
            embed.ThumbnailUrl = user.GetAvatarUrl();
            StringBuilder sb = new StringBuilder();
            try
            {
                //await user.SendMessageAsync($"You've been kicked from [**{Context.Guild.Name}**] by [**{Context.User.Username}**]: [**{reason}**]");
                await user.KickAsync();
                embed.Title = $"Kicking {user.Username}";
                if (string.IsNullOrEmpty(reason))
                {
                    reason = "Buh bye.";
                }
                sb.AppendLine($"Reason: [**{reason}**]");
            }
            catch (Exception ex)
            {
                embed.Title = $"Error attempting to kick {user.Username}";
                sb.AppendLine($"[{ex.Message}]");
            }
            embed.Description = sb.ToString();
            embed.WithColor(new Color(0, 0, 255));
            await RespondAsync(embed: embed.Build());
        }

        [SlashCommand("ban", "ban someone!")]
        [RequireBotPermission(GuildPermission.BanMembers)]
        [DefaultMemberPermissions(GuildPermission.KickMembers)]
        public async Task BanUser(IGuildUser user, string? args = null)
        {
            int pruneDays = 0;
            string reason = "Buy bye!";
            if (args != null)
            {
                try
                {
                    pruneDays = int.Parse(args.Split(" ")[0]);
                }
                catch (Exception ex)
                {
                    pruneDays = 0;
                }
                var numArgs = args.Split(" ").Count();
                if (numArgs > 1)
                {
                    int iValue = 0;
                    if (pruneDays > 0)
                    {
                        iValue = 1;
                    }
                    reason = string.Empty;
                    for (int i = iValue; i <= numArgs - 1; i++)
                    {
                        if (i + 1 == numArgs - 1)
                        {
                            reason += $"{args.Split(" ")[i]}";
                        }
                        else
                        {
                            reason += $" {args.Split(" ")[i]} ";
                        }
                    }
                    reason = reason.Trim();
                }
                else if (pruneDays == 0)
                {
                    reason = args;
                }
            }
            var embed = new EmbedBuilder();
            embed.ThumbnailUrl = user.GetAvatarUrl();
            StringBuilder sb = new StringBuilder();
            try
            {
                //await user.SendMessageAsync($"You have been banned from [**{Context.Guild.Name}**] -> [**{reason}**]");
                await Context.Guild.AddBanAsync(user, pruneDays, reason);
                embed.Title = $"Banning {user.Username}";
                sb.AppendLine($"Reason: [**{reason}**]");
            }
            catch (Exception ex)
            {
                embed.Title = $"Error attempting to ban {user.Username}";
                sb.AppendLine($"[{ex.Message}]");
            }
            embed.Description = sb.ToString();
            embed.WithColor(new Color(0, 0, 255));
            await RespondAsync(embed: embed.Build());
        }

        [SlashCommand("unban", "unban someone!")]
        [RequireBotPermission(GuildPermission.BanMembers)]
        [DefaultMemberPermissions(GuildPermission.KickMembers)]
        public async Task UnBanUser(string user)
        {
            var embed = new EmbedBuilder();
            embed.ThumbnailUrl = Context.Guild.IconUrl;
            StringBuilder sb = new StringBuilder();
            var currentBans = Context.Guild.GetBansAsync().FlattenAsync().Result;
            var bannedUser = currentBans.Where(c => c.User.Username.Contains(user)).FirstOrDefault();
            if (bannedUser != null)
            {
                try
                {
                    await Context.Guild.RemoveBanAsync(bannedUser.User.Id);
                    embed.Title = $"UnBanning {bannedUser.User.Username}";
                }
                catch (Exception ex)
                {
                    embed.Title = $"Error attempting to unban {bannedUser.User.Username}";
                    sb.AppendLine($"[{ex.Message}]");
                }
            }
            else
            {
                embed.Title = $"{user} not found!";
                sb.AppendLine($"Unable to find [{user}] in the ban list!");
            }
            embed.Description = sb.ToString();
            embed.WithColor(new Color(0, 0, 255));
            await RespondAsync(embed: embed.Build());
        }

        [SlashCommand("list-bans", "list bans!")]
        [RequireBotPermission(GuildPermission.BanMembers)]
        [RequireUserPermission(GuildPermission.BanMembers)]
        public async Task ListBans()
        {
            var embed = new EmbedBuilder();
            embed.ThumbnailUrl = Context.Guild.IconUrl;
            StringBuilder sb = new StringBuilder();
            try
            {
                embed.Title = $"User bans on {Context.Guild.Name}";
                var bans = Context.Guild.GetBansAsync();
                if (bans.FlattenAsync().Result.Count() > 0)
                {
                    foreach (var ban in bans.FlattenAsync().Result)
                    {
                        string reason = ban.Reason;
                        if (string.IsNullOrEmpty(reason))
                        {
                            reason = "/shrug";
                        }
                        sb.AppendLine($":black_medium_small_square: **{ban.User.Username}** (*{reason}*)");
                    }
                }
                else
                {
                    sb.AppendLine($"Much empty, such space!");
                }

            }
            catch (Exception ex)
            {
                embed.Title = $"Error attempting to list bans for **{Context.Guild.Name}**";
                sb.AppendLine($"[{ex.Message}]");
            }
            embed.Description = sb.ToString();
            embed.WithColor(new Color(0, 0, 255));
            //await _client.Log("test")
            await RespondAsync(embed: embed.Build(), ephemeral: true);
        }

        [SlashCommand("clear", "clear x amount of messages from a channel max is 25")]
        [RequireBotPermission(GuildPermission.ManageMessages)]
        [RequireUserPermission(GuildPermission.ManageMessages)]
        public async Task ClearMessage(int numberOfMessages = 5)
        {
            if (numberOfMessages > 25)
            {
                numberOfMessages = 25;
            }

            var messagesToDelete = await Context.Channel.GetMessagesAsync(numberOfMessages).FlattenAsync();
            await ((ITextChannel)Context.Channel).DeleteMessagesAsync(messagesToDelete);

            await RespondAsync($"Successfully deleted {messagesToDelete.Count()} messages", ephemeral: true);

        }

        [SlashCommand("new-server", "Creating all channles and roles on behalf of you")]
        [RequireOwner]
        public async Task NewServer()
        {
            await RespondAsync("Creating everything please wait..", ephemeral: true);

            using var context = new SRO_VT_BIMBOT();

            var roles = await context.DefaultGuildRoles.Include(x => x.RolesPermissions).ToListAsync();

            foreach (var role in roles)
            {
                await Context.Guild.CreateRoleAsync(role.Name, _GetRolesPermissions(role.RolesPermissions), new Color((uint)role.Color), role.CanMention);
            }

            var categories = await context.DefaultGuildCategories.Include(x => x.Channels).Include(x => x.CategoriesPermissions).ToListAsync();

            foreach (var category in categories)
            {
                var createdCategory = await Context.Guild.CreateCategoryChannelAsync(category.Name);
                await createdCategory.AddPermissionOverwriteAsync(Context.Guild.EveryoneRole, _GetCategoriesPermissions(category.CategoriesPermissions));

                foreach (var channel in category.Channels)
                {
                    var createdChannel = await Context.Guild.CreateTextChannelAsync(channel.Name);

                    await createdChannel.ModifyAsync(prop => prop.CategoryId = createdCategory.Id);

                    await createdChannel.SyncPermissionsAsync();
                }
            }

            await ModifyOriginalResponseAsync(x =>
            {
                x.Content = "Successfully initialized the server.";
            });
        }

        [SlashCommand("reset-server", "Deleting all categories, channels and roles from the guild")]
        [RequireOwner]
        public async Task ResetServer(bool deleteCategories = true, bool deleteChannels = true, bool deleteRoles = true)
        {
            await RespondAsync("Deleteing everything please wait...", ephemeral: true);

            foreach (var guild in _client.Guilds)
            {
                if (deleteCategories)
                {
                    foreach (var channel in guild.CategoryChannels)
                    {
                        await channel.DeleteAsync();
                    }
                }

                if (deleteChannels)
                {
                    foreach (var channel in guild.Channels)
                    {
                        await channel.DeleteAsync();
                    }
                }

                if (deleteRoles)
                {
                    foreach (var role in guild.Roles)
                    {
                        await role.DeleteAsync();
                    }
                }
            }

            await ModifyOriginalResponseAsync(x =>
            {
                x.Content = "Successfully resetting the server.";
            });
        }
        private GuildPermissions _GetRolesPermissions(DefaultGuildRolesPermissions? perm)
        {
            return new GuildPermissions(perm.CanCreateInvite,//create invite
                                               perm.CanKickMembers,//kick members
                                               perm.CanBanMembers,//ban members
                                               perm.IsAdministrator,//administrator
                                               perm.CanManageChannel,//manage channel
                                               perm.CanManageGuild,//manage guild
                                               perm.CanAddReaction,//add reaction
                                               perm.CanViewAudit,//view audit log
                                               perm.CanViewGuildInsights, // view guild insights
                                               perm.CanViewChannel,//view channel
                                               perm.CanSendMessage,//send messages
                                               perm.CanSendTTS,//send tts
                                               perm.CanManageMessages,//manage messages
                                               perm.CanSendEmbedLinks,//embed links
                                               perm.CanAttachFiles,//attach files
                                               perm.CanReadMessagesHistory,//read message history
                                               perm.CanMentionEveryOne,//mention everyone
                                               perm.CanUseExternalEmoji,//use emoji
                                               perm.CanConnect,//connect
                                               perm.CanSpeak,//speak
                                               perm.CanMuteMembers,//mute members
                                               perm.CanDefeanMembers,//deafen members
                                               perm.CanMoveMembers,//move members
                                               perm.CanUseVoiceActivation,//use voice activiation
                                               perm.CanPrioritySpeaker,//priority speaker
                                               perm.CanStream,//stream
                                               perm.CanChangeNickName,//changeNickname
                                               perm.CanManageNickName,//manage nickname
                                               perm.CanManageRoles,
                                               perm.CanManageWebHooks,
                                               perm.CanManageEmojisAndStickers,
                                               perm.CanUseApplicationCommands,
                                               perm.CanRequestToSpeak,
                                               perm.CanManageEvents,
                                               perm.CanManageThreads,
                                               perm.CanCreatePublicThreads,
                                               perm.CanCreatePrivateThreads,
                                               perm.CanUseExternalStickers,
                                               perm.CanSendMessagesInThread,
                                               perm.CanStartEmbedActivities,
                                               perm.CanModerateMembers,
                                               perm.CanUseSoundBoard,
                                               perm.CanViewMonetizationAnalytics,
                                               perm.CanSendVoiceMessages
                                               );//manage roles
        }

        private OverwritePermissions _GetCategoriesPermissions(DefaultGuildCategoriesPermissions? perm)
        {
            return new OverwritePermissions(perm.CanCreateInvite,//createinvite
                                perm.CanManageChannel,//managechannel
                                perm.CanAddReaction,//addreaction
                                perm.CanViewChannel,//viewchannel
                                perm.CanSendMessage,//sendmessages
                                perm.CanSendTTS,//sendTTSMessages
                                perm.CanManageMessages,//manageMessages
                                perm.CanSendEmbedLinks,//embedlinks
                                perm.CanAttachFiles,//attachFiles
                                perm.CanReadMessagesHistory,//readmessagehistory
                                perm.CanMentionEveryOne,//mentionEveryone
                                perm.CanUseExternalEmoji,//useExternalEmojis
                                perm.CanConnect,//connect
                                perm.CanSpeak,//speak
                                perm.CanMuteMembers,//muteMembers
                                perm.CanDefeanMembers,//deafen
                                perm.CanMoveMembers,//moveMembers
                                perm.CanUseVoiceActivation,//useVoiceActivation
                                perm.CanManageRoles,//manageRoles
                                perm.CanManageWebHooks,
                                perm.CanPrioritySpeaker,
                                perm.CanStream,
                                perm.CanUseSlashCommands,
                                perm.CanUseApplicationCommands,
                                perm.CanRequestToSpeak,
                                perm.CanManageThreads,
                                perm.CanCreatePublicThreads,
                                perm.CanCreatePrivateThreads,
                                perm.CanUsePublicThreads,
                                perm.CanUsePrivateThreads,
                                perm.CanUseExternalStickers,
                                perm.CanSendMessagesInThread,
                                perm.CanStartEmbedActivities);//manageWebhooks
        }

    }
}
