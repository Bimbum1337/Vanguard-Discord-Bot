using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class EntryTicketWinnerList
{
    public int Id { get; set; }

    public int EventId { get; set; }

    public int Jid { get; set; }

    public string CharName { get; set; } = null!;

    public int Level { get; set; }

    public string ItemCodeName { get; set; } = null!;

    public int PayCount { get; set; }
}
