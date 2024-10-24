using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class TrijobRankingStatus
{
    public int ShardId { get; set; }

    public byte Status { get; set; }

    public DateTime UpdateTime { get; set; }
}
