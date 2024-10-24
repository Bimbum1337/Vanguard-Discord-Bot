using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class OpenMarket
{
    public int Jid { get; set; }

    public int PersnalId { get; set; }

    public string CharName16 { get; set; } = null!;

    public byte Status { get; set; }

    public int RefItemId { get; set; }

    public int TidGroupId { get; set; }

    public int ItemClass { get; set; }

    public long ItemId { get; set; }

    public int SellCnt { get; set; }

    public DateTime RegDate { get; set; }

    public DateTime EndDate { get; set; }

    public long Price { get; set; }

    public long Deposit { get; set; }

    public long SellFee { get; set; }

    public int UseCash { get; set; }

    public long Serial64 { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual AccountJid JidNavigation { get; set; } = null!;
}
