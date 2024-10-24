using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefTriggerCondition
{
    public int Service { get; set; }

    public int Id { get; set; }

    public int RefTriggerCommonId { get; set; }

    public string OnTrue { get; set; } = null!;

    public string OnFalse { get; set; } = null!;

    public short Sequence { get; set; }

    public string ParamGroupCodeName128 { get; set; } = null!;

    public virtual ICollection<RefTriggerBindCondition> RefTriggerBindConditions { get; set; } = new List<RefTriggerBindCondition>();

    public virtual RefTriggerCommon RefTriggerCommon { get; set; } = null!;
}
