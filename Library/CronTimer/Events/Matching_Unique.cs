using BimBot.Database.Context;
using BimBot.Database.VanGuard;
using BimBot.Library.Utils;
using Microsoft.EntityFrameworkCore;
using Quartz;

namespace BimBot.Library.CronTimer.Events
{
    public class MatchingUnique : IJob
    {
        public static bool isRunning = false;
        public static ManualResetEventSlim eventWaitHandle = new ManualResetEventSlim(initialState: false);
        public static string participant1 = "";
        public static string participant2 = "";
        public static string winner = "";

        public async Task Execute(IJobExecutionContext context)
        {
            try
            {
                if (isRunning) return;
                isRunning = true;

                using var van = new VanGuard();

                var participants = await van.MatchingData.Where(x => x.EventType == 1).ToListAsync();

                var validParticipants = participants.Where(participant => IsParticipantValid(participant).GetAwaiter().GetResult()).Take(2).ToList();
                if (validParticipants.Count == 2)
                {
                    await Utility.DeSpawnObjectByKey("MatchingUnique");

                    await Utility.SetSafeZoneRegion(await Utility.GetSetting<ushort>("WARP_BATTLE_ZONE_UNIQUE_REGION_PLAYER1"), true);
                    await Utility.SetSafeZoneRegion(await Utility.GetSetting<ushort>("WARP_BATTLE_ZONE_UNIQUE_REGION_PLAYER2"), true);

                    participant1 = validParticipants[0].CharName;
                    participant2 = validParticipants[1].CharName;

                    van.MatchingData.RemoveRange(validParticipants);
                    await van.SaveChangesAsync();

                    await Utility.SendEventNotice($"[Unique Matching] {participant1} vs {participant2}");

                    await Utility.TeleportPlayer(await Utility.GetUserCharIDByName(participant1),
                        await Utility.GetSetting<ushort>("WARP_BATTLE_ZONE_UNIQUE_REGION_PLAYER1"),
                        await Utility.GetSetting<float>("WARP_BATTLE_ZONE_UNIQUE_X_PLAYER1"),
                        await Utility.GetSetting<float>("WARP_BATTLE_ZONE_UNIQUE_Y_PLAYER1"),
                        await Utility.GetSetting<float>("WARP_BATTLE_ZONE_UNIQUE_Z_PLAYER1"),
                        await Utility.GetSetting<ushort>("WARP_BATTLE_ZONE_UNIQUE_WORLDLAYERID_PLAYER1"),
                        await Utility.GetSetting<ushort>("WARP_BATTLE_ZONE_UNIQUE_WORLDID_PLAYER1")
                        );

                    await Utility.TeleportPlayer(await Utility.GetUserCharIDByName(participant2),
                        await Utility.GetSetting<ushort>("WARP_BATTLE_ZONE_UNIQUE_REGION_PLAYER2"),
                        await Utility.GetSetting<float>("WARP_BATTLE_ZONE_UNIQUE_X_PLAYER2"),
                        await Utility.GetSetting<float>("WARP_BATTLE_ZONE_UNIQUE_Y_PLAYER2"),
                        await Utility.GetSetting<float>("WARP_BATTLE_ZONE_UNIQUE_Z_PLAYER2"),
                        await Utility.GetSetting<ushort>("WARP_BATTLE_ZONE_UNIQUE_WORLDLAYERID_PLAYER2"),
                        await Utility.GetSetting<ushort>("WARP_BATTLE_ZONE_UNIQUE_WORLDID_PLAYER2")
                        );

                    if (!eventWaitHandle.Wait(TimeSpan.FromMilliseconds(await Utility.GetSetting<int>("BATTLE_ZONE_UNIQUE_PREPARE_TIME"))))
                    {
                        await Utility.SendUserNotice(await Utility.GetUserCharIDByName(participant1), "Kill the unique to win!");
                        await Utility.SendUserNotice(await Utility.GetUserCharIDByName(participant2), "Kill the unique to win!");

                        await Utility.SendTimer(await Utility.GetUserCharIDByName(participant1), await Utility.GetSetting<int>("BATTLE_ZONE_UNIQUE_RUNNING_TIME"));
                        await Utility.SendTimer(await Utility.GetUserCharIDByName(participant2), await Utility.GetSetting<int>("BATTLE_ZONE_UNIQUE_RUNNING_TIME"));

                        await Utility.SetSafeZoneRegion(await Utility.GetSetting<ushort>("WARP_BATTLE_ZONE_UNIQUE_REGION_PLAYER1"), false);
                        await Utility.SetSafeZoneRegion(await Utility.GetSetting<ushort>("WARP_BATTLE_ZONE_UNIQUE_REGION_PLAYER2"), false);

                        await Utility.SpawnObjectByKey("MatchingUnique",
                            await Utility.GetSetting<int>("BATTLE_ZONE_UNIQUE_REFOBJID"),
                            await Utility.GetSetting<ushort>("BATTLE_ZONE_UNIQUE_REGION"),
                            await Utility.GetSetting<float>("BATTLE_ZONE_UNIQUE_X"),
                            await Utility.GetSetting<float>("BATTLE_ZONE_UNIQUE_Y"),
                            await Utility.GetSetting<float>("BATTLE_ZONE_UNIQUE_Z"),
                            await Utility.GetSetting<ushort>("BATTLE_ZONE_UNIQUE_WORLDLAYERID"),
                            await Utility.GetSetting<ushort>("BATTLE_ZONE_UNIQUE_WORLDID")
                            );

                        if (eventWaitHandle.Wait(TimeSpan.FromMilliseconds(await Utility.GetSetting<int>("BATTLE_ZONE_UNIQUE_RUNNING_TIME"))))
                        {
                            await OnWinnerAnnounce();
                        }
                        else
                        {
                            await Utility.SendEventNotice($"[Unique Matching] {participant1} vs {participant2} ended without any winners");
                        }

                        await Utility.TeleportPlayerToTown(await Utility.GetUserCharIDByName(participant1));
                        await Utility.TeleportPlayerToTown(await Utility.GetUserCharIDByName(participant2));
                    }
                    else
                    {
                        await OnWinnerAnnounce();

                        await Utility.TeleportPlayerToTown(winner == participant1 ? await Utility.GetUserCharIDByName(participant1) : await Utility.GetUserCharIDByName(participant2));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            _Stop();
        }

        public static async Task OnPlayerDisconnect(int CharID)
        {
            using var context = new SILKROAD_R_SHARD();
            var entry = await context.Chars.FirstOrDefaultAsync(x => x.CharId == CharID);

            if (entry != null)
            {
                if (entry.CharName16 == participant1)
                {
                    winner = participant2;

                    eventWaitHandle.Set();
                }
                else if (entry.CharName16 == participant2)
                {
                    winner = participant1;

                    eventWaitHandle.Set();
                }

                using var van = new VanGuard();
                await van.Database.ExecuteSqlRawAsync($"EXEC _ShardManagerOnReportUniqueMatching_WINNER {entry.CharId}, '{winner}', 1");
            }

        }
        private async Task<bool> IsParticipantValid(_GameServerMatching_Register_Participants participant)
        {
            try
            {
                using var van = new VanGuard();

                var user = await van.OnlinePlayers.FirstOrDefaultAsync(x => x.CharName.Equals(participant.CharName));
                if (user != null)
                {
                    if (user.Status == 1 && user.IsInSafeZone && !user.IsInExchangeState && !user.IsInJobMode) return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        private async Task OnWinnerAnnounce()
        {
            await Utility.SendEventNotice($"[Unique Matching] {winner} has won");

            using var context = new VanGuard();
            await context.Database.ExecuteSqlRawAsync($"INSERT INTO _GameServerMatchingLogs VALUES(1, {await Utility.GetUserCharIDByName(winner)}, {await Utility.GetUserCharIDByName(winner == participant1 ? participant2 : participant1)})");
        }

        private void _Stop()
        {
            eventWaitHandle.Reset();
            isRunning = false;
            participant1 = string.Empty;
            participant2 = string.Empty;
        }
    }
}
