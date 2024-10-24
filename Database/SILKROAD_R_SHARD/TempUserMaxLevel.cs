using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TempUserMaxLevel
{
    public int UserJid { get; set; }

    public byte? Maxlevel { get; set; }

    public DateTime Time { get; set; }
}
