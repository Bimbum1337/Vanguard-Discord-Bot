using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefObjCharGrow
{
    public int Id { get; set; }

    public int CharId { get; set; }

    public short StrDef { get; set; }

    public short InitDef { get; set; }

    public short StrGrow { get; set; }

    public short IntGrow { get; set; }

    public short Lv1Hp { get; set; }

    public short LvUpHp { get; set; }

    public int SatietyMax { get; set; }

    public short SatietyConsume { get; set; }

    public short ScaleRate { get; set; }
}
