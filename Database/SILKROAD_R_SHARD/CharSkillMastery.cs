using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class CharSkillMastery
{
    public int CharId { get; set; }

    public int MasteryId { get; set; }

    public byte Level { get; set; }

    public virtual Char Char { get; set; } = null!;
}
