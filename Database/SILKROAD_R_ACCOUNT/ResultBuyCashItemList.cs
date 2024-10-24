using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class ResultBuyCashItemList
{
    public int ShardId { get; set; }

    public long Idx { get; set; }

    public int CpJid { get; set; }

    public int Section { get; set; }

    public string? NameCodePackage { get; set; }

    public long SubIdx { get; set; }

    public int Id { get; set; }

    public int ItemQuantity { get; set; }

    public DateTime RegDate { get; set; }

    public int? RentType { get; set; }

    public short? CanDelete { get; set; }

    public short? CanRecharge { get; set; }

    public DateTime? DateBegin { get; set; }

    public DateTime? DateEnd { get; set; }

    public int? TimeCount { get; set; }
}
