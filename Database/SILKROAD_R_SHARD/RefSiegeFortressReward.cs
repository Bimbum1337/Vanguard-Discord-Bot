using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefSiegeFortressReward
{
    public byte Service { get; set; }

    public int FortressId { get; set; }

    public byte RewardTypeId { get; set; }

    public int RewardValue { get; set; }

    public byte RewardCount { get; set; }

    public virtual RefSiegeFortress Fortress { get; set; } = null!;
}
