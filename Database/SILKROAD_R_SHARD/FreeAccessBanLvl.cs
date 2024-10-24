using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class FreeAccessBanLvl
{
    public int Jid { get; set; }

    public int BanLvl { get; set; }

    public DateTime EndTime { get; set; }
}
