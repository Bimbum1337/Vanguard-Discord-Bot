using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TempGuild
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public byte Lvl { get; set; }

    public int GatheredSp { get; set; }

    public DateTime FoundationDate { get; set; }

    public int? Alliance { get; set; }

    public string? MasterCommentTitle { get; set; }

    public string? MasterComment { get; set; }

    public int? Booty { get; set; }

    public long Gold { get; set; }

    public int LastCrestRev { get; set; }

    public int CurCrestRev { get; set; }

    public byte MercenaryAttr { get; set; }
}
