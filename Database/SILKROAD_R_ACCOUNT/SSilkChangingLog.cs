using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class SSilkChangingLog
{
    public int ChangingNumber { get; set; }

    public int? Jid { get; set; }

    public DateTime? ChangingDate { get; set; }

    public int? ChangingSilkOwn { get; set; }

    public int? ChangingSilkOwnRemain { get; set; }

    public int? ChangingSilkGift { get; set; }

    public int? ChangingSilkGiftRemain { get; set; }

    public int? ChangingSilkPoint { get; set; }

    public int? ChangingSilkPointRemain { get; set; }

    public int? BuyNo { get; set; }

    public string? ShardName { get; set; }

    public long? Serial64 { get; set; }

    public string? SalesStatus { get; set; }

    public int ChangingSilkOwnPremium { get; set; }

    public int ChangingSilkOwnPremiumRemain { get; set; }

    public int ChangingSilkGiftPremium { get; set; }

    public int ChangingSilkGiftPremiumRemain { get; set; }
}
