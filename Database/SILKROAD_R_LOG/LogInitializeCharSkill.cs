using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_LOG;

public partial class LogInitializeCharSkill
{
    public int Id { get; set; }

    public int CharId { get; set; }

    public int SkillId { get; set; }

    public byte Enable { get; set; }
}
