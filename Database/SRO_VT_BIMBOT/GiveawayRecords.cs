namespace BimBot.Database.SRO_VT_BIMBOT
{
    public partial class GiveawayRecords
    {
        public int ID { get; set; }
        public ulong UserID { get; set; }
        public bool IsWinner { get; set; }
        public bool IsRewardTaken { get; set; }
        public int Giveaway_ID { get; set; }
        public Giveaway? Giveaway { get; set; }
    }
}
