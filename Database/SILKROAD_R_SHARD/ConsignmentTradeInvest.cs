using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class ConsignmentTradeInvest
{
    public int Id { get; set; }

    public int CharId { get; set; }

    public int ProgressId { get; set; }

    public int RefObjId { get; set; }

    public int Count { get; set; }

    public DateTime EventTime { get; set; }
}
