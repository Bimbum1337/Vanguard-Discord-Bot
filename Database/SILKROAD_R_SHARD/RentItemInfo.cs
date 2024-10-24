using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RentItemInfo
{
    public long NItemDbid { get; set; }

    public int NRentType { get; set; }

    public short NCanDelete { get; set; }

    public short NCanRecharge { get; set; }

    public DateTime PeriodBeginTime { get; set; }

    public DateTime PeriodEndTime { get; set; }

    public DateTime? MeterRateTime { get; set; }

    public short? NPackingState { get; set; }

    public int? NPackingTime { get; set; }
}
