using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class VwWebPackageItemList
{
    public byte Service { get; set; }

    public string PackageCode { get; set; } = null!;

    public string? NameCode { get; set; }

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

    public int PackageId { get; set; }

    public string? PackageName { get; set; }

    public string? UsExplain { get; set; }

    public string? UsUseMethod { get; set; }

    public string? UsUseRestriction { get; set; }

    public string? TrExplain { get; set; }

    public string? TrUseMethod { get; set; }

    public string? TrUseRestriction { get; set; }

    public string? EgExplain { get; set; }

    public string? EgUseMethod { get; set; }

    public string? EgUseRestriction { get; set; }

    public string? EsExplain { get; set; }

    public string? EsUseMethod { get; set; }

    public string? EsUseRestriction { get; set; }

    public string? DeExplain { get; set; }

    public string? DeUseMethod { get; set; }

    public string? DeUseRestriction { get; set; }

    public string? ShopName { get; set; }

    public string? SubName { get; set; }

    public int RefNo { get; set; }

    public int SubNo { get; set; }

    public int EventNo { get; set; }

    public int EventNoSub { get; set; }

    public int? AddMall { get; set; }
}
