using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class GuildCrest
{
    public int GuildId { get; set; }

    public byte[] CrestBinary { get; set; } = null!;

    public virtual Guild Guild { get; set; } = null!;
}
