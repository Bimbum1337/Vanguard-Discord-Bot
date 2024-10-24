using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class WebMallCategorySub
{
    public int RefNo { get; set; }

    public int SubNo { get; set; }

    public string? SubNameUs { get; set; }

    public string? SubNameTr { get; set; }

    public string? SubNameEg { get; set; }

    public string? SubNameEs { get; set; }

    public string? SubNameDe { get; set; }

    public int SubOrder { get; set; }
}
