using BimBot.Database.Context;
using BimBot.Database.SRO_VT_BIMBOT;
using BimBot.Library.Utils;
using Discord;
using Discord.WebSocket;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Quartz;
using System.Text;

namespace BimBot.Library.CronTimer.Handlers
{
    public class Giveaway : IJob
    {
        private DiscordShardedClient _client;
        private ILogger<Giveaway> _logger;
        private IConfigurationRoot _config;
        public async Task Execute(IJobExecutionContext context)
        {
            try
            {
                if (!BimBot.IsReady) return;

                JobDataMap dataMap = context.JobDetail.JobDataMap;

                IServiceProvider _services = (IServiceProvider)dataMap["Services"];

                _client = _services.GetRequiredService<DiscordShardedClient>();
                _config = _services.GetRequiredService<IConfigurationRoot>();
                _logger = _services.GetRequiredService<ILogger<Giveaway>>();

                using var ctx = new SRO_VT_BIMBOT();

                var giveawaysList = await ctx.Giveaways.Where(x => x.SecondsLeft > 0).Include(x => x.Records).ToListAsync();

                foreach (var entry in giveawaysList)
                {
                    try
                    {
                        long newSecondsLeft = (long)entry.SecondsLeft - 3;

                        if (newSecondsLeft > 0)
                        {
                            entry.SecondsLeft = (ulong)newSecondsLeft;
                        }
                        else
                        {
                            entry.SecondsLeft = 0;
                        }

                        foreach (var guild in _client.Guilds)
                        {
                            var channel = guild.Channels.FirstOrDefault(x => x.Id == entry.ChannelID);

                            if (channel != null && channel is SocketTextChannel txtChannel)
                            {
                                var message = await txtChannel.GetMessageAsync(entry.MessageId);

                                if (message != null && message is IUserMessage userMessage)
                                {
                                    if (entry.SecondsLeft > 0)
                                    {
                                        EmbedBuilder Embed = new EmbedBuilder();
                                        Embed.WithColor(255, 0, 0);
                                        Embed.WithAuthor(message.Embeds.First()!.Author!.Value.Name);
                                        Embed.WithDescription($"React with :tada: to Enter!\n" + "Time remaining:" + Utility.CalculateTimeLeft(entry.SecondsLeft));

                                        await userMessage.ModifyAsync(x => x.Embed = Embed.Build());
                                    }
                                    else
                                    {
                                        var participants = GetRandomWinners(entry.Records, entry.WinnersCount);

                                        var sb = new StringBuilder();

                                        sb.AppendLine(":tada: Congratulations to winners :tada:");

                                        foreach (var participant in participants)
                                        {
                                            try
                                            {
                                                var user = guild.GetUser(participant.UserID);

                                                if (user != null)
                                                {
                                                    sb.AppendLine(user.Mention);

                                                    entry.Records.First(x => x.UserID == user.Id).IsWinner = true;
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                _logger.LogError($"Ouch failed to mark {participant.ID} as a winner");
                                            }
                                        }

                                        EmbedBuilder Embed = new EmbedBuilder();
                                        Embed.WithColor(255, 0, 0);
                                        Embed.WithAuthor(message.Embeds.First()!.Author!.Value.Name);

                                        await userMessage.ModifyAsync(x =>
                                        {
                                            x.Content = sb.ToString();
                                            x.Embed = Embed.Build();
                                        });
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError($"Error: {ex}");
                    }
                }

                await ctx.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex}");
            }

        }

        private List<GiveawayRecords> GetRandomWinners(ICollection<GiveawayRecords> Records, int count)
        {
            List<GiveawayRecords> recordsList = Records.ToList();
            Random random = new Random();

            for (int i = recordsList.Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                GiveawayRecords temp = recordsList[i];
                recordsList[i] = recordsList[j];
                recordsList[j] = temp;
            }

            List<GiveawayRecords> randomSubset = recordsList.Take(count).ToList();

            return randomSubset;
        }
    }
}
