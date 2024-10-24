using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefMagicOptGroup
{
    public byte Service { get; set; }

    public int LinkId { get; set; }

    public byte MagicType { get; set; }

    public string CodeName128 { get; set; } = null!;

    public int MoptId { get; set; }

    public byte MoptLevel { get; set; }

    public int Value { get; set; }

    public int Param1 { get; set; }

    public string Param1Desc { get; set; } = null!;

    public int Param2 { get; set; }

    public string Param2Desc { get; set; } = null!;
}
