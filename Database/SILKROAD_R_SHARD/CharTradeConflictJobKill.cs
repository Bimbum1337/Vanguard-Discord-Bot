using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class CharTradeConflictJobKill
{
    public int CharId { get; set; }

    public int KilledCharId { get; set; }

    public DateTime EventTime { get; set; }
}
