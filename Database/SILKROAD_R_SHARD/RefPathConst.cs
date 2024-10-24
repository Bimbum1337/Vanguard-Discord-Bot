using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefPathConst
{
    public string ConstType { get; set; } = null!;

    public string Codename { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<RefPath> RefPathBehaviorTypeOnMasterDeadNavigations { get; set; } = new List<RefPath>();

    public virtual ICollection<RefPath> RefPathObjectTypeNavigations { get; set; } = new List<RefPath>();

    public virtual ICollection<RefPath> RefPathRespawnTypeNavigations { get; set; } = new List<RefPath>();
}
