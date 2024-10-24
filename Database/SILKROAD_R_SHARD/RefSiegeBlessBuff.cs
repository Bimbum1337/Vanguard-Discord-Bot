using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefSiegeBlessBuff
{
    public byte Service { get; set; }

    public int BlessId { get; set; }

    public int FortressId { get; set; }

    public int RefBlessBuffId { get; set; }

    public long? NeedGold { get; set; }

    public int? NeedGp { get; set; }

    public virtual RefSiegeFortress Fortress { get; set; } = null!;

    public virtual RefSkill RefBlessBuff { get; set; } = null!;
}
