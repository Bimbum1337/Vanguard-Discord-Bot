using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefTriggerVariable
{
    public int Service { get; set; }

    public int Id { get; set; }

    public int BindTriggerId { get; set; }

    public string CodeName128 { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int Value { get; set; }

    public string? Comment128 { get; set; }

    public virtual RefTrigger BindTrigger { get; set; } = null!;
}
