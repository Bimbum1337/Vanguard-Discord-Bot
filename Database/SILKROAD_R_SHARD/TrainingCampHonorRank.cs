using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TrainingCampHonorRank
{
    public int Ranking { get; set; }

    public int? CampId { get; set; }

    public byte? Rank { get; set; }
}
