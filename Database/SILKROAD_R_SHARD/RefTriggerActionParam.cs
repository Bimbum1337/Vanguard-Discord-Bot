using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefTriggerActionParam
{
    public int Service { get; set; }

    public int Id { get; set; }

    public string GroupCodeName128 { get; set; } = null!;

    public string ValueCodeName128 { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string Type { get; set; } = null!;
}
