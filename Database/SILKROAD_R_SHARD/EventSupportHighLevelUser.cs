using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class EventSupportHighLevelUser
{
    public int UserJid { get; set; }

    public int CharId { get; set; }

    public string CharName { get; set; } = null!;

    public DateTime EventTime { get; set; }
}
