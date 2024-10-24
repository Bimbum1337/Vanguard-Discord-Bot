using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefDropItemGroup
{
    public byte Service { get; set; }

    public int RefItemGroupId { get; set; }

    public string CodeName128 { get; set; } = null!;

    public int RefItemId { get; set; }

    public float SelectRatio { get; set; }

    public int RefMagicGroupId { get; set; }

    public virtual RefObjCommon RefItem { get; set; } = null!;
}
