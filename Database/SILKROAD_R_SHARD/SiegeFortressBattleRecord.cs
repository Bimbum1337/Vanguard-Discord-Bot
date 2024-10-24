using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class SiegeFortressBattleRecord
{
    public int FortressId { get; set; }

    public int CharId { get; set; }

    public int KillCount { get; set; }

    public int KilledCount { get; set; }

    public DateTime RankUpDate { get; set; }

    public byte CurRank { get; set; }

    public virtual SiegeFortress Fortress { get; set; } = null!;
}
