﻿using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class FlagWorldEventParticipant
{
    public int Jid { get; set; }

    public DateTime LatestAttempt { get; set; }

    public int Count { get; set; }
}
