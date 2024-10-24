using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefAbilityByItemOptLevel
{
    public byte Service { get; set; }

    public int Id { get; set; }

    public int RefItemId { get; set; }

    public byte ItemOptLevel { get; set; }

    public virtual RefObjCommon RefItem { get; set; } = null!;
}
