namespace BimBot.Database.SRO_VT_BIMBOT
{
    public partial class PollsLogger
    {
        public int ID { get; set; }
        public ulong MessageID { get; set; }
        public int AnswersCount { get; set; }
        public virtual ICollection<PollsLoggerRecords> Records { get; set; } = new List<PollsLoggerRecords>();
    }
}
