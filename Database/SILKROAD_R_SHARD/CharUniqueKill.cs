using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class CharUniqueKill
{
    public int CharId { get; set; }

    public int MobId { get; set; }

    public DateTime EventDate { get; set; }
}
