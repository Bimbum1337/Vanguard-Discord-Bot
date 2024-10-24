using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_LOG;

public partial class LogEventItem
{
    public DateTime EventTime { get; set; }

    public int CharId { get; set; }

    public int ItemRefId { get; set; }

    public int DwData { get; set; }

    public byte TargetStorage { get; set; }

    public byte Operation { get; set; }

    public byte SlotFrom { get; set; }

    public byte SlotTo { get; set; }

    public string? EventPos { get; set; }

    public string? StrDesc { get; set; }

    public long Serial64 { get; set; }

    public long? Gold { get; set; }

    public byte? ServiceCompany { get; set; }
}
