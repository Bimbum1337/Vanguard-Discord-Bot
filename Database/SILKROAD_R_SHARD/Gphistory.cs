using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class Gphistory
{
    public int Id { get; set; }

    public int GuildId { get; set; }

    public DateTime? UsedTime { get; set; }

    public string CharName { get; set; } = null!;

    public int UsedGp { get; set; }

    public byte Reason { get; set; }
}
