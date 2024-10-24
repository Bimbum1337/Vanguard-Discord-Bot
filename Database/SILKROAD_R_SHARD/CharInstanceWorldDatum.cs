using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class CharInstanceWorldDatum
{
    public int CharId { get; set; }

    public int DungeonKeyId { get; set; }

    public int WorldId { get; set; }

    public int LayerId { get; set; }

    public DateTime OpenedTime { get; set; }

    public short RegionId { get; set; }

    public int PosX { get; set; }

    public int PosY { get; set; }

    public int PosZ { get; set; }

    public byte IsActivated { get; set; }

    public int EnterCount { get; set; }

    public DateTime LastEnterTime { get; set; }
}
