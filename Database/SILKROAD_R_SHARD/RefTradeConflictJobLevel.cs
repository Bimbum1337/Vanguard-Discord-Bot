using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefTradeConflictJobLevel
{
    public byte Service { get; set; }

    public byte JobLevel { get; set; }

    public long JobExp { get; set; }

    public byte PromotionReq { get; set; }
}
