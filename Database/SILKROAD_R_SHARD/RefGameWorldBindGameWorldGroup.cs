using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefGameWorldBindGameWorldGroup
{
    public int Service { get; set; }

    public int Id { get; set; }

    public int GameWorldId { get; set; }

    public int GameWorldGroupId { get; set; }

    public virtual RefGameWorld GameWorld { get; set; } = null!;

    public virtual RefGameWorldGroup GameWorldGroup { get; set; } = null!;
}
