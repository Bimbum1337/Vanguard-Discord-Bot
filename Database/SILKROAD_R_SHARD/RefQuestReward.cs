using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefQuestReward
{
    public byte Service { get; set; }

    public int QuestId { get; set; }

    public string QuestCodeName { get; set; } = null!;

    public byte IsView { get; set; }

    public byte IsBasicReward { get; set; }

    public byte IsItemReward { get; set; }

    public byte IsCheckCondition { get; set; }

    public byte IsCheckCountry { get; set; }

    public byte IsCheckClass { get; set; }

    public byte IsCheckGender { get; set; }

    public int Gold { get; set; }

    public int Exp { get; set; }

    public int Spexp { get; set; }

    public int Sp { get; set; }

    public int Ap { get; set; }

    public string Aptype { get; set; } = null!;

    public byte Hwan { get; set; }

    public byte Inventory { get; set; }

    public byte ItemRewardType { get; set; }

    public byte SelectionCnt { get; set; }

    public long Param1 { get; set; }

    public string Param1Desc { get; set; } = null!;

    public int Param2 { get; set; }

    public string Param2Desc { get; set; } = null!;

    public int Param3 { get; set; }

    public string Param3Desc { get; set; } = null!;
}
