using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TabRefAiskill
{
    public int TacticsId { get; set; }

    public string SkillCodeName { get; set; } = null!;

    public byte ExcuteConditionType { get; set; }

    public byte ConditionMin { get; set; }

    public byte ConditionMax { get; set; }

    public int Option { get; set; }

    public int ExcuteConditionData { get; set; }
}
