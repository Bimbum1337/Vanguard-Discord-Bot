using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefEventRewardItem
{
    public byte Service { get; set; }

    public int EventId { get; set; }

    public string EventCodeName { get; set; } = null!;

    public string ItemCodeName { get; set; } = null!;

    public int PayCount { get; set; }

    public float AchieveRatio { get; set; }

    public string RentItemCodeName { get; set; } = null!;

    public byte IsRecharging { get; set; }

    public byte IsPackageItem { get; set; }

    public byte MinLevel { get; set; }

    public byte MaxLevel { get; set; }

    public int Param1 { get; set; }

    public string Param1Desc { get; set; } = null!;

    public int Param2 { get; set; }

    public string Param2Desc { get; set; } = null!;
}
