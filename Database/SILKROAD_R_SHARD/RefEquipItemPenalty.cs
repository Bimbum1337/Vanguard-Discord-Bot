using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefEquipItemPenalty
{
    public byte Service { get; set; }

    public byte PenaltyEquipType { get; set; }

    public byte PenaltyLevel { get; set; }

    public byte ItemClass { get; set; }

    public byte PenaltyClass { get; set; }

    public short MultipleValue { get; set; }
}
