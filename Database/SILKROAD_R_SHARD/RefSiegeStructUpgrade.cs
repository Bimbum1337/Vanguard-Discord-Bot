﻿using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefSiegeStructUpgrade
{
    public byte Service { get; set; }

    public string Structname { get; set; } = null!;

    public string BaseStructcodename { get; set; } = null!;

    public string UpgradeStructname1 { get; set; } = null!;

    public string UpgradeStructname2 { get; set; } = null!;

    public string UpgradeStructname3 { get; set; } = null!;

    public string UpgradeStructname4 { get; set; } = null!;
}
