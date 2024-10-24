using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class WebMessageBox
{
    public int Idx { get; set; }

    public int? FromCpJid { get; set; }

    public string? FromUserId { get; set; }

    public string? FromShard { get; set; }

    public string? FromCharacter { get; set; }

    public int? ToCpJid { get; set; }

    public string? ToShard { get; set; }

    public string? ToCharacter { get; set; }

    public string? Subject { get; set; }

    public string? Contents { get; set; }

    public byte? IsDel { get; set; }

    public DateTime? OpenDate { get; set; }

    public DateTime RegDate { get; set; }

    public int? Silk { get; set; }
}
