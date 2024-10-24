using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class WebItemPopular
{
    public int? Idx { get; set; }

    public int PackageId { get; set; }

    public string PackageName { get; set; } = null!;
}
