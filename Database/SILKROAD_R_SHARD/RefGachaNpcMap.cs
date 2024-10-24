using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefGachaNpcMap
{
    public byte Service { get; set; }

    public int NpcId { get; set; }

    public int SelectionGachaId { get; set; }

    public int WasteGachaId { get; set; }

    public int SelectionPreGachaId { get; set; }

    public int WastePreGachaId { get; set; }
}
