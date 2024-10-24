using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class WebActionLog
{
    public int Idx { get; set; }

    public int Location { get; set; }

    public int CpJid { get; set; }

    public DateTime RegDate { get; set; }

    public string RegIp { get; set; } = null!;

    public string? Param1 { get; set; }

    public string? Param2 { get; set; }

    public string? Param3 { get; set; }

    public string? Param4 { get; set; }

    public string? Param5 { get; set; }

    public string? Param6 { get; set; }

    public string? Param7 { get; set; }

    public string? Param8 { get; set; }

    public string? Param9 { get; set; }

    public string? Param10 { get; set; }
}
