using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class LogEventGoldNew
{
    public DateTime EventTime { get; set; }

    public string? Etype { get; set; }

    public int? UserJid { get; set; }

    public int? CharId { get; set; }

    public string? CharName16 { get; set; }

    public long BeforeRemainGold { get; set; }

    public long AfterRemainGold { get; set; }

    public int? EtcId { get; set; }
}
