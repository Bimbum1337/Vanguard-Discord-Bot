using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class LogResultRewardSilk
{
    public DateTime RewardDate { get; set; }

    public int Jid { get; set; }

    public byte ErrorCode { get; set; }

    public int RewardSilk { get; set; }
}
