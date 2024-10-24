using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class SupMenuCateUse
{
    public int UseCateNo { get; set; }

    public int NId { get; set; }

    public short MenuCateNo { get; set; }

    public byte ControlAuth { get; set; }

    public short MenuSort { get; set; }

    public virtual SupMenuCate MenuCateNoNavigation { get; set; } = null!;
}
