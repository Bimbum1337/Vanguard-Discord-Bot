using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TraceItem
{
    public long? ItemId { get; set; }

    public byte? OptLevel { get; set; }

    public string? CodeName128 { get; set; }

    public long? Serial64 { get; set; }

    public DateTime? ReportedDate { get; set; }
}
