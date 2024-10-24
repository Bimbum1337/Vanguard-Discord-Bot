using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class JcCrmRServerGathering5
{
    public int PortalJid { get; set; }

    public int Cpjid { get; set; }

    public int ServiceCompany { get; set; }

    public string Wname { get; set; } = null!;

    public string Cname { get; set; } = null!;

    public string UserIp { get; set; } = null!;

    public DateTime RegDate { get; set; }

    public int LogUid { get; set; }
}
