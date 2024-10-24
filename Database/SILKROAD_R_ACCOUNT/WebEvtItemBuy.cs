using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class WebEvtItemBuy
{
    public int Idx { get; set; }

    public int RefIdx { get; set; }

    public int CpJid { get; set; }

    public int SilkAmount { get; set; }

    public DateTime RegDate { get; set; }
}
