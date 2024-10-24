using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class WebItemBuyErrorLog
{
    public int Idx { get; set; }

    public int Category { get; set; }

    public int CpJid { get; set; }

    public long PortalJid { get; set; }

    public string OrderId { get; set; } = null!;

    public string InvoiceId { get; set; } = null!;

    public string InvoiceIdPortal { get; set; } = null!;

    public int ItemNo { get; set; }

    public int PriceNo { get; set; }

    public string? ItemCode { get; set; }

    public string ItemName { get; set; } = null!;

    public string ItemNamePortal { get; set; } = null!;

    public int Price { get; set; }

    public int Quantity { get; set; }

    public string IpAddr { get; set; } = null!;

    public DateTime RegDate { get; set; }

    public int? ErrorLoc { get; set; }

    public string ErrorCode { get; set; } = null!;

    public string ErrorValue { get; set; } = null!;
}
