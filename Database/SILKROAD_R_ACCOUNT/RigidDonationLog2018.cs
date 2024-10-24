using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class RigidDonationLog2018
{
    public int PortalJid { get; set; }

    public string UserId { get; set; } = null!;

    public int SilkAmount { get; set; }

    public int SilkBefore { get; set; }

    public int SilkAfter { get; set; }

    public byte SilkType { get; set; }

    public DateTime ChargeDate { get; set; }

    public string PaymentService { get; set; } = null!;

    public long Serial { get; set; }
}
