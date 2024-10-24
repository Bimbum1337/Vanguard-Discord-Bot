using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefTriggerAction
{
    public int Service { get; set; }

    public int Id { get; set; }

    public int RefTriggerCommonId { get; set; }

    public int Delay { get; set; }

    public string ParamGroupCodeName128 { get; set; } = null!;

    public virtual ICollection<RefTriggerBindAction> RefTriggerBindActions { get; set; } = new List<RefTriggerBindAction>();

    public virtual RefTriggerCommon RefTriggerCommon { get; set; } = null!;
}
