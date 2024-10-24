using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class Friend
{
    public int CharId { get; set; }

    public int FriendCharId { get; set; }

    public string FriendCharName { get; set; } = null!;

    public int? RefObjId { get; set; }

    public short GroupId { get; set; }

    public virtual Char Char { get; set; } = null!;

    public virtual Char FriendChar { get; set; } = null!;
}
