using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefTriggerCategory
{
    public int Service { get; set; }

    public int Id { get; set; }

    public string CodeName128 { get; set; } = null!;

    public string? ObjName128 { get; set; }

    public int IndexNumber { get; set; }

    public virtual ICollection<RefGameWorldBindTriggerCategory> RefGameWorldBindTriggerCategories { get; set; } = new List<RefGameWorldBindTriggerCategory>();
}
