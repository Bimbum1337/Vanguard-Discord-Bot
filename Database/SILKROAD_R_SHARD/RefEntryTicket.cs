using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefEntryTicket
{
    public int Service { get; set; }

    public int EventGroupId { get; set; }

    public int EventId { get; set; }

    public int EntryType { get; set; }

    public int MinLevel { get; set; }

    public int MaxLevel { get; set; }

    public int CountryCondition { get; set; }

    public int GenderCondition { get; set; }

    public int LimitCount { get; set; }

    public int WinnerCount { get; set; }

    public float DrawingRatio { get; set; }

    public string ItemCodeName { get; set; } = null!;

    public int ItemPayCount { get; set; }

    public string CoinType1 { get; set; } = null!;

    public int CoinQuantity1 { get; set; }

    public string CoinType2 { get; set; } = null!;

    public int CoinQuantity2 { get; set; }

    public string CoinType3 { get; set; } = null!;

    public int CoinQuantity3 { get; set; }

    public string Param1Desc { get; set; } = null!;

    public int Param1 { get; set; }

    public string Param2Desc { get; set; } = null!;

    public int Param2 { get; set; }

    public string Param3Desc { get; set; } = null!;

    public int Param3 { get; set; }
}
