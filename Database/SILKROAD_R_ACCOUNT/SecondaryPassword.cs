using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class SecondaryPassword
{
    public int UserJid { get; set; }

    public string SecondPassword { get; set; } = null!;

    public DateTime? BlockedStartTime { get; set; }

    public byte? ErrorCount { get; set; }
}
