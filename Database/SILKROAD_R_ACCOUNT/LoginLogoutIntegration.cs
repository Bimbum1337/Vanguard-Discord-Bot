using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class LoginLogoutIntegration
{
    public int NIdx { get; set; }

    public int NJid { get; set; }

    public int NIp { get; set; }

    public DateTime DLogin { get; set; }

    public DateTime DLogout { get; set; }

    public byte ByReserved { get; set; }
}
