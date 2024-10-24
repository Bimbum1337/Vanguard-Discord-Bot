using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class EventRamadanVoucher
{
    public int Ranking { get; set; }

    public int CharId { get; set; }

    public string CharName16 { get; set; } = null!;

    public int Count { get; set; }

    public int Level { get; set; }

    public long Exp { get; set; }

    public int PayCount { get; set; }
}
