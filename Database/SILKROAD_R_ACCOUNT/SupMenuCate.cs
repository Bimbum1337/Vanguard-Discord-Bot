using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class SupMenuCate
{
    public short MenuCateNo { get; set; }

    public short MenuListSort { get; set; }

    public string MenuName { get; set; } = null!;

    public string MenuLink { get; set; } = null!;

    public byte MenuAuth { get; set; }

    public virtual ICollection<SupMenuCateUse> SupMenuCateUses { get; set; } = new List<SupMenuCateUse>();
}
