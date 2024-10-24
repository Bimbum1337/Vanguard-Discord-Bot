using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class FleaMarketNetwork
{
    public byte AbleOpen { get; set; }

    public int CharId { get; set; }

    public byte Slot { get; set; }

    public int TidGroupId { get; set; }

    public byte ItemClass { get; set; }

    public int ItemCount { get; set; }

    public byte MakeZone { get; set; }

    public long Cash { get; set; }

    public virtual Char Char { get; set; } = null!;
}
