using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class StatisticsGachaByChanneling
{
    public int NIdx { get; set; }

    public byte? ServiceCompany { get; set; }

    public string? SzCodeName128 { get; set; }

    public string? SzObjName128 { get; set; }

    public int? NCount { get; set; }

    public DateTime? DEventTime { get; set; }
}
