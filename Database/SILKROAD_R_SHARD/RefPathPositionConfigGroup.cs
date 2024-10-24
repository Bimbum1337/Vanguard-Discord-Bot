using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefPathPositionConfigGroup
{
    public int Id { get; set; }

    public string GroupCodename { get; set; } = null!;

    public virtual ICollection<RefPathPositionConfig> RefPathPositionConfigs { get; set; } = new List<RefPathPositionConfig>();

    public virtual ICollection<RefPathPosition> RefPathPositions { get; set; } = new List<RefPathPosition>();
}
