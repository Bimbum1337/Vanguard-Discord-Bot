using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_LOG;

public partial class ConsignmentTradeProgressRuntimeLog
{
    public int Id { get; set; }

    public DateTime EventTime { get; set; }

    public byte EventState { get; set; }

    public string? StrDesc { get; set; }
}
