using BimBot.Database.Context;
using BimBot.Library.CronTimer.Events;
using BimBot.Library.Utils;
using BimBot.Models;
using Discord;
using Discord.WebSocket;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Quartz;
using System.Text;

namespace BimBot.Library.CronTimer.Handlers
{
    public class CommandExecutor : IJob
    {
        private DiscordShardedClient _client;
        private IConfigurationRoot _config;
        private static bool isRunning = false;
        public async Task Execute(IJobExecutionContext context)
        {
            try
            {
                if (isRunning) return;

                isRunning = true;

                JobDataMap dataMap = context.JobDetail.JobDataMap;

                IServiceProvider _services = (IServiceProvider)dataMap["Services"];

                _client = _services.GetRequiredService<DiscordShardedClient>();
                _config = _services.GetRequiredService<IConfigurationRoot>();

                if (!BimBot.IsReady)
                {
                    isRunning = false;
                    return;
                }

                var ctx = new SRO_VT_BIMBOT();

                var commands = await ctx.DatabaseCommands.ToListAsync();

                foreach (var command in commands)
                {
                    switch (command.Command)
                    {
                        case CommandType.NormalMessage:
                            {
                                await SendMessage(command.Data1 ?? "", command.Data2 ?? "", Convert.ToBoolean(command.Data3 ?? "false"));
                            }
                            break;
                        case CommandType.EmbedMessage:
                            {
                                await SendMessage(command.Data1 ?? "", command.Data2 ?? "", Convert.ToBoolean(command.Data3 ?? "false"), true, command.Data4 ?? "", command.Data5 ?? "", Convert.ToUInt32(command.Data6 ?? "15158332"),
                                    command.Data7 ?? "", command.Data8 ?? "");
                            }
                            break;
                        case CommandType.CreatePoll:
                            {
                                await CreatePoll(command.Data1 ?? "", command.Data2 ?? "", command.Data3 ?? "", command.Data4 ?? "", command.Data5 ?? "", Convert.ToBoolean(command.Data6 ?? "true"));
                            }
                            break;
                        case CommandType.CreateGiveaway:
                            {
                                await CreateGiveaway(command.Data1 ?? "", command.Data2 ?? "", Convert.ToUInt64(command.Data3 ?? "0"), Convert.ToInt32(command.Data4 ?? "0"));
                            }
                            break;

                        //todo done one base class for both
                        case CommandType.PvPMatchingWinner:
                            {
                                MatchingPvP.winner = command.Data1!;
                                MatchingPvP.eventWaitHandle.Set();
                            }
                            break;

                        case CommandType.UniqueMatchingWinner:
                            {
                                MatchingUnique.winner = command.Data1!;
                                MatchingUnique.eventWaitHandle.Set();
                            }
                            break;

                        case CommandType.OnDisconnect:
                            {
                                //todo raise events
                                int CharID = 0;
                                if (int.TryParse(command.Data1, out CharID))
                                {
                                    await MatchingPvP.OnPlayerDisconnect(CharID);
                                    await MatchingUnique.OnPlayerDisconnect(CharID);
                                }
                            }
                            break;
                    }

                    await ctx.Database.ExecuteSqlRawAsync($"DELETE FROM _DatabaseCommands Where ID like {command.ID}");
                }

                isRunning = false;
            }
            catch (Exception ex)
            {
                isRunning = false;

                Console.WriteLine(ex.ToString());
            }

        }

