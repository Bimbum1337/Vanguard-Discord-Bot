using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class FlagWorldCoinRewardLog
{
    public int Jid { get; set; }

    public int CharId { get; set; }

    public int Coins { get; set; }

    public DateTime LogTime { get; set; }
}
