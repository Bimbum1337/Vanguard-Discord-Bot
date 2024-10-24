using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class MagicLampHistory
{
    public int Idx { get; set; }

    public int LampNum { get; set; }

    public int? RoundNo { get; set; }

    public int UserJid { get; set; }

    public string UserId { get; set; } = null!;

    public int ShardId { get; set; }

    public string ShardName { get; set; } = null!;

    public int? PackageId { get; set; }

    public string? ItemName { get; set; }

    public int ItemWin { get; set; }

    public DateTime? RecieveDate { get; set; }

    public DateTime RegDate { get; set; }

    public string Ip { get; set; } = null!;
}
