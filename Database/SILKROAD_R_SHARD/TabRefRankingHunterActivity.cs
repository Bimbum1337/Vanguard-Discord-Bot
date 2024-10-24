using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TabRefRankingHunterActivity
{
    public byte Rank { get; set; }

    public string? NickName { get; set; }

    public byte JobLevel { get; set; }

    public long? JobExp { get; set; }

    public short Country { get; set; }
}
