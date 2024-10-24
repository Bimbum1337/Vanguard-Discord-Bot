using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefSurvivalPvPoption
{
    public int Service { get; set; }

    public int Id { get; set; }

    public string CodeName { get; set; } = null!;

    public string? CodeDesc { get; set; }

    public string Value { get; set; } = null!;

    public string Type { get; set; } = null!;
}
