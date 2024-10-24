using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class ExchangeItemPaymentDatum
{
    public int CharId { get; set; }

    public byte Slot { get; set; }

    public int RefItemId { get; set; }

    public int Data { get; set; }

    public byte OptLevel { get; set; }

    public long Variance { get; set; }

    public byte MagicParamNum { get; set; }

    public long MagParam1 { get; set; }

    public long MagParam2 { get; set; }

    public long MagParam3 { get; set; }

    public long MagParam4 { get; set; }

    public long MagParam5 { get; set; }

    public long MagParam6 { get; set; }

    public long MagParam7 { get; set; }

    public long MagParam8 { get; set; }

    public long MagParam9 { get; set; }

    public long MagParam10 { get; set; }

    public long MagParam11 { get; set; }

    public long MagParam12 { get; set; }

    public string RentCodeName { get; set; } = null!;

    public DateTime MeterRateTime { get; set; }
}
