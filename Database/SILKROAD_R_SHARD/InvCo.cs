using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class InvCo
{
    public int Cosid { get; set; }

    public byte Slot { get; set; }

    public long? ItemId { get; set; }

    public virtual CharCo Cos { get; set; } = null!;

    public virtual Item? Item { get; set; }
}
