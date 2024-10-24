using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TrainingCampSubMentorHonorPoint
{
    public int CharId { get; set; }

    public int HonorPoint { get; set; }

    public virtual Char Char { get; set; } = null!;
}
