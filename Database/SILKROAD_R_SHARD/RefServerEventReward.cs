using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefServerEventReward
{
    public byte Service { get; set; }

    public int RewardId { get; set; }

    public int OwnerServerEventId { get; set; }

    public int RefRewardId { get; set; }

    public byte Quantity { get; set; }

    public byte RewardClass { get; set; }

    public byte MasterReward { get; set; }

    public virtual RefServerEvent OwnerServerEvent { get; set; } = null!;
}
