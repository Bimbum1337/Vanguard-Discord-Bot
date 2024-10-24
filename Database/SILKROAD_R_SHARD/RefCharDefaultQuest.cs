using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefCharDefaultQuest
{
    public byte Service { get; set; }

    public int Id { get; set; }

    public byte Race { get; set; }

    public string CodeName { get; set; } = null!;

    public byte RequiredLevel { get; set; }
}
