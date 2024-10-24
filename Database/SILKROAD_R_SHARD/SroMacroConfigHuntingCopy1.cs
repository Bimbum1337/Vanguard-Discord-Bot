using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class SroMacroConfigHuntingCopy1
{
    public int CharId { get; set; }

    public byte? Service { get; set; }

    public short? Version { get; set; }

    public byte? MannerMode { get; set; }

    public short? BinarySize { get; set; }

    public byte[]? Binary { get; set; }

    public short? StartHuntingWorldId { get; set; }

    public short? StartHuntingRegionId { get; set; }

    public float? StartHuntingPosX { get; set; }

    public float? StartHuntingPosY { get; set; }

    public float? StartHuntingPosZ { get; set; }
}
