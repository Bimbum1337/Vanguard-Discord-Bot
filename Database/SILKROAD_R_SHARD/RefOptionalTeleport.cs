using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefOptionalTeleport
{
    public int Service { get; set; }

    public int Id { get; set; }

    public string ObjName128 { get; set; } = null!;

    public string ZoneName128 { get; set; } = null!;

    public short RegionId { get; set; }

    public short PosX { get; set; }

    public short PosY { get; set; }

    public short PosZ { get; set; }

    public short WorldId { get; set; }

    public int RegionIdgroup { get; set; }

    public byte MapPoint { get; set; }

    public short LevelMin { get; set; }

    public short LevelMax { get; set; }

    public int? Param1 { get; set; }

    public string? Param1Desc128 { get; set; }

    public int? Param2 { get; set; }

    public string? Param2Desc128 { get; set; }

    public int? Param3 { get; set; }

    public string? Param3Desc128 { get; set; }

    public int DivisionLevel { get; set; }
}
