using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefSetItemGroup
{
    public byte Service { get; set; }

    public int Id { get; set; }

    public string CodeName128 { get; set; } = null!;

    public string ObjName128 { get; set; } = null!;

    public string NameStrId128 { get; set; } = null!;

    public string DescStrId128 { get; set; } = null!;

    public byte SetEffectMask { get; set; }

    public int SetMagicMask { get; set; }

    public int _2setMoptGroupId { get; set; }

    public int _3setMoptGroupId { get; set; }

    public int _4setMoptGroupId { get; set; }

    public int _5setMoptGroupId { get; set; }

    public int _6setMoptGroupId { get; set; }

    public int _7setMoptGroupId { get; set; }

    public int _8setMoptGroupId { get; set; }

    public int _9setMoptGroupId { get; set; }

    public int _10setMoptGroupId { get; set; }

    public int _11setMoptGroupId { get; set; }
}
