using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefGachaTreeForClientUi
{
    public byte Service { get; set; }

    public byte Tid1 { get; set; }

    public byte Tid2 { get; set; }

    public byte Tid3 { get; set; }

    public byte Tid4 { get; set; }

    public short FirstCategoryId { get; set; }

    public string FirstCategoryString { get; set; } = null!;

    public short SecondCategoryId { get; set; }

    public string SecondCategoryString { get; set; } = null!;

    public byte ItemDegree { get; set; }
}
