using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class CasGmchatLog
{
    public int NSerial { get; set; }

    public string SzGm { get; set; } = null!;

    public short WShardId { get; set; }

    public string SzCharName { get; set; } = null!;

    public int NCasSerial { get; set; }

    public string? SzGmchatLog { get; set; }

    public DateTime DWritten { get; set; }
}
