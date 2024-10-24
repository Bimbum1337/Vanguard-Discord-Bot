using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefRollBook
{
    public int Id { get; set; }

    public int Service { get; set; }

    public int EventId { get; set; }

    public int EventDay { get; set; }

    public int EventCountType { get; set; }

    public int PayType { get; set; }

    public DateTime StartDay { get; set; }

    public DateTime EndDay { get; set; }

    public string EventCode { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

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
