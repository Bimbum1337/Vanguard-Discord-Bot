using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefNewTradeRewardRatio
{
    public byte Service { get; set; }

    public string DepartureName { get; set; } = null!;

    public string ArrivalName { get; set; } = null!;

    public float RewardRatio { get; set; }
}
