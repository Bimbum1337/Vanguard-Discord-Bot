using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class PreoccupancyName
{
    public string Name { get; set; } = null!;

    public byte NameType { get; set; }

    public int OwnerId { get; set; }

    public DateTime ReqTime { get; set; }
}
