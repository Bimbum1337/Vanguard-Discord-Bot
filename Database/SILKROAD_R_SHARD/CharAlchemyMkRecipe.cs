using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class CharAlchemyMkRecipe
{
    public int CharId { get; set; }

    public int RcId { get; set; }

    public virtual Char Char { get; set; } = null!;
}
