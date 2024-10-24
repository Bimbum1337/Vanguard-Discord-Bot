using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class CharNewTrade
{
    public int? CharId { get; set; }

    public byte TradeState { get; set; }

    public short DepartureRegionId { get; set; }
}
