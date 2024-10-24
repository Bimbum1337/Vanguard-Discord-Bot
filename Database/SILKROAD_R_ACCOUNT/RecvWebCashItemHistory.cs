using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class RecvWebCashItemHistory
{
    public int Jid { get; set; }

    public int ShardId { get; set; }

    public string NameCodePackage { get; set; } = null!;

    public int CharacterId { get; set; }

    public int Section { get; set; }

    public DateTime RecieveDate { get; set; }
}
