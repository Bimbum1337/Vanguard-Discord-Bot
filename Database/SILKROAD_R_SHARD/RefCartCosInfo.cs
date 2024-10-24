using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefCartCosInfo
{
    public byte Service { get; set; }

    public int Id { get; set; }

    public string CartCosCodeName { get; set; } = null!;
}
