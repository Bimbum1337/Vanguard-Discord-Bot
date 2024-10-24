using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefMagicOptByItemOptLevel
{
    public int Link { get; set; }

    public short RefMagicOptId { get; set; }

    public int MagicOptValue { get; set; }

    public byte TooltipType { get; set; }

    public string TooltipCodename { get; set; } = null!;

    public virtual RefAbilityByItemOptLevel LinkNavigation { get; set; } = null!;

    public virtual RefMagicOpt RefMagicOpt { get; set; } = null!;
}
