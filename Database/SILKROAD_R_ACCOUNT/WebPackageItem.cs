using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class WebPackageItem
{
    public byte Service { get; set; }

    public int PackageId { get; set; }

    public string PackageCode { get; set; } = null!;

    public string? NameCode { get; set; }

    public string? ShopType { get; set; }

    public int ShopNo { get; set; }

    public int ShopNoSub { get; set; }

    public int EventNo { get; set; }

    public int EventNoSub { get; set; }

    public byte SilkType { get; set; }

    public int SilkPrice { get; set; }

    public int? SilkPriceGrow { get; set; }

    public int? SilkPriceItem { get; set; }

    public int DiscountRate { get; set; }

    public int? DiscountRateGrow { get; set; }

    public int? DiscountRateItem { get; set; }

    public int? OriginServer { get; set; }

    public int? GrowServer { get; set; }

    public int? ItemServer { get; set; }

    public byte? VipLevel { get; set; }

    public int? MonthLimit { get; set; }
}
