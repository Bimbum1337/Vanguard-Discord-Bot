using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefRegion
{
    public short WRegionId { get; set; }

    public byte X { get; set; }

    public byte Z { get; set; }

    public string ContinentName { get; set; } = null!;

    public string AreaName { get; set; } = null!;

    public byte IsBattleField { get; set; }

    public int Climate { get; set; }

    public int MaxCapacity { get; set; }

    public int AssocObjId { get; set; }

    public int AssocServer { get; set; }

    public string AssocFile256 { get; set; } = null!;

    public int? LinkedRegion1 { get; set; }

    public int? LinkedRegion2 { get; set; }

    public int? LinkedRegion3 { get; set; }

    public int? LinkedRegion4 { get; set; }

    public int? LinkedRegion5 { get; set; }

    public int? LinkedRegion6 { get; set; }

    public int? LinkedRegion7 { get; set; }

    public int? LinkedRegion8 { get; set; }

    public int? LinkedRegion9 { get; set; }

    public int? LinkedRegion10 { get; set; }
}
