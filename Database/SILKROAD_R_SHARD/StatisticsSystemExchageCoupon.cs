using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class StatisticsSystemExchageCoupon
{
    public int? Target { get; set; }

    public int? RefItemId { get; set; }

    public long? Count { get; set; }

    public DateTime? EventTime { get; set; }
}
