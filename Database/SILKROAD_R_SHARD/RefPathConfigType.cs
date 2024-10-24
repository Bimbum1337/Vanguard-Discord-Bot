using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefPathConfigType
{
    public string ConfigCodename { get; set; } = null!;

    public string Type { get; set; } = null!;

    public virtual ICollection<RefPathPositionConfig> RefPathPositionConfigs { get; set; } = new List<RefPathPositionConfig>();
}
