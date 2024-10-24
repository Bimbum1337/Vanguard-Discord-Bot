using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class UserFestivalScore
{
    public int UserJid { get; set; }

    public string AccountId { get; set; } = null!;

    public int FestivalScore { get; set; }

    public virtual AccountJid UserJ { get; set; } = null!;
}
