using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_LOG;

public partial class ConsignmentTradePrevInvestCharLog
{
    public int Id { get; set; }

    public DateTime EventTime { get; set; }

    public int CharId { get; set; }

    public int ProgressId { get; set; }

    public int RefObjId { get; set; }

    public int InvestCount { get; set; }
}
