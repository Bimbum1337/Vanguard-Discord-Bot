using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class ServerEvent
{
    public int Id { get; set; }

    public int CompletionValue { get; set; }

    public int AchievementCondition { get; set; }

    public int ProgressCount { get; set; }
}
