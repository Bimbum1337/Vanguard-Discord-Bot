using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class GmConnectionNumForNation
{
    public string Nation { get; set; } = null!;

    public short Capacity { get; set; }

    public DateTime RegDate { get; set; }
}
