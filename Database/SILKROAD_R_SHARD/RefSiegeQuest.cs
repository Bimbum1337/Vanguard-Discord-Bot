using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefSiegeQuest
{
    public byte Service { get; set; }

    public int QuestId { get; set; }

    public string QuestName { get; set; } = null!;

    public byte QuestType { get; set; }

    public byte RewardConditionTargetCount { get; set; }

    public byte IsAccumulation { get; set; }
}
