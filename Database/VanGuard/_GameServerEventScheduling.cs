namespace BimBot.Database.VanGuard
{
    public partial class _GameServerEventScheduling
    {
        public int ID { get; set; }
        public string EventName { get; set; } = null!;
        public string CronTimerFormat { get; set; } = null!;
        public bool RegisterEnabled { get; set; } = false;
        public string? QueryName { get; set; }
        public int? QueryTimeOutSeconds { get; set; } = 0;
        public int NextOccurance { get; set; } = 0;
    }
}
