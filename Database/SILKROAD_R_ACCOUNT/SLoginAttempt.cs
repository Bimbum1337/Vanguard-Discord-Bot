using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class SLoginAttempt
{
    public string? UserId { get; set; }

    public DateTime? AttemptDate { get; set; }

    public byte? IsLoginSuccess { get; set; }
}
