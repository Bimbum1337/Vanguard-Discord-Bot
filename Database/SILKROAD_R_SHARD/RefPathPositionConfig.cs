using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefPathPositionConfig
{
    public int Id { get; set; }

    public int ConfigGroupId { get; set; }

    public string ConfigCodename { get; set; } = null!;

    public string ValueCodename { get; set; } = null!;

    public string ValueType { get; set; } = null!;

    public string Value { get; set; } = null!;

    public virtual RefPathConfigType ConfigCodenameNavigation { get; set; } = null!;

    public virtual RefPathPositionConfigGroup ConfigGroup { get; set; } = null!;
}
