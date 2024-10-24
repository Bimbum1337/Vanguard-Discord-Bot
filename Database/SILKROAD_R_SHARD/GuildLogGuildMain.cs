using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class GuildLogGuildMain
{
    public int GuildId { get; set; }

    public DateTime Date { get; set; }

    public string Actor { get; set; } = null!;

    public byte Action { get; set; }

    public byte Priority { get; set; }
}
