using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class EquipErrorCo
{
    public int RefItemId { get; set; }

    public long Id64 { get; set; }

    public int NewCosid { get; set; }

    public byte Slot { get; set; }
}
