using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefLearnRecipeByReqType
{
    public byte Service { get; set; }

    public string RecipeCodeName { get; set; } = null!;

    public byte ReqType { get; set; }

    public int ReqValue { get; set; }

    public byte ReqSubType { get; set; }

    public int ReqSubValue { get; set; }
}
