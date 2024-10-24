using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class StatisticsAbnormalChar
{
    public int NIdx { get; set; }

    public string? SzCharname16 { get; set; }

    public byte? NCurLevel { get; set; }

    public byte? NMaxLevel { get; set; }

    public short? NStrength { get; set; }

    public short? NIntellect { get; set; }

    public short? NRemainStat { get; set; }

    public int? NDifference { get; set; }

    public DateTime? DEventTime { get; set; }
}
