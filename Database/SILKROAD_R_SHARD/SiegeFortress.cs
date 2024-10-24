using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class SiegeFortress
{
    public int FortressId { get; set; }

    public int GuildId { get; set; }

    public short TaxRatio { get; set; }

    public long Tax { get; set; }

    public byte Npchired { get; set; }

    public int TempGuildId { get; set; }

    public string? Introduction { get; set; }

    public DateTime? CreatedDungeonTime { get; set; }

    public byte? CreatedDungeonCount { get; set; }

    public byte IntroductionModificationPermission { get; set; }

    public byte OccupyCount { get; set; }

    public bool OccupyRewardFlag { get; set; }

    public virtual Guild Guild { get; set; } = null!;

    public virtual ICollection<SiegeFortressBattleRecord> SiegeFortressBattleRecords { get; set; } = new List<SiegeFortressBattleRecord>();

    public virtual ICollection<SiegeFortressItemForge> SiegeFortressItemForges { get; set; } = new List<SiegeFortressItemForge>();

    public virtual ICollection<SiegeFortressObject> SiegeFortressObjects { get; set; } = new List<SiegeFortressObject>();

    public virtual ICollection<SiegeFortressRequest> SiegeFortressRequests { get; set; } = new List<SiegeFortressRequest>();
}
