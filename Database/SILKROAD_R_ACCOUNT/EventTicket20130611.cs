using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class EventTicket20130611
{
    public int? Jid { get; set; }

    public byte? Level { get; set; }

    public string? AccountId { get; set; }

    public int? Count { get; set; }

    public string? CharName { get; set; }

    public string? ShardName { get; set; }

    public long? Exp { get; set; }

    public DateTime? LastLogout { get; set; }
}
