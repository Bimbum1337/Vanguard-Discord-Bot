using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RollBookUserEventDatum
{
    public int UserJid { get; set; }

    public int EventId { get; set; }

    public int TotalPayCount { get; set; }

    public int NowPayCount { get; set; }
}
