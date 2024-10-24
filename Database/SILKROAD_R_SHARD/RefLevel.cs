using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefLevel
{
    public byte Lvl { get; set; }

    public long ExpC { get; set; }

    public int ExpM { get; set; }

    public int CostM { get; set; }

    public int CostSt { get; set; }

    public int GustMobExp { get; set; }

    public int? JobExpTrader { get; set; }

    public int? JobExpRobber { get; set; }

    public int? JobExpHunter { get; set; }

    public long ExpP { get; set; }

    public int MaxSp { get; set; }
}
