using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TabRefHive
{
    public int DwHiveId { get; set; }

    public byte? BtKeepMonsterCountType { get; set; }

    public int? DwOverwriteMaxTotalCount { get; set; }

    public float? FMonsterCountPerPc { get; set; }

    public int? DwSpawnSpeedIncreaseRate { get; set; }

    public int? DwMaxIncreaseRate { get; set; }

    public byte? BtFlag { get; set; }

    public short? GameWorldId { get; set; }

    public short? HatchObjType { get; set; }

    public string? SzDescString128 { get; set; }
}
