using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefPath
{
    public int Id { get; set; }

    public string Codename { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int RelatedWorldId { get; set; }

    public string ObjectType { get; set; } = null!;

    public short SpawnRange { get; set; }

    public short MoveSpeed { get; set; }

    public string RespawnType { get; set; } = null!;

    public string BehaviorTypeOnMasterDead { get; set; } = null!;

    public virtual RefPathConst BehaviorTypeOnMasterDeadNavigation { get; set; } = null!;

    public virtual RefPathConst ObjectTypeNavigation { get; set; } = null!;

    public virtual ICollection<RefPathFlock> RefPathFlocks { get; set; } = new List<RefPathFlock>();

    public virtual ICollection<RefPathPosition> RefPathPositions { get; set; } = new List<RefPathPosition>();

    public virtual RefPathConst RespawnTypeNavigation { get; set; } = null!;
}
