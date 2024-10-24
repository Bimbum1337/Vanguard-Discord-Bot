using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefNewTradeRewardItem
{
    public byte Service { get; set; }

    public string ObjCodeName { get; set; } = null!;

    public float RewardRatio { get; set; }

    public byte JobType { get; set; }
}
