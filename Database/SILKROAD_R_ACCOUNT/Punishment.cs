using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class Punishment
{
    public int SerialNo { get; set; }

    public int UserJid { get; set; }

    public byte Type { get; set; }

    public string Executor { get; set; } = null!;

    public short Shard { get; set; }

    public string? CharName { get; set; }

    public string CharInfo { get; set; } = null!;

    public string PosInfo { get; set; } = null!;

    public string Guide { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime RaiseTime { get; set; }

    public DateTime BlockStartTime { get; set; }

    public DateTime BlockEndTime { get; set; }

    public DateTime PunishTime { get; set; }

    public byte Status { get; set; }
}
