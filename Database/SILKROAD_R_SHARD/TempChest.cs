using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TempChest
{
    public int UserJid { get; set; }

    public short ShardId { get; set; }

    public byte Slot { get; set; }

    public long ItemId { get; set; }
}
