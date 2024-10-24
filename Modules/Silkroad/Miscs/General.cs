using BimBot.Database.Context;
using Discord;
using Discord.Interactions;
using Discord.WebSocket;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Text;

namespace BimBot.Modules.Silkroad.Miscs
{
    public class General : InteractionModuleBase<ShardedInteractionContext>
    {
        private static DiscordShardedClient? _client;
        private readonly ILogger<General> _logger;

        public General(IServiceProvider services)
        {
            _client = services.GetRequiredService<DiscordShardedClient>();
            _logger = services.GetRequiredService<ILogger<General>>();
            _logger.LogInformation("General module loaded!");
        }

        [SlashCommand("unique-status", "Get uniques status!")]
        public async Task UniqueStatus()
        {
            var menuBuilder = new SelectMenuBuilder()
                 .WithPlaceholder("Select an option")
                 .WithCustomId("select-unique")
                 .WithMinValues(1)
                 .WithMaxValues(1);

            using var context = new SRO_VT_BIMBOT();

            var uniqueList = await context.UniqueInformation.Include(x => x.Records).ToListAsync();
            foreach (var entry in uniqueList)
            {
                var record = entry.Records.OrderByDescending(x => x.DateTime).FirstOrDefault();

                bool state = record != null ? record.State : true;

                Emote emote = Emote.Parse(entry.Emote);

                menuBuilder.AddOption(entry.Name + (state ? $" (✅ Alive)" : $" (❌ Dead)"), entry.Name, emote: emote);

            }

            var actionRow = new ComponentBuilder()
                .WithSelectMenu(menuBuilder)
                .Build();

            await RespondAsync("", components: actionRow);
        }

        [ComponentInteraction("select-unique")]
        public async Task UniqueStatusInteractionHandler(string value)
        {
            await DeferAsync();

            using var context = new SRO_VT_BIMBOT();

            var uniqueList = await context.UniqueInformation.Include(x => x.Records).ToListAsync();

            var entry = uniqueList.FirstOrDefault(x => x.Name.Equals(value));

            var sb = new StringBuilder();


            EmbedBuilder embed = null;

            if (entry != null)
            {
                embed = new EmbedBuilder();

                embed.WithTitle(entry.Name);
                embed.WithThumbnailUrl(entry.ImageUrl);

                var record = entry.Records.Where(x => !x.State).OrderByDescending(x => x.DateTime).Take(10);

                sb.Append("``");
                sb.Append("Last 10 kills");
                sb.Append("``");

                sb.Append(" ");

                foreach (var k in record)
                {
                    sb.Append("```");
                    sb.Append($"Player [{k.Killer}] has killed it [{FormatTimeElapsed(k.DateTime)}] ago!");
                    sb.Append("```");
                }

                if (record.FirstOrDefault() != null)
                {
                    var isAlive = entry.Records.OrderByDescending(x => x.DateTime).First().State;

                    embed.AddField("State", isAlive ? $" (✅ Alive)" : $" (❌ Dead)");

                    if (!isAlive)
                        embed.AddField("Killer", record.First().Killer);

                    embed.AddField("LastSeen", FormatTimeElapsed(record.First().DateTime));
                }
                else
                {
                    embed.AddField("State", " (✅ Alive)");
                }
            }

            sb.Append(" ");

            await ModifyOriginalResponseAsync(x =>
            {
                x.Content = sb.ToString();
                x.Embed = embed != null ? embed.Build() : null;
            });
        }

        [SlashCommand("player-information", "Get player information!")]
        public async Task GetPlayerInformation(string charname)
        {
            using var context = new SILKROAD_R_SHARD();

            var _char = await context.Chars.FirstOrDefaultAsync(x => x.CharName16.Equals(charname));

            if (_char != null)
            {
                using var db = new SRO_VT_BIMBOT();

                var retnParam = new SqlParameter("@RetnParam", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@CharName", charname),
                    retnParam
                };

                await db.Database.ExecuteSqlRawAsync("_GetPlayerStatus @CharName, @RetnParam OUTPUT", parameters);

                var result = (int)retnParam.Value;

                var guild = await context.Guilds.FirstOrDefaultAsync(x => x.Id == _char.GuildId);

                EmbedBuilder Embed = new EmbedBuilder();
                Embed.WithColor(255, 0, 0);
                Embed.WithTitle($"{charname}");
                Embed.WithThumbnailUrl($"https://electus.online/images/characters/{_char.RefObjId}.png");
                Embed.AddField("Status", result == 1 ? ":green_circle:" : ":red_circle:", true);
                Embed.AddField("Guild", guild != null ? guild.Name : "<No Name>", true);
                Embed.AddField("Level", _char.CurLevel, true);
                Embed.AddField("Str", _char.Hp, true);
                Embed.AddField("Int", _char.Mp, true);
                Embed.AddField("Gold", _char.RemainGold, true);

                await RespondAsync(embed: Embed.Build());

                return;
            }

            await RespondAsync("Character was not found!", ephemeral: true);
        }

        [SlashCommand("top-levels", "Get top 10 players!")]
        public async Task GetTopLevels()
        {
            await Task.Run(async () =>
            {
                try
                {
                    using var context = new SILKROAD_R_SHARD();

                    var embed = new EmbedBuilder();
                    embed.WithColor(255, 255, 0);
                    embed.WithTitle($"Top 10 Levels");
                    var _chars = await context.Chars.OrderByDescending(x => x.CurLevel).OrderByDescending(x => x.ExpOffset).Take(10).ToListAsync();

                    var nameStringBuilder = new StringBuilder();
                    var levelStringBuilder = new StringBuilder();
                    var numStringBuildrr = new StringBuilder();

                    foreach (var character in _chars)
                    {
                        var expLevel =
                                (await context.RefLevels.FirstAsync(x => x.Lvl == character.CurLevel)).ExpC;

                        var expPerCent = ((Math.Round(100f * character.ExpOffset / expLevel))).ToString() + "%";

                        nameStringBuilder.AppendLine(character.CharName16);
                        numStringBuildrr.AppendLine(_chars.IndexOf(character) == 0 ? "🥇" :
                            _chars.IndexOf(character) == 1 ? "🥈" : _chars.IndexOf(character) == 2 ? "🥉" : (_chars.IndexOf(character) + 1).ToString());
                        levelStringBuilder.AppendLine(character.CurLevel + $" ({expPerCent})");
                    }

                    embed.AddField("#", numStringBuildrr.ToString(), true);
                    embed.AddField("Charname", nameStringBuilder.ToString(), true);
                    embed.AddField("Level", levelStringBuilder.ToString(), true);

                    await RespondAsync(embed: embed.Build());
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.ToString());
                }
            });
        }
        private string FormatTimeElapsed(DateTime startTime)
        {
            TimeSpan timeElapsed = DateTime.Now.Subtract(startTime);

            int days = timeElapsed.Days;
            int hours = timeElapsed.Hours;
            int minutes = timeElapsed.Minutes;
            int seconds = timeElapsed.Seconds;

            string formattedTimeElapsed = "";

            if (days > 0)
            {
                formattedTimeElapsed += $"{days} day{(days > 1 ? "s" : "")} ";
            }

            if (hours > 0)
            {
                formattedTimeElapsed += $"{hours} hour{(hours > 1 ? "s" : "")} ";
            }

            if (minutes > 0)
            {
                formattedTimeElapsed += $"{minutes} minute{(minutes > 1 ? "s" : "")} ";
            }

            formattedTimeElapsed += $"{seconds} second{(seconds > 1 ? "s" : "")}";

            return formattedTimeElapsed;
        }

    }
}
