using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefTriggerEvent
{
    public int Service { get; set; }

    public int Id { get; set; }

    public int RefTriggerCommonId { get; set; }

    public virtual ICollection<RefTriggerBindEvent> RefTriggerBindEvents { get; set; } = new List<RefTriggerBindEvent>();

    public virtual RefTriggerCommon RefTriggerCommon { get; set; } = null!;
}
