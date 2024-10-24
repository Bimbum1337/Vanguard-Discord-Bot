using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class CraftedMacroUser
{
    public int Jid { get; set; }

    public int CharId { get; set; }

    public string Ip { get; set; } = null!;

    public byte Version { get; set; }

    public DateTime Date { get; set; }
}
