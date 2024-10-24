using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class WebPackageItemDetail
{
    public int Idx { get; set; }

    public int PackageId { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? ItemNameEng { get; set; }

    public int ItemQuantity { get; set; }

    public int? RefRent { get; set; }
}
