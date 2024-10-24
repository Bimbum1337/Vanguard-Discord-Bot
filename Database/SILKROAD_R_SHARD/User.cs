using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class User
{
    public int UserJid { get; set; }

    public int CharId { get; set; }

    public virtual Char Char { get; set; } = null!;

    public virtual AccountJid UserJ { get; set; } = null!;
}
