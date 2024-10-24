namespace BimBot.Database.SRO_VT_BIMBOT
{
    public partial class Help
    {
        public int ID { get; set; }
        public string OptionName { get; set; } = null!;
        public string OptionKey { get; set; } = null!;
        public string OptionDescription { get; set; } = null!;
        public string? OptionEmote { get; set; }
        public virtual ICollection<HelpEmbed> HelpEmbeds { get; set; } = new List<HelpEmbed>();
        public virtual ICollection<HelpMessage> HelpMessages { get; set; } = new List<HelpMessage>();
    }
}
