using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefShopItemGroup
{
    public int Service { get; set; }

    public int GroupId { get; set; }

    public string CodeName128 { get; set; } = null!;

    public string StrId128Group { get; set; } = null!;
}
