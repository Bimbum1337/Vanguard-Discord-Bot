using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class SecurityDescriptionGroup
{
    public byte NId { get; set; }

    public string SzName { get; set; } = null!;

    public string SzDesc { get; set; } = null!;
}
