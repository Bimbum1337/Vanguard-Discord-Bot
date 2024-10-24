using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class CharTradeConflictJob
{
    public int CharId { get; set; }

    public DateTime NickNameRegDate { get; set; }

    public byte JobLevel { get; set; }

    public long JobExp { get; set; }

    public byte PromotionPhase { get; set; }

    public long ReputationPoint { get; set; }

    public int KillCount { get; set; }

    public byte Class { get; set; }

    public byte Rank { get; set; }
}
