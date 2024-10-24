using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class SupAdmin
{
    public int NId { get; set; }

    public string AId { get; set; } = null!;

    public string APassWord { get; set; } = null!;

    public string? AName { get; set; }

    public string? WriteDiv { get; set; }

    public string? GmNickName { get; set; }

    public string? AExplain { get; set; }

    public byte AGrade { get; set; }

    public DateTime? SignDate { get; set; }

    public DateTime? VisitDate { get; set; }

    public string? Ip { get; set; }

    public int? Visited { get; set; }
}
