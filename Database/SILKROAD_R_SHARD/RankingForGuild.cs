using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RankingForGuild
{
    public short Rank { get; set; }

    public string GuildName { get; set; } = null!;

    public int Gp { get; set; }

    public string GuildMasterName { get; set; } = null!;

    public short Level { get; set; }
}
