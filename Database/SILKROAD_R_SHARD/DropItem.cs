using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class DropItem
{
    public int UserId { get; set; }

    public int TargetStorage { get; set; }

    public int Slot { get; set; }

    public int ItemId { get; set; }
}
