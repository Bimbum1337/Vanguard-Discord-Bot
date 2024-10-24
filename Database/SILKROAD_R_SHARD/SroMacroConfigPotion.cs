using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class SroMacroConfigPotion
{
    public int CharId { get; set; }

    public byte? Service { get; set; }

    public short? Version { get; set; }

    public byte? AutoSummonCos { get; set; }

    public short? BinarySize { get; set; }

    public byte[]? Binary { get; set; }
}
