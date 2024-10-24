namespace BimBot.Database.SRO_VT_BIMBOT
{
    public partial class PollsLoggerRecords
    {
        public int ID { get; set; }
        public ulong UserID { get; set; }
        public int AnswerID { get; set; }
        public string? Feedback { get; set; }
        public int Poll_ID { get; set; }
        public PollsLogger? PollsLogger { get; set; }
    }
}
