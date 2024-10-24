using BimBot.Database.Context;
using Discord.Interactions;
using Discord.WebSocket;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BimBot.Modules.Interactions.User
{
    public class GiveawayInteraction : InteractionModuleBase<ShardedInteractionContext>
    {
        private static bool _isLinked = false;
        private static DiscordShardedClient _client;
        private readonly IConfigurationRoot _config;
        private readonly ILogger<TicketSystem> _logger;
        public GiveawayInteraction(IServiceProvider services)
        {
            _client = services.GetRequiredService<DiscordShardedClient>();

            _logger = services.GetRequiredService<ILogger<TicketSystem>>();

            if (!_isLinked)
            {

            }

            _isLinked = true;

            _config = services.GetRequiredService<IConfigurationRoot>();

            _logger.LogInformation("GiveawayInteraction module loaded!");
        }

        [ComponentInteraction("button_giveaway")]
        private async Task GiveawayInteractionHandler()
        {
            using var context = new SRO_VT_BIMBOT();

            var interaction = (Context.Interaction as SocketMessageComponent)!;

            var entry = await context.Giveaways.Include(x => x.Records).FirstOrDefaultAsync(x => x.MessageId == interaction.Message.Id);

            if (entry != null && entry.SecondsLeft > 0)
            {
                if (entry.Records.Any(x => x.UserID == Context.User.Id))
                {
                    await RespondAsync("You already joined this giveaway", ephemeral: true);
                }
                else
                {
                    entry.Records.Add(new Database.SRO_VT_BIMBOT.GiveawayRecords
                    {
                        UserID = Context.User.Id,
                        IsRewardTaken = false,
                        IsWinner = false,
                    });

                    await context.SaveChangesAsync();

                    await RespondAsync("You have successfully joined the giveaway", ephemeral: true);
                }
            }
            else
            {
                await RespondAsync("Giveaway already finished", ephemeral: true);
            }

            await DeferAsync();
        }
    }
}
