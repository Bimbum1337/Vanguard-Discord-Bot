using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class SupAdminLog
{
    public string AId { get; set; } = null!;

    public string MngMenu { get; set; } = null!;

    public int? SerialNo { get; set; }

    public string MngActName { get; set; } = null!;

    public string? ActContent { get; set; }

    public DateTime RegDate { get; set; }
}
