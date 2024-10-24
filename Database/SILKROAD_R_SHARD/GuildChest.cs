using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class GuildChest
{
    public int GuildId { get; set; }

    public byte Slot { get; set; }

    public long? ItemId { get; set; }

    public virtual Guild Guild { get; set; } = null!;
}
