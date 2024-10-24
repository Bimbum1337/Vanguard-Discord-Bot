using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefAchievement
{
    public int Id { get; set; }

    public string CodeName { get; set; } = null!;

    public byte UnlockLevel { get; set; }

    public byte Category { get; set; }

    public short FirstComeFirstServedCount { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public byte ViewMode { get; set; }

    public byte Service { get; set; }

    public virtual ICollection<RefAchievementCondition> RefAchievementConditions { get; set; } = new List<RefAchievementCondition>();

    public virtual RefAchievementRewardTitle? RefAchievementRewardTitle { get; set; }
}
