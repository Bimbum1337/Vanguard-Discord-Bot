using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TradeEquipInventory
{
    public int CharId { get; set; }

    public byte Slot { get; set; }

    public long ItemId { get; set; }

    public virtual Char Char { get; set; } = null!;

    public virtual Item Item { get; set; } = null!;
}
