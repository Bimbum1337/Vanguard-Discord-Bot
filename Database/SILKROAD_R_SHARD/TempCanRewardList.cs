using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TempCanRewardList
{
    public int? UserJid { get; set; }

    public int? RefItemId { get; set; }

    public byte? IsReward { get; set; }
}
