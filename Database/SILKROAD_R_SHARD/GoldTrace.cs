using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class GoldTrace
{
    public int Idx { get; set; }

    public long? SumCharGold { get; set; }

    public long? SumChestGold { get; set; }

    public long? SumGuildChestGold { get; set; }

    public long? OffsetCharGold { get; set; }

    public long? OffsetChestGold { get; set; }

    public long? OffsetGuildChestGold { get; set; }

    public DateTime? DEventTime { get; set; }

    public long? SumGuildWarGold { get; set; }

    public long? SumGuildBootyGold { get; set; }

    public long? OffsetGuildWarGold { get; set; }

    public long? OffSetGuildBootyGold { get; set; }
}
