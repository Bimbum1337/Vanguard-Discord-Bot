using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class SkSilk
{
    public int Jid { get; set; }

    public int SilkOwn { get; set; }

    public int SilkGift { get; set; }

    public int SilkPoint { get; set; }

    public int SilkOwnPremium { get; set; }

    public int SilkGiftPremium { get; set; }

    public virtual TbUserBackup JidNavigation { get; set; } = null!;
}
