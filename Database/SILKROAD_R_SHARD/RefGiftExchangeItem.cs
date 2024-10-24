using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefGiftExchangeItem
{
    public int CouponIndex { get; set; }

    public int RefItemId { get; set; }

    public short ItemStack { get; set; }

    public int ItemCount { get; set; }

    public float ItemRatio { get; set; }

    public byte MagicType { get; set; }

    public string MagicValue { get; set; } = null!;

    public string RentCodeName { get; set; } = null!;

    public virtual RefGiftExchangeCoupon CouponIndexNavigation { get; set; } = null!;

    public virtual RefObjCommon RefItem { get; set; } = null!;
}
