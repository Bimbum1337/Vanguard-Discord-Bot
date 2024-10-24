using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class StCrmGatheringResultLog
{
    public DateTime WorkDate { get; set; }

    public string? Result { get; set; }

    public DateTime? Sdate { get; set; }

    public DateTime? Edate { get; set; }

    public int? Error { get; set; }

    public string? ErrMsg { get; set; }
}
