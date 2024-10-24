﻿using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefQuestRewardItem
{
    public byte Service { get; set; }

    public int QuestId { get; set; }

    public string QuestCodeName { get; set; } = null!;

    public byte RewardType { get; set; }

    public string ItemCodeName { get; set; } = null!;

    public string OptionalItemCode { get; set; } = null!;

    public int OptionalItemCnt { get; set; }

    public int AchieveQuantity { get; set; }

    public string RentItemCodeName { get; set; } = null!;

    public byte IsPackageItem { get; set; }

    public byte MinLevel { get; set; }

    public byte MaxLevel { get; set; }

    public int Param1 { get; set; }

    public string Param1Desc { get; set; } = null!;

    public int Param2 { get; set; }

    public string Param2Desc { get; set; } = null!;
}
