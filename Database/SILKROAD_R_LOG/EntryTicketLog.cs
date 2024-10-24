using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_LOG;

public partial class EntryTicketLog
{
    public int LogType { get; set; }

    public int TicketType { get; set; }

    public int EventId { get; set; }

    public int Jid { get; set; }

    public string CharName { get; set; } = null!;

    public string ItemCodeName { get; set; } = null!;

    public string Desc { get; set; } = null!;

    public DateTime EntryDate { get; set; }
}
