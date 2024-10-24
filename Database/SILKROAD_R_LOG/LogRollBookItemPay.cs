using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_LOG;

public partial class LogRollBookItemPay
{
    public string? CharName { get; set; }

    public int? EventId { get; set; }

    public int? Level { get; set; }

    public int? Race { get; set; }

    public int? Gender { get; set; }

    public string? PayItemCodeName { get; set; }

    public DateTime? LogDate { get; set; }
}
