using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class AccountJid
{
    public string AccountId { get; set; } = null!;

    public int Jid { get; set; }

    public long Gold { get; set; }

    public byte ServiceCompany { get; set; }

    public virtual ICollection<Chest> Chests { get; set; } = new List<Chest>();

    public virtual LastestOpenMarketPesnalId? LastestOpenMarketPesnalId { get; set; }

    public virtual ICollection<OpenMarket> OpenMarkets { get; set; } = new List<OpenMarket>();

    public virtual UserFestivalScore? UserFestivalScore { get; set; }
}
