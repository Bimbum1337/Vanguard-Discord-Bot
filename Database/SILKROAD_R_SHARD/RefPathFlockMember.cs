using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefPathFlockMember
{
    public int Id { get; set; }

    public int FlockId { get; set; }

    public int TacticsId { get; set; }

    public byte MemberType { get; set; }

    public float OffsetX { get; set; }

    public float OffsetY { get; set; }

    public float OffsetZ { get; set; }

    public int RespawnDelayMin { get; set; }

    public int RespawnDelayMax { get; set; }

    public virtual RefPathFlock Flock { get; set; } = null!;
}
