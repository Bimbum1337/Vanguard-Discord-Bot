using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_LOG;

public partial class LogEventSiegeFortress
{
    public int Id { get; set; }

    public int FortressId { get; set; }

    public DateTime EventTime { get; set; }

    public byte EventId { get; set; }

    public int CharId { get; set; }

    public int Data1 { get; set; }

    public int Data2 { get; set; }

    public string? StrDesc { get; set; }
}
