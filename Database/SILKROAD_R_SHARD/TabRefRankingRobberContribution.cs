using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TabRefRankingRobberContribution
{
    public byte Rank { get; set; }

    public string NickName { get; set; } = null!;

    public byte JobLevel { get; set; }

    public int Contribution { get; set; }
}
