using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class StatisticsPerformanceLog
{
    public string StepName { get; set; } = null!;

    public int ProcessingTimeInMs { get; set; }

    public DateTime LogIssued { get; set; }
}
