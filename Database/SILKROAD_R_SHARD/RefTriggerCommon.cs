using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefTriggerCommon
{
    public int Service { get; set; }

    public int Id { get; set; }

    public string CodeName128 { get; set; } = null!;

    public string ObjName128 { get; set; } = null!;

    public short Tid1 { get; set; }

    public short Tid2 { get; set; }

    public short Tid3 { get; set; }

    public short Tid4 { get; set; }

    public virtual ICollection<RefTriggerAction> RefTriggerActions { get; set; } = new List<RefTriggerAction>();

    public virtual ICollection<RefTriggerCondition> RefTriggerConditions { get; set; } = new List<RefTriggerCondition>();

    public virtual ICollection<RefTriggerEvent> RefTriggerEvents { get; set; } = new List<RefTriggerEvent>();
}
