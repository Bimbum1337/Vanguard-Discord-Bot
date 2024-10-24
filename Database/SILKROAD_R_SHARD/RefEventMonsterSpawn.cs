using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefEventMonsterSpawn
{
    public byte Service { get; set; }

    public string MonsterCodeName { get; set; } = null!;

    public short RegionId { get; set; }

    public float PosX { get; set; }

    public float PosY { get; set; }

    public float PosZ { get; set; }
}
