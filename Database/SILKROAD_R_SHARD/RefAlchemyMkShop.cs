using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefAlchemyMkShop
{
    public byte Service { get; set; }

    public string ShopCodeName { get; set; } = null!;

    public int RcId { get; set; }

    public long Cost { get; set; }

    public int Param1 { get; set; }

    public string Param1Desc128 { get; set; } = null!;

    public int Param2 { get; set; }

    public string Param2Desc128 { get; set; } = null!;

    public int Param3 { get; set; }

    public string Param3Desc128 { get; set; } = null!;

    public int Param4 { get; set; }

    public string Param4Desc128 { get; set; } = null!;

    public int Param5 { get; set; }

    public string Param5Desc128 { get; set; } = null!;

    public virtual RefAlchemyMkRecipe Rc { get; set; } = null!;
}
