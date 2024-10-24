using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefScheduleDefine
{
    public int ScheduleDefineIdx { get; set; }

    public string ScheduleName { get; set; } = null!;

    public string? Description { get; set; }
}
