using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefAchievementConditionMonster
{
    public int RefAchievementConditionId { get; set; }

    public int? RefMonsterId { get; set; }

    public byte? Rarity { get; set; }

    public virtual RefAchievementCondition RefAchievementCondition { get; set; } = null!;
}
