using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class ContentConfigCopy1
{
    public int Service { get; set; }

    public int Id { get; set; }

    public string CodeName128 { get; set; } = null!;

    public string CodeDesc128 { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string? Type { get; set; }
}
