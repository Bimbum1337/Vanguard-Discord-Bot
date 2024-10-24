namespace BimBot.Database.VanGuard
{
    public partial class _SharedContentConfig
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public string Value { get; set; } = null!;
        public string Type { get; set; } = null!;
    }
}
