using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class AssociationReputation
{
    public string AssociationCodeName { get; set; } = null!;

    public string AssociationTypeName { get; set; } = null!;

    public int Reputation { get; set; }

    public int PriorOccupation { get; set; }
}
