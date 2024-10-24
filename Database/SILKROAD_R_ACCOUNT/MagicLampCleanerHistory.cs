using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class MagicLampCleanerHistory
{
    public int Idx { get; set; }

    public int UserJid { get; set; }

    public int ChargeCleaner { get; set; }

    public int GiftCleaner { get; set; }

    public int Type { get; set; }

    public string? AdminId { get; set; }

    public string? Message { get; set; }

    public string? Ip { get; set; }

    public DateTime RegDate { get; set; }

    public string? CpInvoiceId { get; set; }

    public int? ErrorNo { get; set; }
}
