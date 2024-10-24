using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefRegionEnterCheckLevel
{
    public string ContinentName { get; set; } = null!;

    public string AreaName { get; set; } = null!;

    public short MinLevel { get; set; }

    public short MaxLevel { get; set; }
}
