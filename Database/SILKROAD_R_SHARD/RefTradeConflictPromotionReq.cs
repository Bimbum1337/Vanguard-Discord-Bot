using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefTradeConflictPromotionReq
{
    public byte Service { get; set; }

    public byte PromotionPhase { get; set; }

    public byte ReqType { get; set; }

    public string Param1128 { get; set; } = null!;

    public string Param2128 { get; set; } = null!;

    public string Param3128 { get; set; } = null!;

    public string Param4128 { get; set; } = null!;

    public string Param5128 { get; set; } = null!;
}
