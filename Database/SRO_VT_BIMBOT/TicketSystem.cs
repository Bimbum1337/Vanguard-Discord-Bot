namespace BimBot.Database.SRO_VT_BIMBOT
{
    public class TicketSystem
    {
        public int ID { get; set; }
        public int TicketID { get; set; }
        public ulong UserID { get; set; }
        public bool IsActive { get; set; }
    }
}
