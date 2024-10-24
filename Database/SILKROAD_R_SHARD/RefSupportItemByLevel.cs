using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefSupportItemByLevel
{
    public byte Level { get; set; }

    public string ItemCodeName { get; set; } = null!;

    public byte ItemCount { get; set; }
}
