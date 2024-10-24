using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefEventZone
{
    public int Service { get; set; }

    public int Id { get; set; }

    public string ZoneName { get; set; } = null!;

    public string EventName { get; set; } = null!;

    public int? Param1 { get; set; }

    public int? Param2 { get; set; }

    public int? Param3 { get; set; }

    public int? Param4 { get; set; }

    public int? Param5 { get; set; }

    public string? StrParam1 { get; set; }

    public string? StrParam2 { get; set; }

    public string? StrParam3 { get; set; }

    public string? StrParam4 { get; set; }

    public string? StrParam5 { get; set; }
}
