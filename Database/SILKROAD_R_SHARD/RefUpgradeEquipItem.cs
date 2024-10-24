using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefUpgradeEquipItem
{
    public byte Service { get; set; }

    public int BeforeRefId { get; set; }

    public byte BeforeOptLevel { get; set; }

    public int UpgradeRefId { get; set; }

    public byte UpgradeOptLevel { get; set; }
}
