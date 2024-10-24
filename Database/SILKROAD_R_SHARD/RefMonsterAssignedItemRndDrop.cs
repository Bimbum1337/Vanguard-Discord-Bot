using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefMonsterAssignedItemRndDrop
{
    public byte Service { get; set; }

    public int RefMonsterId { get; set; }

    public int RefItemGroupId { get; set; }

    public string ItemGroupCodeName128 { get; set; } = null!;

    public byte Overlap { get; set; }

    public byte DropAmountMin { get; set; }

    public byte DropAmountMax { get; set; }

    public float DropRatio { get; set; }

    public int Param1 { get; set; }

    public int Param2 { get; set; }

    public virtual RefObjCommon RefMonster { get; set; } = null!;
}
