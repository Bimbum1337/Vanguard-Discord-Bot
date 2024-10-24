using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefSiegeDungeon
{
    public byte Service { get; set; }

    public int FortressId { get; set; }

    public int WorldId { get; set; }

    public byte MaxCreateCount { get; set; }

    public long EntryGold { get; set; }

    public int EntryGp { get; set; }
}
