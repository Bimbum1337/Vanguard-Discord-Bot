using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_LOG;

public partial class LogServerEvent
{
    public int Id { get; set; }

    public DateTime EventTime { get; set; }

    public int ServerEventId { get; set; }

    public byte LogType { get; set; }

    public string? StrDesc { get; set; }
}
