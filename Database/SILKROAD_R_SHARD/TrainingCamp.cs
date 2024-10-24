﻿using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TrainingCamp
{
    public int Id { get; set; }

    public DateTime CreationDate { get; set; }

    public byte Rank { get; set; }

    public int GraduateCount { get; set; }

    public int EvaluationPoint { get; set; }

    public DateTime LatestEvaluationDate { get; set; }

    public string? CommentTitle { get; set; }

    public string? Comment { get; set; }

    public virtual ICollection<TrainingCampMember> TrainingCampMembers { get; set; } = new List<TrainingCampMember>();
}
