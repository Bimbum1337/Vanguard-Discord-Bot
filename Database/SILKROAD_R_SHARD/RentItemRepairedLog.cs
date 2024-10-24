using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RentItemRepairedLog
{
    public DateTime EventTime { get; set; }

    public long ItemId { get; set; }

    public long Serial { get; set; }

    public short Cash { get; set; }

    public short RentType { get; set; }

    public DateTime? BeforeEndTime { get; set; }

    public DateTime? BeforeRateTime { get; set; }

    public DateTime? AfterEndTime { get; set; }

    public DateTime? AfterRateTime { get; set; }
}
