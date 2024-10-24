using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class WebItemRentInfo
{
    public int Idx { get; set; }

    public string Subject { get; set; } = null!;

    public int RentType { get; set; }

    public short CanDelete { get; set; }

    public short CanRecharge { get; set; }

    public DateTime? DateBegin { get; set; }

    public DateTime? DateEnd { get; set; }

    public int? TimeCount { get; set; }

    public DateTime RegDate { get; set; }
}
