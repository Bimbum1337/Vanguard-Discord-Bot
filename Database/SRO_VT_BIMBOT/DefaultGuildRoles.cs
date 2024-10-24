namespace BimBot.Database.SRO_VT_BIMBOT
{
    public partial class DefaultGuildRoles
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public int Color { get; set; }
        public bool CanMention { get; set; }
        public int Permission_ID { get; set; }
        public DefaultGuildRolesPermissions? RolesPermissions { get; set; }
    }
}
