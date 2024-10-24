using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefPathFlock
{
    public int Id { get; set; }

    public int PathId { get; set; }

    public int PositionRememberType { get; set; }

    public virtual RefPath Path { get; set; } = null!;

    public virtual ICollection<RefPathFlockMember> RefPathFlockMembers { get; set; } = new List<RefPathFlockMember>();
}
