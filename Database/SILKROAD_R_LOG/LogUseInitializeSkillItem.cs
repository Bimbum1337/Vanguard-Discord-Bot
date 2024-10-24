using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_LOG;

public partial class LogUseInitializeSkillItem
{
    public int CharId { get; set; }

    public int ItemRefId { get; set; }

    public int BeforeRemainSp { get; set; }

    public int AfterRemainSp { get; set; }

    public DateTime InitDate { get; set; }
}
