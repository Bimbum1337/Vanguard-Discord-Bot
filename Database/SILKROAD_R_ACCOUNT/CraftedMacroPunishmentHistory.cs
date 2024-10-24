using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class CraftedMacroPunishmentHistory
{
    public int Jid { get; set; }

    public int? Count { get; set; }

    public DateTime? LastDetected { get; set; }
}
