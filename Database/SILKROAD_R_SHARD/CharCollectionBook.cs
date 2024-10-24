using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class CharCollectionBook
{
    public int CharId { get; set; }

    public int ThemeId { get; set; }

    public int SlotIndex { get; set; }

    public DateTime RegDate { get; set; }
}
