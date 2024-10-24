using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class CharTeleport
{
    public int CharId { get; set; }

    public byte Index { get; set; }

    public int WorldId { get; set; }

    public short RegionId { get; set; }

    public float PosX { get; set; }

    public float PosY { get; set; }

    public float PosZ { get; set; }
}
