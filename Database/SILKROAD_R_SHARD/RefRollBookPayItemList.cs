using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefRollBookPayItemList
{
    public int Id { get; set; }

    public int EventId { get; set; }

    public string Itemcode { get; set; } = null!;

    public int ItemPayCount { get; set; }

    public int Param1 { get; set; }

    public string Param1Desc { get; set; } = null!;

    public int Param2 { get; set; }

    public string Param2Desc { get; set; } = null!;

    public int Param3 { get; set; }

    public string Param3Desc { get; set; } = null!;

    public int Param4 { get; set; }

    public string Param4Desc { get; set; } = null!;

    public int Param5 { get; set; }

    public string Param5Desc { get; set; } = null!;
}
