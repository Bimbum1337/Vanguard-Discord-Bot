using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_LOG;

public partial class LogWebCashItem
{
    public int CharId { get; set; }

    public int EventId { get; set; }

    public long Idx { get; set; }

    public long SubIdx { get; set; }

    public int Section { get; set; }

    public int? RefItemId { get; set; }

    public int? Count { get; set; }

    public DateTime RecvDate { get; set; }

    public long Serial64 { get; set; }

    public string? StrDesc { get; set; }
}
