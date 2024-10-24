using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class CharTrijobSafeTrade
{
    public int CharId { get; set; }

    public int AbleCount { get; set; }

    public int Status { get; set; }

    public DateTime LastSafeTrade { get; set; }

    public virtual CharTrijob Char { get; set; } = null!;
}
