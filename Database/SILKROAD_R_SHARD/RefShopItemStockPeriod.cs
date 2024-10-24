using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefShopItemStockPeriod
{
    public byte Service { get; set; }

    public int Country { get; set; }

    public int Id { get; set; }

    public string RefShopGroupCodeName { get; set; } = null!;

    public string RefPackageItemCodeName { get; set; } = null!;

    public DateTime StockOpeningDate { get; set; }

    public DateTime StockExpireDate { get; set; }

    public byte PeriodDevice { get; set; }
}
