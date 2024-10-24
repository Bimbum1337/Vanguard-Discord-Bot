using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_LOG;

public partial class LogEventBot
{
    public int UserJid { get; set; }

    public int CharId { get; set; }

    public int EventId { get; set; }

    public string? StrDesc { get; set; }

    public DateTime EventTime { get; set; }
}
