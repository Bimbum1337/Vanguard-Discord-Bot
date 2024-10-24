using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_LOG;

public partial class AddLogInstanceWorldInfo
{
    public int WorldId { get; set; }

    public int RefTriggerCommonId { get; set; }

    public int Idk1 { get; set; }

    public string? Idk2 { get; set; }

    public string? WorldCodeName128 { get; set; }
}
