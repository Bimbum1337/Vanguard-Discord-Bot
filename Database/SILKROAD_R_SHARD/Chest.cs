using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class Chest
{
    public int UserJid { get; set; }

    public byte Slot { get; set; }

    public long? ItemId { get; set; }

    public virtual Item? Item { get; set; }

    public virtual AccountJid UserJ { get; set; } = null!;
}
