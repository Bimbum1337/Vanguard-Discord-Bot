using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TimedJobForPet
{
    public int Id { get; set; }

    public int CharId { get; set; }

    public byte Category { get; set; }

    public int JobId { get; set; }

    public int TimeToKeep { get; set; }

    public int? Data1 { get; set; }

    public int? Data2 { get; set; }

    public int? Data3 { get; set; }

    public int? Data4 { get; set; }

    public int? Data5 { get; set; }

    public int? Data6 { get; set; }

    public int? Data7 { get; set; }

    public int? Data8 { get; set; }

    public long Serial64 { get; set; }
}
