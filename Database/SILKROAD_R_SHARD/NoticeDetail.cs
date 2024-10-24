using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class NoticeDetail
{
    public int Id { get; set; }

    public int NoticeId { get; set; }

    public string? DetailMessage { get; set; }

    public int Order { get; set; }
}
