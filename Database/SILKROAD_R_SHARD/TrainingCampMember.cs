using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TrainingCampMember
{
    public int CampId { get; set; }

    public int CharId { get; set; }

    public int RefObjId { get; set; }

    public string CharName { get; set; } = null!;

    public DateTime JoinDate { get; set; }

    public byte MemberClass { get; set; }

    public byte CharJoinedLevel { get; set; }

    public byte CharCurLevel { get; set; }

    public byte CharMaxLevel { get; set; }

    public int HonorPoint { get; set; }

    public virtual TrainingCamp Camp { get; set; } = null!;

    public virtual Char Char { get; set; } = null!;
}
