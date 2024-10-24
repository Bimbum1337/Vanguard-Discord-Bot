﻿using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class GuildWar
{
    public int Id { get; set; }

    public byte WarType { get; set; }

    public byte VictoryPointIndex { get; set; }

    public int LodgedGold { get; set; }

    public DateTime? WarEndTime { get; set; }

    public int Guild1 { get; set; }

    public int Guild2 { get; set; }

    public int PointGain1 { get; set; }

    public int PointGain2 { get; set; }

    public int Data1 { get; set; }

    public int Data2 { get; set; }
}
