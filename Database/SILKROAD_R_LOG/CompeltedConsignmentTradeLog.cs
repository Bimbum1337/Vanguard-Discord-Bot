using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_LOG;

public partial class CompeltedConsignmentTradeLog
{
    public int Id { get; set; }

    public DateTime EventTime { get; set; }

    public int ProgressId { get; set; }

    public byte JobType { get; set; }

    public int Tiredness { get; set; }

    public int TotalCount { get; set; }

    public int RemainCount { get; set; }

    public byte Magnification { get; set; }
}
