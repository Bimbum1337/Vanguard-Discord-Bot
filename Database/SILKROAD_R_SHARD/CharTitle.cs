using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class CharTitle
{
    public int CharId { get; set; }

    public int TitleId { get; set; }

    public DateTime? LimitTime { get; set; }

    public byte Enable { get; set; }
}
