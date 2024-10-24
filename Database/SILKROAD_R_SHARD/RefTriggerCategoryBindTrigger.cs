using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefTriggerCategoryBindTrigger
{
    public int Service { get; set; }

    public int Id { get; set; }

    public int TriggerCategoryId { get; set; }

    public int TriggerId { get; set; }

    public virtual RefTrigger Trigger { get; set; } = null!;
}
