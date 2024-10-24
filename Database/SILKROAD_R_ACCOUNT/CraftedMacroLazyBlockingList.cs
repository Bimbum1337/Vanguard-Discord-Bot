using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class CraftedMacroLazyBlockingList
{
    public int UserJid { get; set; }

    public short SharId { get; set; }

    public string CharName { get; set; } = null!;
}
