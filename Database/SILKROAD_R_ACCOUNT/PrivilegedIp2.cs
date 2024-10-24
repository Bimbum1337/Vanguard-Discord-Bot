using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class PrivilegedIp2
{
    public int NIdx { get; set; }

    public string SzIpbegin { get; set; } = null!;

    public string SzIpend { get; set; } = null!;

    public string SzGm { get; set; } = null!;

    public DateTime DIssueDate { get; set; }

    public string? SzIsp { get; set; }

    public string? SzDesc { get; set; }
}
