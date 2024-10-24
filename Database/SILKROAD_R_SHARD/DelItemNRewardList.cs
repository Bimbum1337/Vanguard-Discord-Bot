using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class DelItemNRewardList
{
    public string CodeName128 { get; set; } = null!;

    public int RefItemId { get; set; }

    public byte RewardType { get; set; }

    public int RewardAmount { get; set; }
}
