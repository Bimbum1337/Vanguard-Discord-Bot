using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_LOG;

public partial class LogSchedule
{
    public int Id { get; set; }

    public string ServerType { get; set; } = null!;

    public int ServerBodyId { get; set; }

    public string ScheduleDefine { get; set; } = null!;

    public int ScheduleIdx { get; set; }

    public string Type { get; set; } = null!;

    public DateTime OccureTime { get; set; }
}
