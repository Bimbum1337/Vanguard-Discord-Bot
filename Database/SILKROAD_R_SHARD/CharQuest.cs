using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class CharQuest
{
    public int CharId { get; set; }

    public int QuestId { get; set; }

    public byte Status { get; set; }

    public short AchievementCount { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public long? QuestData1 { get; set; }

    public long? QuestData2 { get; set; }

    public long? QuestData3 { get; set; }

    public byte? DailyStatus { get; set; }
}
