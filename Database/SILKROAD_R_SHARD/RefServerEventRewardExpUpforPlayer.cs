using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefServerEventRewardExpUpforPlayer
{
    public int OwnerRewardId { get; set; }

    public int ApplyTime { get; set; }

    public byte ApplyExpRatio { get; set; }

    public byte ApplySexpRatio { get; set; }

    public byte ApplyPdamageRatio { get; set; }

    public byte ApplyMdamageRatio { get; set; }

    public short ApplySpeedRatio { get; set; }

    public virtual RefServerEventReward OwnerReward { get; set; } = null!;
}
