using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TempInvalidEquipSlotItem
{
    public int CharId { get; set; }

    public string Charname16 { get; set; } = null!;

    public long ItemId { get; set; }

    public byte Slot { get; set; }

    public int RefItemId { get; set; }

    public string CodeName128 { get; set; } = null!;

    public long Serial64 { get; set; }

    public string? Shard { get; set; }
}
