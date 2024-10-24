using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class PathPositionRememberPathPatrol
{
    public int Id { get; set; }

    public int PathId { get; set; }

    public int FlockId { get; set; }

    public int FlockMemberId { get; set; }

    public int PositionIndex { get; set; }

    public int HeadDirection { get; set; }

    public byte LastPosLinkFirstPosState { get; set; }

    public byte PathPatrolLoopType { get; set; }

    public byte CanAttackState { get; set; }

    public int Hp { get; set; }

    public int Mp { get; set; }

    public int ConsignmentTradeId { get; set; }
}
