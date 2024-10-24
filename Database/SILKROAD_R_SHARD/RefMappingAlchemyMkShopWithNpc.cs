using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefMappingAlchemyMkShopWithNpc
{
    public byte Service { get; set; }

    public string NpcCodeName { get; set; } = null!;

    public string ShopCodeName { get; set; } = null!;
}
