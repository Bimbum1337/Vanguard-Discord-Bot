using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class Temp13thEquipOptlevel8OverLog
{
    public int Jid { get; set; }

    public string Account { get; set; } = null!;

    public string ObjName { get; set; } = null!;

    public byte OptLevel { get; set; }

    public DateTime EventTime { get; set; }
}
