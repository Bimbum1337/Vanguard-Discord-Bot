using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TrainingCampBuffStatus
{
    public int CampId { get; set; }

    public int RecipientCharId { get; set; }

    public byte BuffSlotIdx { get; set; }

    public int DonorCharId { get; set; }

    public DateTime StartingTime { get; set; }

    public int RemainBuffPoint { get; set; }

    public byte BuffType { get; set; }
}
