using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefServerEventRewardSpawnMonster
{
    public int OwnerRewardId { get; set; }

    public int RegionId { get; set; }

    public float PosX { get; set; }

    public float PosY { get; set; }

    public float PosZ { get; set; }

    public virtual RefServerEventReward OwnerReward { get; set; } = null!;
}
