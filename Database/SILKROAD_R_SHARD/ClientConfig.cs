using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class ClientConfig
{
    public int CharId { get; set; }

    public byte ConfigType { get; set; }

    public byte SlotSeq { get; set; }

    public byte SlotType { get; set; }

    public int Data { get; set; }
}
