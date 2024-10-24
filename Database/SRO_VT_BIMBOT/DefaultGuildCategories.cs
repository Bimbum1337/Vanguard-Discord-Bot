namespace BimBot.Database.SRO_VT_BIMBOT
{
    public partial class DefaultGuildCategories
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public int Permission_ID { get; set; }
        public DefaultGuildCategoriesPermissions? CategoriesPermissions { get; set; }
        public virtual ICollection<DefaultGuildChannels> Channels { get; set; } = new List<DefaultGuildChannels>();
    }
}
