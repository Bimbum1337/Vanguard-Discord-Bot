using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefAlchemyMkResultGroup
{
    public byte Service { get; set; }

    public string GroupCodeName { get; set; } = null!;

    public string ItemCodeName { get; set; } = null!;

    public byte MakeCount { get; set; }

    public float MakeRatio { get; set; }
}
