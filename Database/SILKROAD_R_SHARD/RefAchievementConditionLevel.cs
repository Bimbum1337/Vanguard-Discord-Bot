using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefAchievementConditionLevel
{
    public int RefAchievementConditionId { get; set; }

    public byte Level { get; set; }

    public virtual RefAchievementCondition RefAchievementCondition { get; set; } = null!;
}
