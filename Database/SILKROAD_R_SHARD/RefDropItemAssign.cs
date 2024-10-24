using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefDropItemAssign
{
    public int Service { get; set; }

    public int RefItemId { get; set; }

    public int ProbRelative { get; set; }

    public int ProbAbsolute { get; set; }

    public int AssignedGroup { get; set; }

    public int DropCount { get; set; }
}
