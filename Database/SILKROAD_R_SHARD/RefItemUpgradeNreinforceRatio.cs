using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefItemUpgradeNreinforceRatio
{
    public byte RatioType { get; set; }

    public string RatioTypeDesc { get; set; } = null!;

    public byte RatioSubType { get; set; }

    public string RatioSubTypeDesc { get; set; } = null!;

    public int Ratio { get; set; }
}
