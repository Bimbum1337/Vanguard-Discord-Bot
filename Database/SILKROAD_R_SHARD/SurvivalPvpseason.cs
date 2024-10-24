using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class SurvivalPvpseason
{
    public short SeasonIndex { get; set; }

    public byte SurvivalType { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public byte End { get; set; }
}
