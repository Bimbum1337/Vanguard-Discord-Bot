﻿using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefScrapOfPackageItem
{
    public byte Service { get; set; }

    public int Country { get; set; }

    public string RefPackageItemCodeName { get; set; } = null!;

    public string RefItemCodeName { get; set; } = null!;

    public byte OptLevel { get; set; }

    public long Variance { get; set; }

    public int Data { get; set; }

    public byte MagParamNum { get; set; }

    public long MagParam1 { get; set; }

    public long MagParam2 { get; set; }

    public long MagParam3 { get; set; }

    public long MagParam4 { get; set; }

    public long MagParam5 { get; set; }

    public long MagParam6 { get; set; }

    public long MagParam7 { get; set; }

    public long MagParam8 { get; set; }

    public long MagParam9 { get; set; }

    public long MagParam10 { get; set; }

    public long MagParam11 { get; set; }

    public long MagParam12 { get; set; }

    public int Param1 { get; set; }

    public string Param1Desc128 { get; set; } = null!;

    public int Param2 { get; set; }

    public string Param2Desc128 { get; set; } = null!;

    public int Param3 { get; set; }

    public string Param3Desc128 { get; set; } = null!;

    public int Param4 { get; set; }

    public string Param4Desc128 { get; set; } = null!;

    public int Index { get; set; }

    public virtual RefShopObject CountryNavigation { get; set; } = null!;
}
