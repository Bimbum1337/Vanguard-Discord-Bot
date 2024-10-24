using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class LogEventLevelRigid
{
    public int Jid { get; set; }

    public int PortalJid { get; set; }

    public int CharId { get; set; }

    public string CharName { get; set; } = null!;

    public short Top { get; set; }
}
