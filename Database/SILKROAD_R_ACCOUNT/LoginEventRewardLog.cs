using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class LoginEventRewardLog
{
    public int Jid { get; set; }

    public short Month { get; set; }

    public byte Claim01to05 { get; set; }

    public byte Claim06to10 { get; set; }

    public byte Claim11to15 { get; set; }

    public byte Claim16to20 { get; set; }

    public byte Claim21to25 { get; set; }
}
