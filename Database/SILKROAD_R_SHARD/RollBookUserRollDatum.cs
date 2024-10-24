using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RollBookUserRollDatum
{
    public int UserJid { get; set; }

    public int Year { get; set; }

    public byte[]? RollData { get; set; }
}
