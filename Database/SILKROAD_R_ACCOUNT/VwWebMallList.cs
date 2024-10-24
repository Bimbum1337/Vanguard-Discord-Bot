using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class VwWebMallList
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

    public string? ShopNameUs { get; set; }

    public string? SubNameUs { get; set; }

    public int ShopOrder { get; set; }

    public int SubOrder { get; set; }

    public string? ShopNameTr { get; set; }

    public string? SubNameTr { get; set; }

    public string? ShopNameEg { get; set; }

    public string? SubNameEg { get; set; }

    public string? ShopNameEs { get; set; }

    public string? SubNameEs { get; set; }

    public string? ShopNameDe { get; set; }

    public string? SubNameDe { get; set; }

    public int RefNo { get; set; }

    public int SubNo { get; set; }

    public int ItemOrder { get; set; }

    public byte IsBest { get; set; }

    public int IsNew { get; set; }

    public int IsList { get; set; }

    public byte Active { get; set; }

    public DateTime RegDate { get; set; }
}
