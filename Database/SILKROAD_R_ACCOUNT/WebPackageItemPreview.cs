using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class WebPackageItemPreview
{
    public int PackageId { get; set; }

    public int SilkType { get; set; }

    public string ItemCode { get; set; } = null!;

    public int Category { get; set; }

    public int RentType { get; set; }

    public int SetGroup { get; set; }

    public int SilkPrice { get; set; }

    public byte Display { get; set; }

    public byte DisplayNum { get; set; }

    public int Idx { get; set; }
}
