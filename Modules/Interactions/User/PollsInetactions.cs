using BimBot.Database.Context;
using BimBot.Models;
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
    public class PollsInetactions : InteractionModuleBase<ShardedInteractionContext>
    {
        private static DiscordShardedClient _client;
        private readonly IConfigurationRoot _config;
        private readonly ILogger<PollsInetactions> _logger;

        public PollsInetactions(IServiceProvider services)
        {
            _client = services.GetRequiredService<DiscordShardedClient>();

            _logger = services.GetRequiredService<ILogger<PollsInetactions>>();

            _config = services.GetRequiredService<IConfigurationRoot>();

            _logger.LogInformation("PollsInetactions module loaded!");
        }

        [ComponentInteraction("pollbutton_*")]
        public async Task PollButtonsInteraction(int value)
        {
            var sb = new StringBuilder();

            var interaction = (Context.Interaction as SocketMessageComponent)!;

            using var context = new SRO_VT_BIMBOT();

            var polls = await context.PollsLoggers.Include(x => x.Records).ToListAsync();

            var record = polls.FirstOrDefault(x => x.MessageID == interaction.Message.Id);

            if (record != null)
            {
                var entry = record.Records.FirstOrDefault(x => x.UserID == Context.User.Id);

                var answerBtn = interaction.Message.Components.First().Components.FirstOrDefault(x => x.CustomId.Equals($"pollbutton_{value}"));
                if (answerBtn != null && answerBtn is ButtonComponent answ)
                {
                    sb.AppendLine($"``Successfully updated your answer to [{answ.Label}]``");
                }

                if (entry != null)
                {
                    entry.AnswerID = value;
                }
                else
                {
                    sb.AppendLine($"``Successfully saved your record {value}``");

                    record.Records.Add(new Database.SRO_VT_BIMBOT.PollsLoggerRecords
                    {
                        UserID = Context.User.Id,
                        AnswerID = value
                    });
                }

                await context.SaveChangesAsync();

                var count = record.AnswersCount;

                sb.AppendLine($"``Result is:``");
                for (int i = 1; i <= count; i++)
                {
                    var answer = interaction.Message.Components.First().Components.FirstOrDefault(x => x.CustomId.Equals($"pollbutton_{i}"));

                    if (answer != null && answer is ButtonComponent ans)
                    {
                        double ratio = ((double)record.Records.Count(x => x.AnswerID == i) / (double)record.Records.Count()) * 100f;

                        sb.AppendLine($"```[{ans.Label}] with {ratio}%```");
                    }
                }

            }
            sb.AppendLine(" ");

            var cb = new ComponentBuilder();

            var btn = new ButtonBuilder()
                .WithCustomId($"poll_feedback{interaction.Message.Id}")
                .WithLabel("Feedback")
                .WithStyle(ButtonStyle.Secondary)
                .WithEmote(Emote.Parse("<a:CH_IconPartnerBadge:780717472683917334>"));

            cb.WithButton(btn);

            await RespondAsync(sb.ToString(), ephemeral: true, components: cb.Build());

            await DeferAsync();
        }

        [ComponentInteraction("poll_feedback*")]
        private async Task FeedBackInteraction(ulong MessageId)
        {
            var mb = new ModalBuilder()
                .WithTitle("Feedback")
                .WithCustomId($"poll_Modal{MessageId}")
                .AddTextInput("Feedback", "feed_back", TextInputStyle.Paragraph, value: "");

            await RespondWithModalAsync(mb.Build());

            await DeferAsync();
        }

        [ModalInteraction("poll_Modal*")]
        private async Task ModalInteraction(ulong messageId, ModalsBase modal)
        {
            var interaction = Context.Interaction as SocketModal;

            var feedback = interaction!.Data.Components.FirstOrDefault(x => x.CustomId == "feed_back");

            if (feedback != null)
            {
                using var context = new SRO_VT_BIMBOT();

                var entry = context.PollsLoggers.Include(x => x.Records).FirstOrDefault(x => x.MessageID == messageId);

                if (entry != null)
                {
                    var record = entry.Records.FirstOrDefault(x => x.UserID == interaction.User.Id);

                    if (record != null)
                    {
                        record.Feedback = interaction.Data.Components.First().Value;

                        await context.SaveChangesAsync();
                    }
                }
            }

            await DeferAsync();
        }
    }
}
