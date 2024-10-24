using BimBot.Database.Context;
using Microsoft.EntityFrameworkCore;

namespace BimBot.Library.Utils
{
    public static class Utility
    {
        public static string CalculateTimeLeft(ulong secondsLeft)
        {
            if (secondsLeft == 0)
            {
                return " 0 Seconds";
            }
            ulong secondsInDay = 24 * 60 * 60;
            ulong secondsInHour = 60 * 60;
            ulong secondsInMinute = 60;

            ulong days = secondsLeft / secondsInDay;
            ulong hours = (secondsLeft % secondsInDay) / secondsInHour;
            ulong minutes = (secondsLeft % secondsInHour) / secondsInMinute;
            ulong seconds = secondsLeft % secondsInMinute;

            string timeLeft = "";

            if (days > 0)
                timeLeft += $"{days} {(days == 1 ? "day" : "days")} ";

            if (hours > 0)
                timeLeft += $"{hours} {(hours == 1 ? "hour" : "hours")} ";

            if (minutes > 0)
                timeLeft += $"{minutes} {(minutes == 1 ? "minute" : "minutes")} ";

            if (seconds > 0)
                timeLeft += $"{seconds} {(seconds == 1 ? "second" : "seconds")} ";

            return timeLeft.Trim();
        }

        public static async Task SendEventNotice(string notice)
        {
            using var context = new VanGuard();
            await context.Database.ExecuteSqlRawAsync($"EXEC _ShardManagerSendNotice 0, 5, '{notice}'");
        }

        public static async Task SendUserNotice(int CharID, string notice)
        {
            using var context = new VanGuard();
            await context.Database.ExecuteSqlRawAsync($"EXEC _ShardManagerSendNotice {CharID}, 1, '{notice}'");
        }

        public static async Task SetSafeZoneRegion(int nRegion, bool bState)
        {
            using var context = new VanGuard();
            await context.Database.ExecuteSqlRawAsync($"EXEC _ShardManagerSetRegionSafeZoneState {nRegion}, {bState}");
        }

        public static async Task TeleportPlayer(int CharID, int RegionID, float X, float Y, float Z, int LayerID, int WorldID)
        {
            using var context = new VanGuard();
            await context.Database.ExecuteSqlRawAsync($"EXEC _ShardManagerTeleportPlayer {CharID}, {RegionID}, {X}, {Y}, {Z}, {LayerID}, {WorldID}");
        }

        public static async Task TeleportPlayerToTown(int CharID)
        {
            using var context = new VanGuard();
            await context.Database.ExecuteSqlRawAsync($"EXEC _ShardManagerTeleportPlayerToTown {CharID}");
        }

        public static async Task SendTimer(int CharID, int time)
        {
            using var context = new VanGuard();
            await context.Database.ExecuteSqlRawAsync($"EXEC _ShardManagerSendTimerByCharID {CharID}, {time}");
        }

        public static async Task SpawnObjectByKey(string key, int ObjID, int RegionID, float X, float Y, float Z, int LayerID, int WorldID)
        {
            using var context = new VanGuard();
            await context.Database.ExecuteSqlRawAsync($"EXEC _ShardManagerSpawnObjectByKey '{key}', {ObjID}, {RegionID}, {X}, {Y}, {Z}, {LayerID}, {WorldID}, 0, 3");
        }

        public static async Task DeSpawnObjectByKey(string key)
        {
            using var context = new VanGuard();
            await context.Database.ExecuteSqlRawAsync($"EXEC _ShardManagerSpawnObjectRemoveByKey '{key}'");
        }

        public static async Task<int> GetUserCharIDByName(string name)
        {
            using var context = new SILKROAD_R_SHARD();
            var entry = await context.Chars.FirstOrDefaultAsync(x => x.CharName16 == name);
            if (entry != null)
            {
                return entry.CharId;
            }

            return 0;
        }
        public static async Task<T> GetSetting<T>(string key)
        {
            using var context = new VanGuard();

            var entry = await context.Configs.FirstOrDefaultAsync(x => x.Name == key);
            if (entry == null)
            {
                throw new Exception($"Key {key} not found in the database.");
            }

            var value = entry.Value;

            try
            {
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch (InvalidCastException ex)
            {
                throw new Exception($"Error converting {key}'s value to type {typeof(T).Name}: {ex.Message}");
            }
        }
    }
}
