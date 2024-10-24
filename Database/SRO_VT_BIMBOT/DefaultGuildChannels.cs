namespace BimBot.Database.SRO_VT_BIMBOT
{
    public partial class DefaultGuildChannels
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public int Category_ID { get; set; }
        public DefaultGuildCategories? Category { get; set; }

    }
}
