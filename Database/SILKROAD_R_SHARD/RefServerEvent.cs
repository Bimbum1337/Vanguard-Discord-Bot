using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefServerEvent
{
    public byte Service { get; set; }

    public int Id { get; set; }

    public byte DetectingTargetType { get; set; }

    public int DetectingTargetId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime BeginDate { get; set; }

    public DateTime EndDate { get; set; }

    public byte NotificationTypeDetectingTarget { get; set; }

    public byte AchievementConditionType { get; set; }

    public short AchievementConditionLevel { get; set; }

    public int AchievementCondition { get; set; }

    public byte RewardTarget { get; set; }

    public int GiveRewardDelayTime { get; set; }

    public byte ActivateClientUi { get; set; }

    public virtual ICollection<RefServerEventReward> RefServerEventRewards { get; set; } = new List<RefServerEventReward>();
}
