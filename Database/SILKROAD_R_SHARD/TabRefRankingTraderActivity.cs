using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TabRefRankingTraderActivity
{
    public byte Rank { get; set; }

    public string NickName { get; set; } = null!;

    public byte JobLevel { get; set; }

    public int JobExp { get; set; }

    public short Country { get; set; }
}
