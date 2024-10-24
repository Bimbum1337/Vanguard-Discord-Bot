using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class WebVoteItem
{
    public int Idx { get; set; }

    public int PollNum { get; set; }

    public string? ItemName { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemSnCode { get; set; }

    public byte ItemQuantity { get; set; }
}
