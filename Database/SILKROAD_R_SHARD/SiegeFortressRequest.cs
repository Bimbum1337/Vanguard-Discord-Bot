using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class SiegeFortressRequest
{
    public int FortressId { get; set; }

    public int GuildId { get; set; }

    public byte RequestType { get; set; }

    public virtual SiegeFortress Fortress { get; set; } = null!;

    public virtual Guild Guild { get; set; } = null!;
}
