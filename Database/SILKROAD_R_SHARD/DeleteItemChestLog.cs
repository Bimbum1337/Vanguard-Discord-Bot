using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class DeleteItemChestLog
{
    public int? Jid { get; set; }

    public int? CharId { get; set; }

    public string? CharName { get; set; }

    public byte? Slot { get; set; }

    public int? RefItemId { get; set; }

    public string? ItemCodeName { get; set; }

    public DateTime? Date { get; set; }

    public string? Log { get; set; }
}
