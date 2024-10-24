using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_LOG;

public partial class LogChatMessage
{
    public string? ShardName { get; set; }

    public string? CharName16 { get; set; }

    public string? ChatType { get; set; }

    public string? Region { get; set; }

    public string? Value { get; set; }

    public DateTime? EventTime { get; set; }
}
