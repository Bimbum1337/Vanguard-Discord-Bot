using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefCollectionBookTheme
{
    public byte Service { get; set; }

    public int Id { get; set; }

    public string CodeName128 { get; set; } = null!;

    public string ObjName128 { get; set; } = null!;

    public string Name128 { get; set; } = null!;

    public string Desc128 { get; set; } = null!;

    public int CompleteNum { get; set; }
}
