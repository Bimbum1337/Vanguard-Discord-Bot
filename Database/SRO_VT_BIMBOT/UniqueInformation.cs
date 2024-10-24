namespace BimBot.Database.SRO_VT_BIMBOT
{
    public class UniqueInformation
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string? Emote { get; set; }
        public virtual ICollection<UniqueInformationRecords> Records { get; set; } = new List<UniqueInformationRecords>();

    }
}
