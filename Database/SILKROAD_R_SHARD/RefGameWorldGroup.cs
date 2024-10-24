using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefGameWorldGroup
{
    public int Id { get; set; }

    public string CodeName128 { get; set; } = null!;

    public string ObjName128 { get; set; } = null!;

    public string ConfigGroupCodeName128 { get; set; } = null!;

    public virtual ICollection<RefGameWorldBindGameWorldGroup> RefGameWorldBindGameWorldGroups { get; set; } = new List<RefGameWorldBindGameWorldGroup>();
}
