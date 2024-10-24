using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class AchievementCondition
{
    public int Id { get; set; }

    public int CharId { get; set; }

    public int AchievementId { get; set; }

    public int RefAchievementConditionId { get; set; }

    public long ProgressCount { get; set; }

    public virtual Achievement Achievement { get; set; } = null!;

    public virtual Char Char { get; set; } = null!;
}
