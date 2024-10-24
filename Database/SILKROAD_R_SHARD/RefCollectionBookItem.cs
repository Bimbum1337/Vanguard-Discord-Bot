﻿using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefCollectionBookItem
{
    public byte Service { get; set; }

    public string CodeName128 { get; set; } = null!;

    public string ObjName128 { get; set; } = null!;

    public string ThemeCodeName128 { get; set; } = null!;

    public int SlotIndex { get; set; }

    public string Story128 { get; set; } = null!;

    public string Ddjfile128 { get; set; } = null!;
}
