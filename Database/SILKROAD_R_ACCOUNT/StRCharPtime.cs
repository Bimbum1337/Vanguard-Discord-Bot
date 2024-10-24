using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class StRCharPtime
{
    public DateTime RegTime { get; set; }

    public short ServiceCode { get; set; }

    public int PortalJid { get; set; }

    public string WorldName { get; set; } = null!;

    public string ChannelName { get; set; } = null!;

    public int Cpjid { get; set; }

    public int CharId { get; set; }

    public string CharName { get; set; } = null!;

    public short CharLevel { get; set; }

    public bool LogType { get; set; }

    public DateTime LogInTime { get; set; }

    public DateTime LogOutTime { get; set; }
}
