using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefShopTabGroup
{
    public byte Service { get; set; }

    public int Country { get; set; }

    public int Id { get; set; }

    public string CodeName128 { get; set; } = null!;

    public string StrId128Group { get; set; } = null!;

    public virtual RefShopObject CountryNavigation { get; set; } = null!;
}
