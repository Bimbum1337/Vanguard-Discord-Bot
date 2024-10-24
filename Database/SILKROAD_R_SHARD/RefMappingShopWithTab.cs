using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefMappingShopWithTab
{
    public byte Service { get; set; }

    public int Country { get; set; }

    public string RefShopCodeName { get; set; } = null!;

    public string RefTabGroupCodeName { get; set; } = null!;

    public virtual RefShopObject CountryNavigation { get; set; } = null!;
}
