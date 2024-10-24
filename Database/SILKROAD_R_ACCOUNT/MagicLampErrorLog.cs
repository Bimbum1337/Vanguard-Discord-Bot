using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class MagicLampErrorLog
{
    public int Idx { get; set; }

    public int? Userjid { get; set; }

    public int? LampNum { get; set; }

    public int? ListNum { get; set; }

    public byte? ItemWin { get; set; }

    public int? ErrorNum { get; set; }

    public string? Ip { get; set; }

    public DateTime? RegDate { get; set; }
}
