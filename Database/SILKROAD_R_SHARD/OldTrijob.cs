using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class OldTrijob
{
    public int CharId { get; set; }

    public byte JobLvlTrader { get; set; }

    public int TraderExp { get; set; }

    public byte JobLvlRobber { get; set; }

    public int RobberExp { get; set; }

    public byte JobLvlHunter { get; set; }

    public int HunterExp { get; set; }
}
