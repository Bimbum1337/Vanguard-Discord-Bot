using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefAlchemyCorrection
{
    public byte Service { get; set; }

    public short RefMagicOptId { get; set; }

    public string AlchemyCorrectionTagetCodeName128 { get; set; } = null!;

    public int CorrectionValue { get; set; }

    public virtual RefMagicOpt RefMagicOpt { get; set; } = null!;
}
