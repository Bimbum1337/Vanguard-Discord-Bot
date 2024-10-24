using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefMonsterAssignedItemDrop
{
    public int RefMonsterId { get; set; }

    public int RefItemId { get; set; }

    public byte DropGroupType { get; set; }

    public byte OptLevel { get; set; }

    public byte DropAmountMin { get; set; }

    public byte DropAmountMax { get; set; }

    public float DropRatio { get; set; }

    public short? RefMagicOptionId1 { get; set; }

    public int? CustomValue1 { get; set; }

    public short? RefMagicOptionId2 { get; set; }

    public int? CustomValue2 { get; set; }

    public short? RefMagicOptionId3 { get; set; }

    public int? CustomValue3 { get; set; }

    public short? RefMagicOptionId4 { get; set; }

    public int? CustomValue4 { get; set; }

    public short? RefMagicOptionId5 { get; set; }

    public int? CustomValue5 { get; set; }

    public short? RefMagicOptionId6 { get; set; }

    public int? CustomValue6 { get; set; }

    public short? RefMagicOptionId7 { get; set; }

    public int? CustomValue7 { get; set; }

    public short? RefMagicOptionId8 { get; set; }

    public int? CustomValue8 { get; set; }

    public short? RefMagicOptionId9 { get; set; }

    public int? CustomValue9 { get; set; }

    public string RentCodeName { get; set; } = null!;

    public virtual RefObjCommon RefItem { get; set; } = null!;

    public virtual RefObjCommon RefMonster { get; set; } = null!;
}
