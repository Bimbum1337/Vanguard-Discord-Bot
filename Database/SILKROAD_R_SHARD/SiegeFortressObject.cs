using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class SiegeFortressObject
{
    public int Id { get; set; }

    public int FortressId { get; set; }

    public int OwnerGuildId { get; set; }

    public int RefObjId { get; set; }

    public int Hp { get; set; }

    public short Region { get; set; }

    public float PosX { get; set; }

    public float PosY { get; set; }

    public float PosZ { get; set; }

    public float Direction { get; set; }

    public byte OwnerLevel { get; set; }

    public virtual SiegeFortress Fortress { get; set; } = null!;
}
