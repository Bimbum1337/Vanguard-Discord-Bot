using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class SiegeFortressItemForge
{
    public int FortressId { get; set; }

    public int ItemRefId { get; set; }

    public short Amount { get; set; }

    public byte Finished { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime FinishDate { get; set; }

    public virtual SiegeFortress Fortress { get; set; } = null!;
}
