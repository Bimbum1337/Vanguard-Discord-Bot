using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefFmnCategoryTree
{
    public byte Service { get; set; }

    public string CategoryName { get; set; } = null!;

    public string StringId { get; set; } = null!;

    public string ParentCategoryName { get; set; } = null!;

    public int TidGroupId { get; set; }

    public byte Degree { get; set; }
}
