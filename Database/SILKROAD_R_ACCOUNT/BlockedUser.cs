using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class BlockedUser
{
    public int UserJid { get; set; }

    public string UserId { get; set; } = null!;

    public byte Type { get; set; }

    public int SerialNo { get; set; }

    public DateTime TimeBegin { get; set; }

    public DateTime TimeEnd { get; set; }
}
