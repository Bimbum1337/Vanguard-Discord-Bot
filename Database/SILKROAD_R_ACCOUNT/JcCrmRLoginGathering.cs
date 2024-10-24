using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class JcCrmRLoginGathering
{
    public int PortalJid { get; set; }

    public int Cpjid { get; set; }

    public string UserIp { get; set; } = null!;

    public DateTime RegDate { get; set; }
}
