using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_LOG;

public partial class ConsignmentTradeReward
{
    public int Id { get; set; }

    public int CharId { get; set; }

    public int ProgressId { get; set; }

    public int InvestCount { get; set; }

    public int TradeTotalCount { get; set; }

    public int RemainCount { get; set; }

    public string? Ratio { get; set; }
}
