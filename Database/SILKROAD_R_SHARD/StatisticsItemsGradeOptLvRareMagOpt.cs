using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class StatisticsItemsGradeOptLvRareMagOpt
{
    public int NIdx { get; set; }

    public short NMagOptId { get; set; }

    public byte? NGrade { get; set; }

    public byte? NOptLevel { get; set; }

    public int? NAppliedCount { get; set; }

    public int? NNotAppliedCount { get; set; }

    public DateTime? DEventTime { get; set; }
}
