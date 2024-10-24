using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class ActiveUser5
{
    public int ShardId { get; set; }

    public int UserJid { get; set; }

    public string Ip { get; set; } = null!;

    public string? CountryCode { get; set; }

    public DateTime LoginTime { get; set; }
}
