using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefTrigger
{
    public int Service { get; set; }

    public int Id { get; set; }

    public string CodeName128 { get; set; } = null!;

    public byte IsActive { get; set; }

    public byte IsRepeat { get; set; }

    public string? Comment512 { get; set; }

    public int IndexNumber { get; set; }

    public virtual ICollection<RefTriggerBindAction> RefTriggerBindActions { get; set; } = new List<RefTriggerBindAction>();

    public virtual ICollection<RefTriggerBindCondition> RefTriggerBindConditions { get; set; } = new List<RefTriggerBindCondition>();

    public virtual ICollection<RefTriggerBindEvent> RefTriggerBindEvents { get; set; } = new List<RefTriggerBindEvent>();

    public virtual ICollection<RefTriggerCategoryBindTrigger> RefTriggerCategoryBindTriggers { get; set; } = new List<RefTriggerCategoryBindTrigger>();

    public virtual ICollection<RefTriggerVariable> RefTriggerVariables { get; set; } = new List<RefTriggerVariable>();
}
