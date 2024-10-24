using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class WebPackageItemMall
{
    public int PackageId { get; set; }

    public int ItemOrder { get; set; }

    public byte IsBest { get; set; }

    public int IsNew { get; set; }

    public int IsList { get; set; }

    public byte Active { get; set; }

    public DateTime RegDate { get; set; }
}
