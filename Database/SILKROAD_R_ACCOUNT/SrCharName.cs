using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class SrCharName
{
    public int UserJid { get; set; }

    public short ShardId { get; set; }

    public string CharId1 { get; set; } = null!;

    public string? CharId2 { get; set; }

    public string? CharId3 { get; set; }
}
