using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class GoldTrace1
{
    public long Idx { get; set; }

    public long? SumCharGold { get; set; }

    public long? SumChestGold { get; set; }

    public long? SumGuildChestGold { get; set; }

    public long? SumGuildWarGold { get; set; }

    public long? SumGuildBootyGold { get; set; }

    public DateTime? DEventTime { get; set; }
}
