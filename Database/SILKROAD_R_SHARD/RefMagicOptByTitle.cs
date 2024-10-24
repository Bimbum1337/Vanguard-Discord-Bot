using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefMagicOptByTitle
{
    public int TitleId { get; set; }

    public short MagicOptId { get; set; }

    public int MagicOptValue { get; set; }

    public virtual RefTitle Title { get; set; } = null!;
}
