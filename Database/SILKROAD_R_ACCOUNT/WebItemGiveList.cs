using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class WebItemGiveList
{
    public long Idx { get; set; }

    public int CpJid { get; set; }

    public int ShardId { get; set; }

    public int? CharacterId { get; set; }

    public int? CharacterLv { get; set; }

    public string ItemCodePackage { get; set; } = null!;

    public string? ItemNamePackage { get; set; }

    public string? NameCodePackage { get; set; }

    public int Section { get; set; }

    public int SilkOwn { get; set; }

    public int SilkOwnPremium { get; set; }

    public int SilkGift { get; set; }

    public int SilkGiftPremium { get; set; }

    public int SilkPoint { get; set; }

    public string Message { get; set; } = null!;

    public string RegIp { get; set; } = null!;

    public DateTime RegDate { get; set; }

    public DateTime? RecieveDate { get; set; }

    public string? InvoiceId { get; set; }

    public string? CpInvoiceId { get; set; }
}
