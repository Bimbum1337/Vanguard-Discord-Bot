using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TabRefNest
{
    public int DwNestId { get; set; }

    public int DwHiveId { get; set; }

    public int DwTacticsId { get; set; }

    public short NRegionDbid { get; set; }

    public float? FLocalPosX { get; set; }

    public float? FLocalPosY { get; set; }

    public float? FLocalPosZ { get; set; }

    public short? WInitialDir { get; set; }

    public int? NRadius { get; set; }

    public int? NGenerateRadius { get; set; }

    public int? NChampionGenPercentage { get; set; }

    public int? DwDelayTimeMin { get; set; }

    public int? DwDelayTimeMax { get; set; }

    public int DwMaxTotalCount { get; set; }

    public byte? BtFlag { get; set; }

    public byte BtRespawn { get; set; }

    public byte BtType { get; set; }
}
