using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class Shard
{
    public short NId { get; set; }

    public byte NFarmId { get; set; }

    public byte NContentId { get; set; }

    public string SzName { get; set; } = null!;

    public string SzDesc { get; set; } = null!;

    public string SzDbconfig { get; set; } = null!;

    public short NMaxUser { get; set; }

    public short NStartupServerId { get; set; }

    public byte NStatus { get; set; }

    public byte NCurrentUserRatio { get; set; }
}
