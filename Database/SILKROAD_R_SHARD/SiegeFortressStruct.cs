using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class SiegeFortressStruct
{
    public int FortressId { get; set; }

    public int OwnerGuildId { get; set; }

    public int RefEventStructId { get; set; }

    public int RefObjId { get; set; }

    public int Hp { get; set; }

    public DateTime MakeDate { get; set; }

    public short State { get; set; }

    public virtual SiegeFortress Fortress { get; set; } = null!;
}
