using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class SkEmailCertifyKey
{
    public int UserJid { get; set; }

    public int CertifyKey { get; set; }

    public DateTime RegDate { get; set; }
}
