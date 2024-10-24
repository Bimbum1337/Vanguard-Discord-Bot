using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefTeleLink
{
    public int Service { get; set; }

    public int OwnerTeleport { get; set; }

    public int TargetTeleport { get; set; }

    public int Fee { get; set; }

    public byte RestrictBindMethod { get; set; }

    public byte RunTimeTeleportMethod { get; set; }

    public byte CheckResult { get; set; }

    public int Restrict1 { get; set; }

    public int? Data11 { get; set; }

    public int? Data12 { get; set; }

    public int Restrict2 { get; set; }

    public int? Data21 { get; set; }

    public int? Data22 { get; set; }

    public int Restrict3 { get; set; }

    public int? Data31 { get; set; }

    public int? Data32 { get; set; }

    public int Restrict4 { get; set; }

    public int? Data41 { get; set; }

    public int? Data42 { get; set; }

    public int Restrict5 { get; set; }

    public int? Data51 { get; set; }

    public int? Data52 { get; set; }

    public int DivisionLevel { get; set; }
}
