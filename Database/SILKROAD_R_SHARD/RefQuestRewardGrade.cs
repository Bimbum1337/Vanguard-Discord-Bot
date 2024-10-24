using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefQuestRewardGrade
{
    public byte Service { get; set; }

    public int QuestId { get; set; }

    public string QuestCodeName { get; set; } = null!;

    public byte IncreaseType { get; set; }

    public float GoldRate { get; set; }

    public float ExpRate { get; set; }

    public float SpexpRate { get; set; }

    public float Sprate { get; set; }
}
