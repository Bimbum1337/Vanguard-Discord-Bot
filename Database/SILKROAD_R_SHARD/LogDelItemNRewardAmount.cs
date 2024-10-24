using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class LogDelItemNRewardAmount
{
    public DateTime RewardDate { get; set; }

    public string StorageType { get; set; } = null!;

    public int OwnerId { get; set; }

    public string ItemCodeName { get; set; } = null!;

    public long Id64 { get; set; }

    public byte RewardType { get; set; }

    public int Cnt { get; set; }

    public int RewardAmount { get; set; }

    public int TotalRewardAmount { get; set; }

    public string IsReward { get; set; } = null!;

    public string? StrDesc { get; set; }
}
