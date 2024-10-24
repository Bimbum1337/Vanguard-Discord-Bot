namespace BimBot.Database.SRO_VT_BIMBOT
{
    public partial class HelpEmbed
    {
        public int ID { get; set; }
        public string? Message { get; set; }
        public string EmbedTitle { get; set; } = null!;
        public string EmbedDescription { get; set; } = null!;
        public bool ShowDefaultThumbnail { get; set; } = false;
        public string? CustomImageUrl { get; set; }
        public bool MentionUser { get; set; } = false;
        public int Help_ID { get; set; }
        public Help? Help { get; set; }
    }
}
