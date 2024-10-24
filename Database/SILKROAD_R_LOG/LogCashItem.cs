using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_LOG;

public partial class LogCashItem
{
    public int RefItemId { get; set; }

    public int CharId { get; set; }

    public short Cnt { get; set; }

    public DateTime EventTime { get; set; }

    public long Serial64 { get; set; }

    public byte ServiceCompany { get; set; }
}
