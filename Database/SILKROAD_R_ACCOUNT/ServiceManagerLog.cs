using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class ServiceManagerLog
{
    public int NUserId { get; set; }

    public DateTime EventTime { get; set; }

    public string SzLog { get; set; } = null!;
}
