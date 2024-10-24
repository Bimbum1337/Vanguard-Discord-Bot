using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class CharSkill
{
    public int CharId { get; set; }

    public int SkillId { get; set; }

    public byte Enable { get; set; }

    public virtual Char Char { get; set; } = null!;
}
