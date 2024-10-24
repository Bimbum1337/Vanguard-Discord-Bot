using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefAlchemyMkToolTip
{
    public byte Service { get; set; }

    public string RcCodeName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string MaterialStrName1 { get; set; } = null!;

    public int MaterialStrName1Count { get; set; }

    public string MaterialStrName2 { get; set; } = null!;

    public int MaterialStrName2Count { get; set; }

    public string MaterialStrName3 { get; set; } = null!;

    public int MaterialStrName3Count { get; set; }

    public string MaterialStrName4 { get; set; } = null!;

    public int MaterialStrName4Count { get; set; }

    public string MaterialStrName5 { get; set; } = null!;

    public int MaterialStrName5Count { get; set; }

    public string MaterialStrName6 { get; set; } = null!;

    public int MaterialStrName6Count { get; set; }

    public byte ResultType { get; set; }

    public string ResultItemStrName { get; set; } = null!;

    public int ResultItemCount { get; set; }

    public string ResultItemToolTip { get; set; } = null!;

    public string ResultItemIcon { get; set; } = null!;
}
