namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class SKpiSalesRawDatum
{
    public DateTime SalesMonth { get; set; }

    public string? ShardName { get; set; }

    public int RefItemId { get; set; }

    public int CharId { get; set; }

    public int Jid { get; set; }
}
