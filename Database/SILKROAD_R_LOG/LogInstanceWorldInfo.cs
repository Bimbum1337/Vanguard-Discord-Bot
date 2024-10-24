using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_LOG;

public partial class LogInstanceWorldInfo
{
    public int WorldId { get; set; }

    public DateTime EventTime { get; set; }

    public short? GameWorldLayerId { get; set; }

    public int CharId { get; set; }

    public string ValueCodeName128 { get; set; } = null!;

    public string? Value { get; set; }
}
