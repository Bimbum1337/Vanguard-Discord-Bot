using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class WebItemCertifykey
{
    public int Idx { get; set; }

    public int UserJid { get; set; }

    public string Certifykey { get; set; } = null!;

    public int ShardId { get; set; }

    public DateTime RegDate { get; set; }

    public int? CharLevel { get; set; }
}
