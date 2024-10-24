using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class EventTicketParticipant
{
    public int Jid { get; set; }

    public int Event { get; set; }

    public DateTime LatestAttempt { get; set; }

    public int Count { get; set; }
}
