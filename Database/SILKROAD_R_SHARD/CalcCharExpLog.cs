using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class CalcCharExpLog
{
    public int? CharId { get; set; }

    public string? CharName { get; set; }

    public byte? CurLevel { get; set; }

    public byte? MaxLevel { get; set; }

    public long? ExpOffset { get; set; }

    public long? RefExpC { get; set; }

    public long? NewLevelExpOffset { get; set; }

    public byte? NextCurLevel { get; set; }

    public byte? NextMaxLevel { get; set; }

    public DateTime? Date { get; set; }
}
