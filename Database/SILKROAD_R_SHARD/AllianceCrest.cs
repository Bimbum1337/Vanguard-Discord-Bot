using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class AllianceCrest
{
    public int AllianceId { get; set; }

    public byte[] CrestBinary { get; set; } = null!;

    public virtual AlliedClan Alliance { get; set; } = null!;
}
