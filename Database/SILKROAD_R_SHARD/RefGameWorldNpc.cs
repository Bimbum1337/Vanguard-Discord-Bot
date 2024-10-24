using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefGameWorldNpc
{
    public int Id { get; set; }

    public string WorldCodeName128 { get; set; } = null!;

    public string NpccodeName128 { get; set; } = null!;

    public short RegionId { get; set; }

    public short PosX { get; set; }

    public short PosY { get; set; }

    public short PosZ { get; set; }

    public int? Param1 { get; set; }

    public int? Param2 { get; set; }

    public int? Param3 { get; set; }

    public int? Param4 { get; set; }

    public int? Param5 { get; set; }

    public int? Param6 { get; set; }

    public int? Param7 { get; set; }

    public int? Param8 { get; set; }

    public int? Param9 { get; set; }

    public int? Param10 { get; set; }
}
