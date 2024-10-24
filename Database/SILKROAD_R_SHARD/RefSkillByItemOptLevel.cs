using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefSkillByItemOptLevel
{
    public int Link { get; set; }

    public int RefSkillId { get; set; }

    public virtual RefAbilityByItemOptLevel LinkNavigation { get; set; } = null!;

    public virtual RefSkill RefSkill { get; set; } = null!;
}
