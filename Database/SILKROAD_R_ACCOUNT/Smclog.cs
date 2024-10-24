using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class Smclog
{
    public string SzUserId { get; set; } = null!;

    public byte Catagory { get; set; }

    public string SzLog { get; set; } = null!;

    public DateTime DLogDate { get; set; }
}
