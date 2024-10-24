using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class DeletedChar
{
    public int CharId { get; set; }

    public int UserJid { get; set; }

    public DateTime DeletedDate { get; set; }
}
