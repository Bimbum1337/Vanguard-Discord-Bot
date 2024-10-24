using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class TemporalyBlockedIphistory
{
    public string? Ip { get; set; }

    public DateTime? Date { get; set; }
}
