using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class Achievement
{
    public int Id { get; set; }

    public int CharId { get; set; }

    public int RefAchievementId { get; set; }

    public byte State { get; set; }

    public virtual ICollection<AchievementCondition> AchievementConditions { get; set; } = new List<AchievementCondition>();

    public virtual Char Char { get; set; } = null!;
}
