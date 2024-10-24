using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class MemoBlock
{
    public int OwnerId { get; set; }

    public string TargetCharName { get; set; } = null!;

    public virtual Char Owner { get; set; } = null!;
}
