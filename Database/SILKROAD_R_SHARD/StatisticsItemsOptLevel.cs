using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class StatisticsItemsOptLevel
{
    public int NIdx { get; set; }

    public string? SzType { get; set; }

    public byte? NOptLevel { get; set; }

    public int? NCount { get; set; }

    public DateTime? DEventTime { get; set; }
}
