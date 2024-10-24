using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class Notice
{
    public int Id { get; set; }

    public byte ContentId { get; set; }

    public string Subject { get; set; } = null!;

    public string Article { get; set; } = null!;

    public DateTime EditDate { get; set; }
}
