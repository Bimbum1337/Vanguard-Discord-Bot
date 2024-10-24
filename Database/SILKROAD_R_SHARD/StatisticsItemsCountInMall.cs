using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class StatisticsItemsCountInMall
{
    public int NIdx { get; set; }

    public string? SzCodename128 { get; set; }

    public int? NCount { get; set; }

    public DateTime? DEventTime { get; set; }
}