        private async Task SendMessage(string channelName, string message, bool mentionEveryone, bool isEmbed = false, string embedTitle = "",
                                                            string embedDescription = "", uint embedColor = 15158332, string imageUrl = "", string thumbnailUrl = "")
        {
            foreach (var guild in _client.Guilds)
            {
                var channel = guild.Channels.FirstOrDefault(x => x.Name.Equals(channelName));

                if (channel != null && channel is SocketTextChannel textChannel)
                {
                    var sb = new StringBuilder();

                    if (mentionEveryone)
                    {
                        sb.AppendLine("@everyone");
                        sb.AppendLine();
                    }

                    sb.AppendLine(message);

                    if (isEmbed)
                    {
                        var embed = new EmbedBuilder()
                            .WithTitle(embedTitle)
                            .WithDescription(embedDescription)
                            .WithColor(new Discord.Color(embedColor))
                            .WithImageUrl(imageUrl)
                            .WithThumbnailUrl(thumbnailUrl);

                        await textChannel.SendMessageAsync(sb.ToString(), embed: embed.Build());

                        return;
                    }

                    await textChannel.SendMessageAsync(sb.ToString());
                }
            }
        }

        private async Task CreatePoll(string channelName, string title, string description, string buttonsJson, string imageUrl, bool mentionEveryone)
        {
            foreach (var guild in _client.Guilds)
            {
                var channel = guild.Channels.FirstOrDefault(x => x.Name.Equals(channelName));

                if (channel != null && channel is SocketTextChannel textChannel)
                {
                    var sb = new StringBuilder();

                    if (mentionEveryone)
                    {
                        sb.AppendLine("@everyone");
                        sb.AppendLine();
                    }

                    var embed = new EmbedBuilder()
                            .WithTitle(title)
                            .WithDescription(description)
                            .WithColor(Discord.Color.Blue)
                            .WithImageUrl(imageUrl);

                    Dictionary<string, CompButton>? buttons = JsonConvert.DeserializeObject<Dictionary<string, CompButton>>(buttonsJson);

                    var cb = new ComponentBuilder();

                    if (buttons != null)
                    {
                        foreach (var button in buttons)
                        {
                            var emote = Emote.Parse(button.Value.Emote);

                            var btn = new ButtonBuilder()
                                .WithCustomId(button.Key)
                                .WithLabel(button.Value.Label)
                                .WithStyle(ButtonStyle.Secondary)
                                .WithEmote(emote);

                            cb.WithButton(btn);
                        }
                    }

                    var message = await textChannel.SendMessageAsync(sb.ToString(), embed: embed.Build(), components: cb.Build());

                    using var context = new SRO_VT_BIMBOT();

                    await context.PollsLoggers.AddAsync(new Database.SRO_VT_BIMBOT.PollsLogger
                    {
                        MessageID = message.Id,
                        AnswersCount = buttons!.Count
                    });

                    await context.SaveChangesAsync();
                }
            }
        }

        private async Task CreateGiveaway(string channelName, string message, ulong secondsLeft, int winnersCount)
        {
            foreach (var guild in _client.Guilds)
            {
                var channel = guild.Channels.FirstOrDefault(x => x.Name.Equals(channelName));

                if (channel != null && channel is SocketTextChannel textChannel)
                {
                    EmbedBuilder Embed = new EmbedBuilder();
                    Embed.WithColor(255, 0, 0);
                    Embed.WithAuthor(message);
                    Embed.WithDescription($"React with :tada: to Enter!\n" + "Time remaining:" + Utility.CalculateTimeLeft(secondsLeft));

                    var cb = new ComponentBuilder();

                    var emote = new Emoji("🎉");

                    var btn = new ButtonBuilder()
                                .WithCustomId("button_giveaway")
                                .WithLabel("Join")
                                .WithStyle(ButtonStyle.Secondary)
                                .WithEmote(emote);

                    cb.WithButton(btn);

                    var msg = await textChannel.SendMessageAsync("@everyone \n" + ":game_die: **GIVEAWAY**  :game_die:", embed: Embed.Build(), components: cb.Build());

                    using var context = new SRO_VT_BIMBOT();

                    await context.Giveaways.AddAsync(new Database.SRO_VT_BIMBOT.Giveaway
                    {
                        SecondsLeft = secondsLeft,
                        ChannelID = textChannel.Id,
                        MessageId = msg.Id,
                        WinnersCount = winnersCount
                    });

                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
