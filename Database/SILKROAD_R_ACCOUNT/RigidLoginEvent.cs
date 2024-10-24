using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class RigidLoginEvent
{
    public int Jid { get; set; }

    public DateTime? LoginTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public int? RewardedCount { get; set; }

    public int PlayTime { get; set; }
}
