using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class ResultOfPackageItemToMappingWithServerSide
{
    public byte Operation { get; set; }

    public int CharId { get; set; }

    public int Slot { get; set; }

    public long RefItemSerial64 { get; set; }

    public long RefItemDbid { get; set; }

    public int RefItemId { get; set; }

    public byte Type { get; set; }

    public byte SubType { get; set; }
}
