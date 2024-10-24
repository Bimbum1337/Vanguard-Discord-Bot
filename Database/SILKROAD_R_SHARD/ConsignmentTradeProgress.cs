using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class ConsignmentTradeProgress
{
    public int Id { get; set; }

    public byte JobType { get; set; }

    public byte State { get; set; }

    public int PathId { get; set; }

    public int FlockId { get; set; }

    public int Tiredness { get; set; }

    public int TotalCount { get; set; }

    public int RemainCount { get; set; }

    public byte Magnification { get; set; }

    public DateTime EventTime { get; set; }
}
