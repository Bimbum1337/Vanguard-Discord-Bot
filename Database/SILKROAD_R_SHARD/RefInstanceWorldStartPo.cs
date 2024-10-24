using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefInstanceWorldStartPo
{
    public int WorldId { get; set; }

    public short RegionId { get; set; }

    public int PosX { get; set; }

    public int PosY { get; set; }

    public int PosZ { get; set; }

    public int? Param { get; set; }
}
