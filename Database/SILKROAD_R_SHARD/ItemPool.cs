using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class ItemPool
{
    public long ItemId { get; set; }

    public byte InUse { get; set; }

    public virtual Item Item { get; set; } = null!;
}
