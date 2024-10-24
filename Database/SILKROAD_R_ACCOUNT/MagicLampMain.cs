using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class MagicLampMain
{
    public int Idx { get; set; }

    public string LampNameUs { get; set; } = null!;

    public string LampNameDe { get; set; } = null!;

    public string LampNameTr { get; set; } = null!;

    public string LampNameEs { get; set; } = null!;

    public string LampNameEg { get; set; } = null!;

    public int LampQty { get; set; }

    public int WinQty { get; set; }

    public int Price { get; set; }

    public int UseStatus { get; set; }
}
