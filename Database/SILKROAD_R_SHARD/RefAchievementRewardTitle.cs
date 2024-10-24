using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefAchievementRewardTitle
{
    public int RefAchievementId { get; set; }

    public int RefTitleId { get; set; }

    public virtual RefAchievement RefAchievement { get; set; } = null!;
}
