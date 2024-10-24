using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_LOG;

public partial class StatisticsGoldIncrementDatum
{
    public DateTime BeginDate { get; set; }

    public DateTime? EndDate { get; set; }

    public long? Paid { get; set; }

    public long? Income { get; set; }

    public long? HunterProfit { get; set; }
}
