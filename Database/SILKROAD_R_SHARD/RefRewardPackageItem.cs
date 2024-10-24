using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefRewardPackageItem
{
    public byte Service { get; set; }

    public int QuestId { get; set; }

    public int PackageRefItemId { get; set; }

    public int RefItemId { get; set; }
}
