using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RankingForLevel
{
    public short Rank { get; set; }

    public string CharName { get; set; } = null!;

    public short Level { get; set; }

    public short Gender { get; set; }

    public short Country { get; set; }

    public short FirstMasteryId { get; set; }

    public short SecondMasteryId { get; set; }
}
