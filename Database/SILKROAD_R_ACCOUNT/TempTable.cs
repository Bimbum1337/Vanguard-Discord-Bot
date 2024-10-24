using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class TempTable
{
    public int Jid { get; set; }

    public int PortalJid { get; set; }

    public string StrUserId { get; set; } = null!;

    public int ServiceCompany { get; set; }

    public string Password { get; set; } = null!;

    public int Active { get; set; }

    public string UserIp { get; set; } = null!;

    public string CountryCode { get; set; } = null!;

    public DateTime VisitDate { get; set; }

    public DateTime RegDate { get; set; }

    public byte SecPrimary { get; set; }

    public byte SecContent { get; set; }

    public byte SecGrade { get; set; }

    public int? AccPlayTime { get; set; }

    public int? LatestUpdateTimeToPlayTime { get; set; }
}
