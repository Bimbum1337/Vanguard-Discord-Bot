using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefGachaItemSet
{
    public byte Service { get; set; }

    public int SetId { get; set; }

    public int RefItemId { get; set; }

    public short Ratio { get; set; }

    public short Count { get; set; }

    public int GachaId { get; set; }

    public byte Visible { get; set; }

    public int Param1 { get; set; }

    public string Param1Desc128 { get; set; } = null!;

    public int Param2 { get; set; }

    public string Param2Desc128 { get; set; } = null!;

    public int Param3 { get; set; }

    public string Param3Desc128 { get; set; } = null!;

    public int Param4 { get; set; }

    public string Param4Desc128 { get; set; } = null!;

    public int DivisionLevel { get; set; }

    public short DivisionLevel90Ratio { get; set; }

    public short DivisionLevel100Ratio { get; set; }

    public short DivisionLevel110Ratio { get; set; }

    public short DivisionLevel120Ratio { get; set; }
}
