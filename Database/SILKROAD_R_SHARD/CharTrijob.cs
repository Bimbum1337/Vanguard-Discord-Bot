using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class CharTrijob
{
    public int CharId { get; set; }

    public byte JobType { get; set; }

    public byte Level { get; set; }

    public int Exp { get; set; }

    public int Contribution { get; set; }

    public int Reward { get; set; }

    public virtual Char Char { get; set; } = null!;
}
