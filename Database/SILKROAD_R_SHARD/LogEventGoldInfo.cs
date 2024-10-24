using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class LogEventGoldInfo
{
    public DateTime? Eventtime { get; set; }

    public string? CurrentMachine { get; set; }

    public string? AppName { get; set; }

    public string? CurrentUser { get; set; }

    public string? Eventtype { get; set; }

    public string? Tsql { get; set; }
}
