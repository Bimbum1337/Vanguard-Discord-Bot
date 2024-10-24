using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class ShardCurrentUser
{
    public int NId { get; set; }

    public int NShardId { get; set; }

    public int NUserCount { get; set; }

    public DateTime DLogDate { get; set; }
}
