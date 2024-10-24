using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RankingForGold
{
    public short Rank { get; set; }

    public string CharName { get; set; } = null!;

    public long Gold { get; set; }

    public short Gender { get; set; }

    public short Country { get; set; }

    public short FirstMasteryId { get; set; }

    public short SecondMasteryId { get; set; }
}
