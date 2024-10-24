using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefTradeConflictClass
{
    public byte Service { get; set; }

    public byte ClassId { get; set; }

    public string Description128 { get; set; } = null!;

    public long ReputationPointForRankUp { get; set; }

    public string PassiveSkill1 { get; set; } = null!;

    public string PassiveSkill2 { get; set; } = null!;

    public string PassiveSkill3 { get; set; } = null!;

    public string PassiveSkill4 { get; set; } = null!;

    public string PassiveSkill5 { get; set; } = null!;
}
