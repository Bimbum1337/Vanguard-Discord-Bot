namespace BimBot.Database.SRO_VT_BIMBOT
{
    public class UniqueInformationRecords
    {
        public int ID { get; set; }
        public bool State { get; set; } = true;
        public string? Killer { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public int Unique_ID { get; set; }
        public UniqueInformation? UniqueInformation { get; set; }
    }
}
