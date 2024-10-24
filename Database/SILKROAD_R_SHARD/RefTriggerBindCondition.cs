using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefTriggerBindCondition
{
    public int Service { get; set; }

    public int Id { get; set; }

    public int TriggerId { get; set; }

    public int TriggerConditionId { get; set; }

    public virtual RefTrigger Trigger { get; set; } = null!;

    public virtual RefTriggerCondition TriggerCondition { get; set; } = null!;
}
