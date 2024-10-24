using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class LoginEventReward
{
    public byte Service { get; set; }

    public int Id { get; set; }

    public short Day { get; set; }

    public int RefItemId { get; set; }

    public string RefCodeName128 { get; set; } = null!;

    public string RefNameStr { get; set; } = null!;

    public string RefAssocFileIcon128 { get; set; } = null!;

    public int Count { get; set; }
}
