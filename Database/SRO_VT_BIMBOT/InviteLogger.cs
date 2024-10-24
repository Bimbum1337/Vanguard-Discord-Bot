namespace BimBot.Database.SRO_VT_BIMBOT
{
    public class InviteLogger
    {
        public int ID { get; set; }
        public string InviteCode { get; set; } = null!;
        public ulong InviterId { get; set; }
        public string InviterDisplayName { get; set; } = null!;
        public ulong InvitedId { get; set; }
        public string InvitedDisplayName { get; set; } = null!;
    }
}
