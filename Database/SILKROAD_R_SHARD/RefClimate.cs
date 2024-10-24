using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefClimate
{
    public int Id { get; set; }

    public byte InitialWeather { get; set; }

    public byte InitialAmount { get; set; }

    public byte ChangeWeather { get; set; }

    public byte Division { get; set; }

    public int Duration { get; set; }

    public int DurationVariance { get; set; }

    public byte Snowfall { get; set; }

    public byte SnowfallVariance { get; set; }

    public byte ProbSnow { get; set; }

    public byte Rainfall { get; set; }

    public byte RainfallVariance { get; set; }

    public byte ProbRain { get; set; }
}
