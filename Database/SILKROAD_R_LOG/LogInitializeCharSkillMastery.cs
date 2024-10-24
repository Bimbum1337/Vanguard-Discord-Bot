using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_LOG;

public partial class LogInitializeCharSkillMastery
{
    public int Id { get; set; }

    public int CharId { get; set; }

    public int MasteryId { get; set; }

    public int Level { get; set; }
}
