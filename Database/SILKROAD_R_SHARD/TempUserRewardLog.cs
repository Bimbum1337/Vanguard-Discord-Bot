using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TempUserRewardLog
{
    public int Jid { get; set; }

    public string Account { get; set; } = null!;

    public string RewardItem { get; set; } = null!;

    public int Result { get; set; }
}
