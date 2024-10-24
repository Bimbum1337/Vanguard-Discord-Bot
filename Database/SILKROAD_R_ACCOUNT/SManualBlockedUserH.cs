using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class SManualBlockedUserH
{
    public int Id { get; set; }

    public short Num { get; set; }

    public int Jid { get; set; }

    public string StrUserId { get; set; } = null!;

    public DateTime BlockedDate { get; set; }
}
