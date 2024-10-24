using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class GuildLogGuildChest
{
    public int GuildId { get; set; }

    public DateTime Date { get; set; }

    public string Actor { get; set; } = null!;

    public int ItemId { get; set; }

    public long ItemAmount { get; set; }

    public byte Action { get; set; }

    public byte Priority { get; set; }
}
