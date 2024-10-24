using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class CharCo
{
    public int Id { get; set; }

    public int OwnerCharId { get; set; }

    public int RefCharId { get; set; }

    public int Hp { get; set; }

    public int Mp { get; set; }

    public int KeeperNpc { get; set; }

    public byte State { get; set; }

    public string? CharName { get; set; }

    public byte Lvl { get; set; }

    public long ExpOffset { get; set; }

    public int Hgp { get; set; }

    public int PetOption { get; set; }

    public DateTime? RentEndTime { get; set; }

    public short? SexpOffset { get; set; }

    public int? Sp { get; set; }

    public int? SkillSlot { get; set; }

    public int? ExtraOption { get; set; }

    public virtual ICollection<InvCo> InvCos { get; set; } = new List<InvCo>();
}
