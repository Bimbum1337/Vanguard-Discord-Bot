using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class LogEventGold
{
    public DateTime EventTime { get; set; }

    public int CharId { get; set; }

    public string CharName16 { get; set; } = null!;

    public long BeforeRemainGold { get; set; }

    public long AfterRemainGold { get; set; }
}
