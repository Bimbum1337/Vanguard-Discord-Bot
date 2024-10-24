using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class Notice
{
    public int Service { get; set; }

    public int Id { get; set; }

    public string? CodeName128 { get; set; }

    public string? Desc128 { get; set; }

    public int IntervalTime { get; set; }
}
