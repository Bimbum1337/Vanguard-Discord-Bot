using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefEquipItemPenaltyBalance
{
    public byte Service { get; set; }

    public byte TypeId2 { get; set; }

    public byte TypeId3 { get; set; }

    public byte TypeId4 { get; set; }

    public byte PenaltyClass { get; set; }

    public float PenaltyPhyMin { get; set; }

    public float PenaltyPhyMax { get; set; }

    public float PenaltyMgcMin { get; set; }

    public float PenaltyMgcMax { get; set; }
}
