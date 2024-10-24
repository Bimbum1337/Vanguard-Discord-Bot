using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class SurvivalPvprecordPartyMatching
{
    public short SeasonIndex { get; set; }

    public byte MatchingType { get; set; }

    public int CharId { get; set; }

    public short ShardId { get; set; }

    public short WinCount { get; set; }

    public short DrawCount { get; set; }

    public short LoseCount { get; set; }
}
