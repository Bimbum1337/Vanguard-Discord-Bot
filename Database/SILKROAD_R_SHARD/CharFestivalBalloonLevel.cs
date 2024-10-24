using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class CharFestivalBalloonLevel
{
    public int CharId { get; set; }

    public int RefBalloonId { get; set; }

    public byte BalloonLevel { get; set; }

    public virtual Char Char { get; set; } = null!;
}
