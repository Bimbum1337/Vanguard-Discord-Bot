using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class ActiveUserRigid
{
    public int Jid { get; set; }

    public int LastLoginCharId { get; set; }

    public DateTime? LastLoginTime { get; set; }

    public DateTime? LastLogoutTime { get; set; }

    public byte Online { get; set; }
}
