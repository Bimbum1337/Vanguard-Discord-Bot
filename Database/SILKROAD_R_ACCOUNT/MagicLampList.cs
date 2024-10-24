using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class MagicLampList
{
    public int Idx { get; set; }

    public int LampNum { get; set; }

    public int? RoundNo { get; set; }

    public int RemainAmount { get; set; }

    public int Winners { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? LampStatus { get; set; }
}
