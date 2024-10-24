using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class BindingOptionWithItem
{
    public long NItemDbid { get; set; }

    public byte BOptType { get; set; }

    public byte NSlot { get; set; }

    public int NOptId { get; set; }

    public byte NOptLvl { get; set; }

    public int NOptValue { get; set; }

    public int? NParam1 { get; set; }

    public int? NParam2 { get; set; }
}
