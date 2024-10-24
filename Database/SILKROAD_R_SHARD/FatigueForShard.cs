using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class FatigueForShard
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int? PlayTime { get; set; }

    public int? LatestUpdateTimeToPlayTime { get; set; }
}
