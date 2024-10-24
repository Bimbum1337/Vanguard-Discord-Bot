using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefEntryTicketSchedule
{
    public int Id { get; set; }

    public int EventId { get; set; }

    public int ScheduleType { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}
