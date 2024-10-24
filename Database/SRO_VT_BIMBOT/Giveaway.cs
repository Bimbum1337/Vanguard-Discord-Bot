namespace BimBot.Database.SRO_VT_BIMBOT
{
    public partial class Giveaway
    {
        public int ID { get; set; }
        public ulong ChannelID { get; set; }
        public ulong MessageId { get; set; }
        public int WinnersCount { get; set; }
        public ulong SecondsLeft { get; set; }
        public virtual ICollection<GiveawayRecords> Records { get; set; } = new List<GiveawayRecords>();
    }
}
