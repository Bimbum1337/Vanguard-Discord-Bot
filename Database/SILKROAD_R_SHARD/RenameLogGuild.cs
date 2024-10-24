using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RenameLogGuild
{
    public string OldName { get; set; } = null!;

    public string NewName { get; set; } = null!;

    public DateTime RenameTime { get; set; }
}
