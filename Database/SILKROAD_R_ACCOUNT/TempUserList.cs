using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class TempUserList
{
    public int Seq { get; set; }

    public string? AccountId { get; set; }

    public int? UserJid { get; set; }

    public DateTime? MaxLastLogout { get; set; }
}
