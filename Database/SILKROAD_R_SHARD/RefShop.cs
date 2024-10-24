using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefShop
{
    public byte Service { get; set; }

    public int Country { get; set; }

    public int Id { get; set; }

    public string CodeName128 { get; set; } = null!;

    public int Param1 { get; set; }

    public string Param1Desc128 { get; set; } = null!;

    public int Param2 { get; set; }

    public string Param2Desc128 { get; set; } = null!;

    public int Param3 { get; set; }

    public string Param3Desc128 { get; set; } = null!;

    public int Param4 { get; set; }

    public string Param4Desc128 { get; set; } = null!;

    public virtual RefShopObject CountryNavigation { get; set; } = null!;
}
