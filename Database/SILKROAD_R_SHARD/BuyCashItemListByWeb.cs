using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class BuyCashItemListByWeb
{
    public long Idx { get; set; }

    public int Jid { get; set; }

    public int Section { get; set; }

    public string? PackageCodeName { get; set; }

    public long SubIdx { get; set; }

    public int RefItemId { get; set; }

    public int ItemCount { get; set; }

    public DateTime RegDate { get; set; }

    public int? RentType { get; set; }

    public short? CanDelete { get; set; }

    public short? CanRecharge { get; set; }

    public DateTime? DateBegin { get; set; }

    public DateTime? DateEnd { get; set; }

    public int? TimeCount { get; set; }
}
