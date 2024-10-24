using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RankingForChar
{
    public short Rank { get; set; }

    public string CharName { get; set; } = null!;

    public long ItemPoints { get; set; }

    public short CharLevel { get; set; }

    public short JobLevel { get; set; }

    public byte JobPhase { get; set; }

    public short JobRank { get; set; }

    public int JobKills { get; set; }

    public long Gold { get; set; }

    public long Sp { get; set; }

    public int CharId { get; set; }

    public int RefObjId { get; set; }

    public int GuildId { get; set; }
}
