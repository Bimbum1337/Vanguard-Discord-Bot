using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class ShopItemStockQuantity
{
    public byte Service { get; set; }

    public int Country { get; set; }

    public string RefShopGroupCodeName { get; set; } = null!;

    public string RefPackageItemCodeName { get; set; } = null!;

    public short ConstStockQuantity { get; set; }

    public short StockQuantity { get; set; }
}
