using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefAchievementConditionItem
{
    public int RefAchievementConditionId { get; set; }

    public int? RefItemId { get; set; }

    public byte? TypeId1 { get; set; }

    public byte? TypeId2 { get; set; }

    public byte? TypeId3 { get; set; }

    public byte? TypeId4 { get; set; }

    public virtual RefAchievementCondition RefAchievementCondition { get; set; } = null!;
}
