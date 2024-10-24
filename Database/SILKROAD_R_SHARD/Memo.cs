using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class Memo
{
    public long Id64 { get; set; }

    public int CharId { get; set; }

    public string FromCharName { get; set; } = null!;

    public string? Message { get; set; }

    public DateTime Date { get; set; }

    public byte Status { get; set; }

    public int? RefObjId { get; set; }

    public virtual Char Char { get; set; } = null!;
}
