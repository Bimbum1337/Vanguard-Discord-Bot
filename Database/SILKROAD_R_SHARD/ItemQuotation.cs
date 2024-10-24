using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class ItemQuotation
{
    public int Id { get; set; }

    public int Service { get; set; }

    public int AssocNpc { get; set; }

    public int RefItemId { get; set; }

    public float BaseQuot { get; set; }

    public float QuotLb { get; set; }

    public float QuotUb { get; set; }

    public int BaseStockAmount { get; set; }

    public int FluctuateAmount { get; set; }

    public int CurStockAmount { get; set; }
}
