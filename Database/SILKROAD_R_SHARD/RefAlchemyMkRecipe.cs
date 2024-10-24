using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefAlchemyMkRecipe
{
    public byte Service { get; set; }

    public int RcId { get; set; }

    public string RcCodeName128 { get; set; } = null!;

    public string RcDesc128 { get; set; } = null!;

    public string RcStrId128 { get; set; } = null!;

    public string ResultStrId128 { get; set; } = null!;

    public string RcIcon { get; set; } = null!;

    public byte RcTab { get; set; }

    public byte RcSlot { get; set; }

    public byte RequireCharLevel { get; set; }

    public byte RcLevel { get; set; }

    public byte RcRarity { get; set; }

    public byte RcType { get; set; }

    public int RcReuseTime { get; set; }

    public int RcMakeTime { get; set; }

    public string MkMaterialGroup1 { get; set; } = null!;

    public int MtGroup1Condition { get; set; }

    public string MkMaterialGroup2 { get; set; } = null!;

    public int MtGroup2Condition { get; set; }

    public string MkMaterialGroup3 { get; set; } = null!;

    public int MtGroup3Condition { get; set; }

    public string MkResultGroup1 { get; set; } = null!;

    public int RtGroup1Condition { get; set; }

    public string MkResultGroup2 { get; set; } = null!;

    public int RtGroup2Condition { get; set; }

    public string MkResultGroup3 { get; set; } = null!;

    public int RtGroup3Condition { get; set; }

    public int Param1 { get; set; }

    public string Param1Desc128 { get; set; } = null!;

    public int Param2 { get; set; }

    public string Param2Desc128 { get; set; } = null!;

    public int Param3 { get; set; }

    public string Param3Desc128 { get; set; } = null!;
}
