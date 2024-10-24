using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefSiegeFortress
{
    public byte Service { get; set; }

    public int FortressId { get; set; }

    public string CodeName128 { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string NameId128 { get; set; } = null!;

    public string LinkedTeleportCodeName { get; set; } = null!;

    public byte Scale { get; set; }

    public short MaxAdmission { get; set; }

    public byte MaxGuard { get; set; }

    public byte MaxBarricade { get; set; }

    public short TaxTargets { get; set; }

    public int RequestFee { get; set; }

    public string CrestPath128 { get; set; } = null!;

    public string RequestNpcname128 { get; set; } = null!;

    public virtual ICollection<RefSiegeBlessBuff> RefSiegeBlessBuffs { get; set; } = new List<RefSiegeBlessBuff>();
}
