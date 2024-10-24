using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class GuildLogGuildPoint
{
    public int GuildId { get; set; }

    public DateTime Date { get; set; }

    public string Actor { get; set; } = null!;

    public int? GpAmount { get; set; }

    public byte Action { get; set; }

    public byte Priority { get; set; }
}
