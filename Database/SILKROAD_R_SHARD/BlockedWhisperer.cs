using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class BlockedWhisperer
{
    public int OwnerId { get; set; }

    public string TargetName { get; set; } = null!;

    public virtual Char Owner { get; set; } = null!;
}
