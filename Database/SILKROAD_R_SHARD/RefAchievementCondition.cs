using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefAchievementCondition
{
    public int Id { get; set; }

    public string CodeName { get; set; } = null!;

    public int RefAchievementId { get; set; }

    public long CompleteCount { get; set; }

    public byte Type { get; set; }

    public byte Service { get; set; }

    public virtual RefAchievement RefAchievement { get; set; } = null!;
}
