namespace BimBot.Database.SRO_VT_BIMBOT
{
    public partial class HelpMessage
    {
        public int ID { get; set; }
        public string Message { get; set; } = null!;
        public bool MentionUser { get; set; } = false;
        public int Help_ID { get; set; }
        public Help? Help { get; set; }
    }
}
