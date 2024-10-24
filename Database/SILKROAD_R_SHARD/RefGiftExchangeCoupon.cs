using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefGiftExchangeCoupon
{
    public byte Service { get; set; }

    public int CouponIndex { get; set; }

    public int RefItemId { get; set; }

    public byte ExchangeType { get; set; }

    public virtual ICollection<RefGiftExchangeItem> RefGiftExchangeItems { get; set; } = new List<RefGiftExchangeItem>();

    public virtual RefObjCommon RefItem { get; set; } = null!;
}
