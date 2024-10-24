using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefEvent
{
    public byte Service { get; set; }

    public int Id { get; set; }

    public string CodeName { get; set; } = null!;

    public string DescName { get; set; } = null!;

    public string? ScheduleName { get; set; }

    public int ScheduleCount { get; set; }
}
