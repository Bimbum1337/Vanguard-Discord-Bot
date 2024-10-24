using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class SiegeFortressStoneState
{
    public int FortressId { get; set; }

    public int GuildId { get; set; }

    public int AccumulateDamage { get; set; }

    public virtual SiegeFortress Fortress { get; set; } = null!;
}
