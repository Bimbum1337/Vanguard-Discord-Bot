using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TempJobLevelOverCharacter
{
    public int? UserJid { get; set; }

    public string? UserAccountName { get; set; }

    public int? CharId { get; set; }

    public byte? PrevJobLevel { get; set; }

    public long? PrevJobExp { get; set; }

    public DateTime? EventTime { get; set; }
}
