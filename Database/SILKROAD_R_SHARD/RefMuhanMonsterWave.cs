using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefMuhanMonsterWave
{
    public int Service { get; set; }

    public int WorldId { get; set; }

    public byte WaveCode { get; set; }

    public short RegionId { get; set; }

    public float PosX { get; set; }

    public float PosY { get; set; }

    public float PosZ { get; set; }

    public int SummonTime { get; set; }

    public byte SummonCount { get; set; }

    public int SpwanMonsterLevel { get; set; }

    public int Param1 { get; set; }

    public int Param2 { get; set; }

    public int Param3 { get; set; }

    public int Param4 { get; set; }

    public int Param5 { get; set; }
}
