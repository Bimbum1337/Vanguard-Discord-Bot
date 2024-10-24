using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefClassUpgradeEquipItem
{
    public byte Service { get; set; }

    public int RefId { get; set; }

    public int UpgradeRefId { get; set; }

    public byte MinOptLevel { get; set; }
}
