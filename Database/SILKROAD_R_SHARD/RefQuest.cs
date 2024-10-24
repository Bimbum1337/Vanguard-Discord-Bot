using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefQuest
{
    public byte Service { get; set; }

    public int Id { get; set; }

    public string CodeName { get; set; } = null!;

    public byte Level { get; set; }

    public string DescName { get; set; } = null!;

    public string NameString { get; set; } = null!;

    public string PayString { get; set; } = null!;

    public string ContentsString { get; set; } = null!;

    public string PayContents { get; set; } = null!;

    public string NoticeNpc { get; set; } = null!;

    public string NoticeCondition { get; set; } = null!;
}
