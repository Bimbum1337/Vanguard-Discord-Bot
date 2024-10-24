using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class LastestOpenMarketPesnalId
{
    public int Jid { get; set; }

    public long LatestPersnalId { get; set; }

    public virtual AccountJid JidNavigation { get; set; } = null!;
}
