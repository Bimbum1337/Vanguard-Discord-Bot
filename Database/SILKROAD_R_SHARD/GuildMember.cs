using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class GuildMember
{
    public int GuildId { get; set; }

    public int CharId { get; set; }

    public string CharName { get; set; } = null!;

    public byte MemberClass { get; set; }

    public byte CharLevel { get; set; }

    public int GpDonation { get; set; }

    public DateTime JoinDate { get; set; }

    public int? Permission { get; set; }

    public int? Contribution { get; set; }

    public int? GuildWarKill { get; set; }

    public int? GuildWarKilled { get; set; }

    public string? Nickname { get; set; }

    public int? RefObjId { get; set; }

    public byte? SiegeAuthority { get; set; }

    public short LatestRegion { get; set; }

    public DateTime LastLogout { get; set; }

    public DateTime LastLevelup { get; set; }

    public virtual Char Char { get; set; } = null!;

    public virtual Guild Guild { get; set; } = null!;
}
