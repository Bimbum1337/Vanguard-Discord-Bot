namespace BimBot.Database.SRO_VT_BIMBOT
{
    public class DefaultSentMessages
    {
        public int ID { get; set; }
        public ulong ChannelID { get; set; }
        public ulong MessageID { get; set; }
        public SentMessagesType Type { get; set; }
    }
}
