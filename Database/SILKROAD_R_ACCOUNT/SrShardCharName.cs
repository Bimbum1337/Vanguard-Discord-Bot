using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class SrShardCharName
{
    public int UserJid { get; set; }

    public int ShardId { get; set; }

    public string CharName { get; set; } = null!;
}
