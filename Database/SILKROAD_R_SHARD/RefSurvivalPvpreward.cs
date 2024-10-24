using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefSurvivalPvpreward
{
    public byte SurvivalType { get; set; }

    public string? SurvivalTypeDesc { get; set; }

    public byte MatchingType { get; set; }

    public string? MatchingTypeDesc { get; set; }

    public byte OutCome { get; set; }

    public string? OutComeDesc { get; set; }

    public int RefItemId { get; set; }

    public byte ItemCount { get; set; }
}
