using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class UserTradeConflictJob
{
    public int UserJid { get; set; }

    public DateTime RegDate { get; set; }

    public byte JobType { get; set; }
}
