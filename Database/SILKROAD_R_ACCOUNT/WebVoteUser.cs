using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class WebVoteUser
{
    public int Idx { get; set; }

    public int CpJid { get; set; }

    public int PollNum { get; set; }

    public int ShardId { get; set; }

    public string Charname { get; set; } = null!;

    public int Charlevel { get; set; }

    public string Job { get; set; } = null!;

    public string Class { get; set; } = null!;

    public string CountryCode { get; set; } = null!;

    public string Ip { get; set; } = null!;

    public DateTime RegDate { get; set; }
}
