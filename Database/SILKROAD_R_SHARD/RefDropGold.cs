using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefDropGold
{
    public byte MonLevel { get; set; }

    public float DropProb { get; set; }

    public int GoldMin { get; set; }

    public int GoldMax { get; set; }
}
