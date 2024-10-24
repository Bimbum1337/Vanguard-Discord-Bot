using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class EventHiSilkRoadPrizeList
{
    public int Jid { get; set; }

    public int Status { get; set; }

    public DateTime UpdateTime { get; set; }

    public DateTime LastLogOut { get; set; }
}
