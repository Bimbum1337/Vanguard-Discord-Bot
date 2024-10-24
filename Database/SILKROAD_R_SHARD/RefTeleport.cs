using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefTeleport
{
    public int Service { get; set; }

    public int Id { get; set; }

    public string CodeName128 { get; set; } = null!;

    public string? AssocRefObjCodeName128 { get; set; }

    public int AssocRefObjId { get; set; }

    public string ZoneName128 { get; set; } = null!;

    public short GenRegionId { get; set; }

    public short GenPosX { get; set; }

    public short GenPosY { get; set; }

    public short GenPosZ { get; set; }

    public short GenAreaRadius { get; set; }

    public byte CanBeResurrectPos { get; set; }

    public byte CanGotoResurrectPos { get; set; }

    public short GenWorldId { get; set; }

    public byte BindInteractionMask { get; set; }

    public byte FixedService { get; set; }
}
