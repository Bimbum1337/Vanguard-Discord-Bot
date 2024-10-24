using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class SkSilkChangeByWeb
{
    public int Id { get; set; }

    public int Jid { get; set; }

    public int SilkRemain { get; set; }

    public int SilkOffset { get; set; }

    public byte SilkType { get; set; }

    public byte Reason { get; set; }
}
