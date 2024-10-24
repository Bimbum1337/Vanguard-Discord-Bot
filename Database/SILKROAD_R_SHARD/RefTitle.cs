using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefTitle
{
    public int TitleId { get; set; }

    public string CodeName { get; set; } = null!;

    public byte Category { get; set; }

    public string TitleString { get; set; } = null!;

    public byte TimeOption { get; set; }

    public int LimitTime { get; set; }

    public DateTime? StartDay { get; set; }

    public DateTime? EndDay { get; set; }
}
