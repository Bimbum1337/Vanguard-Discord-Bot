using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class AlliedClan
{
    public int Id { get; set; }

    public int? Ally1 { get; set; }

    public int? Ally2 { get; set; }

    public int? Ally3 { get; set; }

    public int? Ally4 { get; set; }

    public DateTime FoundationDate { get; set; }

    public int LastCrestRev { get; set; }

    public int CurCrestRev { get; set; }

    public virtual AllianceCrest? AllianceCrest { get; set; }

    public virtual ICollection<Guild> Guilds { get; set; } = new List<Guild>();
}
