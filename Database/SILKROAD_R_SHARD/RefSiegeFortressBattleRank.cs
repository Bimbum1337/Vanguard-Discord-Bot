using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefSiegeFortressBattleRank
{
    public byte Service { get; set; }

    public byte RankLvl { get; set; }

    public string RankName { get; set; } = null!;

    public int ReqPkcount { get; set; }

    public int BindedSkillId { get; set; }

    public string CrestPath128 { get; set; } = null!;
}
