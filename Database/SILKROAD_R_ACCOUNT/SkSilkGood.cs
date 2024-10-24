using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class SkSilkGood
{
    public byte Service { get; set; }

    public int Id { get; set; }

    public string GoodsCode { get; set; } = null!;

    public string GoodsName { get; set; } = null!;

    public int SilkQuantity { get; set; }

    public int SilkPrice { get; set; }

    public byte Category { get; set; }

    public string Cpname { get; set; } = null!;

    public byte ChargePolicy { get; set; }

    public byte BuyMethod { get; set; }

    public DateTime RegDate { get; set; }
}
