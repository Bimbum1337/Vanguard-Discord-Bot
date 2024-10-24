using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class StatisticsCharLastLogout
{
    public DateTime? TimeBegin { get; set; }

    public DateTime? TimeEnd { get; set; }

    public byte? LevelBegin { get; set; }

    public byte? LevelEnd { get; set; }

    public int? LogoutCount { get; set; }

    public int? TotalCount { get; set; }

    public int ChinaCount { get; set; }

    public int ChinaLogoutCnt { get; set; }

    public int EuropeCount { get; set; }

    public int EuropeLogoutCnt { get; set; }
}
