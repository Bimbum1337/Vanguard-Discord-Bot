using BimBot.Database.Context;
using Discord;
using Discord.Interactions;
using Discord.WebSocket;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace BimBot.Modules.Silkroad.Guide
{
    public class Help : InteractionModuleBase<ShardedInteractionContext>
    {
        private static DiscordShardedClient _client;
        private readonly ILogger<Help> _logger;

        public Help(IServiceProvider services)
        {
            _client = services.GetRequiredService<DiscordShardedClient>();
            _logger = services.GetRequiredService<ILogger<Help>>();
            _logger.LogInformation("Help module loaded!");
        }

        [SlashCommand("help", "Frequently asked questions!")]
        public async Task HelpHandler()
        {
            var menuBuilder = new SelectMenuBuilder()
                 .WithPlaceholder("Select an option")
                 .WithCustomId("help-menu")
                 .WithMinValues(1)
                 .WithMaxValues(1);

            using var context = new SRO_VT_BIMBOT();

            var helpList = await context.Help.ToListAsync();

            foreach (var entry in helpList)
            {
                var emote = entry.OptionEmote == null ? null : Emote.Parse(entry.OptionEmote);

                menuBuilder.AddOption(entry.OptionName, entry.OptionKey, entry.OptionDescription, emote);
            }

            var actionRow = new ComponentBuilder()
                .WithSelectMenu(menuBuilder)
                .Build();

            await RespondAsync("", ephemeral: true, components: actionRow);
        }

        [ComponentInteraction("help-menu")]
        public async Task MenuInteractionHandler(string value)
        {
            var context = new SRO_VT_BIMBOT();

            var helpDict = await context.Help.Include(x => x.HelpMessages).Include(x => x.HelpEmbeds).ToDictionaryAsync(x => x.OptionKey);

            EmbedBuilder embed = null;
            string message = string.Empty;
            bool mention = false;

            if (helpDict.TryGetValue(value, out var result))
            {
                var messageEntry = result.HelpMessages.FirstOrDefault();
                if (messageEntry != null)
                {
                    mention = messageEntry.MentionUser;
                    message = messageEntry.Message;
                }

                var embedEntry = result.HelpEmbeds.FirstOrDefault();
                if (embedEntry != null)
                {
                    embed = new EmbedBuilder();
                    mention = mention || embedEntry.MentionUser;
                    message = embedEntry.Message ?? message;

                    embed.Title = embedEntry.EmbedTitle;

                    string inputDescription = embedEntry.EmbedDescription;
                    StringBuilder stringBuilder = new StringBuilder();

                    foreach (char c in inputDescription)
                    {
                        if (c == '\\')
                        {
                            if (stringBuilder.Length > 0 && stringBuilder[stringBuilder.Length - 1] == '\\')
                            {
                                stringBuilder.Remove(stringBuilder.Length - 1, 1);
                                stringBuilder.Append(c);
                            }
                            else
                            {
                                stringBuilder.Append(Environment.NewLine);
                            }
                        }
                        else
                        {
                            // Append any other character
                            stringBuilder.Append(c);
                        }
                    }

                    embed.Description = stringBuilder.ToString();

                    if (embedEntry.ShowDefaultThumbnail)
                    {
                        embed.ThumbnailUrl = Context.User.GetAvatarUrl();
                    }

                    if (!embedEntry.CustomImageUrl.IsNullOrEmpty())
                    {
                        embed.ImageUrl = embedEntry.CustomImageUrl;
                    }
                }
            }

            message = message + " " + Context.User.Mention;

            await RespondAsync(text: message, embed: embed == null ? null : embed.Build());

        }

    }

}
