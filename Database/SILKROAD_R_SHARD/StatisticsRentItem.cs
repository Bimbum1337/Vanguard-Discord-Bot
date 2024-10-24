using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class StatisticsRentItem
{
    public int NIdx { get; set; }

    public byte? NRentType { get; set; }

    public string? SzCodename128 { get; set; }

    public int? NCount { get; set; }

    public DateTime? DEventTime { get; set; }
}
