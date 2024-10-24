using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class CasDatum
{
    public int NSerial { get; set; }

    public byte NCategory { get; set; }

    public DateTime DReportDate { get; set; }

    public short WShardId { get; set; }

    public int DwUserJid { get; set; }

    public string SzCharName { get; set; } = null!;

    public string? SzTgtCharName { get; set; }

    public string SzMailAddress { get; set; } = null!;

    public string SzStatement { get; set; } = null!;

    public byte NStatus { get; set; }

    public DateTime? DProcessDate { get; set; }

    public string? SzProcessedGm { get; set; }

    public string? SzMemo { get; set; }

    public string? SzAnswer { get; set; }

    public byte BtUserChecked { get; set; }

    public string SzChatLog { get; set; } = null!;
}
