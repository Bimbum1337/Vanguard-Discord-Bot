using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class WebItemGiveListDetail
{
    public long Idx { get; set; }

    public long RefIdx { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public int ItemQuantity { get; set; }

    public int? RefRent { get; set; }
}
