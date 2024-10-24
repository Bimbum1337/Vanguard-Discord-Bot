using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class ChestInfo
{
    public int Jid { get; set; }

    public byte ChestSize { get; set; }

    public virtual AccountJid JidNavigation { get; set; } = null!;
}
