using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TargetInventoryItem
{
    public long Id64 { get; set; }

    public byte Type { get; set; }

    public int OwnerId { get; set; }

    public string? OwnerName { get; set; }

    public long Slot { get; set; }
}
