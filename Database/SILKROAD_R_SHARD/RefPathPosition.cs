using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefPathPosition
{
    public int Id { get; set; }

    public int PathId { get; set; }

    public int Sequence { get; set; }

    public string Codename { get; set; } = null!;

    public short RegionId { get; set; }

    public float PosX { get; set; }

    public float PosY { get; set; }

    public float PosZ { get; set; }

    public int ConfigGroupId { get; set; }

    public virtual RefPathPositionConfigGroup ConfigGroup { get; set; } = null!;

    public virtual RefPath Path { get; set; } = null!;
}
