using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefSiegeQuestReward
{
    public byte Service { get; set; }

    public int QuestId { get; set; }

    public byte RewardType { get; set; }

    public int RewardRefId { get; set; }

    public int RewardValue { get; set; }
}
