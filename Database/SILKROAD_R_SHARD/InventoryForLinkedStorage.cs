using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class InventoryForLinkedStorage
{
    public long LinkedItemId { get; set; }

    public byte Slot { get; set; }

    public long ItemId { get; set; }
}
