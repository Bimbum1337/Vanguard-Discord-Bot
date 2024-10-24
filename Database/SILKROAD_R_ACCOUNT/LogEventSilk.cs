using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class LogEventSilk
{
    public DateTime EventTime { get; set; }

    public int Jid { get; set; }

    public long BeforeSilk { get; set; }

    public long AfterSilk { get; set; }
}
