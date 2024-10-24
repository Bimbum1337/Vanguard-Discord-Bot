using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class ModuleVersion
{
    public int NId { get; set; }

    public byte NDivisionId { get; set; }

    public byte NContentId { get; set; }

    public byte NModuleId { get; set; }

    public int NVersion { get; set; }

    public string SzVersion { get; set; } = null!;

    public string SzDesc { get; set; } = null!;

    public byte NValid { get; set; }
}
