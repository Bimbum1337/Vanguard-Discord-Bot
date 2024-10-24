using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class SupportGoldConfig
{
    public byte Id { get; set; }

    public byte? ManageType { get; set; }

    public long? MaximumGold { get; set; }

    public long? SupplyGold { get; set; }

    public int? ChargeGold { get; set; }

    public float? ChargeX1 { get; set; }

    public float? ChargeX2 { get; set; }

    public float? ChargeX3 { get; set; }

    public float? ChargeX5 { get; set; }

    public float? ChargeX10 { get; set; }

    public float? ChargeX20 { get; set; }

    public float? ChargeX30 { get; set; }

    public float? ChargeX50 { get; set; }

    public float? ChargeX100 { get; set; }

    public float? ChargeX1000 { get; set; }

    public long? AccumulatedGold { get; set; }
}
