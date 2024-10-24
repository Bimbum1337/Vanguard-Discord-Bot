namespace BimBot.Database.VanGuard
{
    public partial class _GameServerOnlinePlayerStatus
    {
        public int ID { get; set; }                     // Identity column (primary key)
        public string CharName { get; set; } = null!;            // VARCHAR(128)
        public int CharID { get; set; }                 // INT
        public int JID { get; set; }                    // INT
        public string IP { get; set; } = null!;                   // VARCHAR(20)
        public string HWID { get; set; } = null!;                 // VARCHAR(MAX)
        public bool IsInJobMode { get; set; }           // BIT
        public bool IsInFW { get; set; }                // BIT
        public bool IsInSafeZone { get; set; }          // BIT
        public bool IsInExchangeState { get; set; }     // BIT (DEFAULT 0)
        public byte JobType { get; set; }               // TINYINT
        public int Region { get; set; }                 // INT
        public byte Status { get; set; } = 1;           // TINYINT (DEFAULT 1)
    }
}
