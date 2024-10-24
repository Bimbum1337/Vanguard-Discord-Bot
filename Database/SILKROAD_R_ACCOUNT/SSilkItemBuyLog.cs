using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class SSilkItemBuyLog
{
    public string? ShardName { get; set; }

    public long? Serial64 { get; set; }

    public int? Jid { get; set; }

    public int? SilkPrice { get; set; }

    public string? CodeName { get; set; }
}
