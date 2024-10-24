using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefEventFestivalReward
{
    public byte Service { get; set; }

    public byte RewardLevel { get; set; }

    public string ItemCodeName { get; set; } = null!;

    public byte Quantity { get; set; }

    public float Ratio { get; set; }

    public int Param1 { get; set; }

    public string Param1Desc { get; set; } = null!;

    public int Param2 { get; set; }

    public string Param2Desc { get; set; } = null!;
}
