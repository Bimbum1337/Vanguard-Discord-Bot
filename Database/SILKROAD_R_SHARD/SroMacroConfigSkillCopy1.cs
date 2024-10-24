using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class SroMacroConfigSkillCopy1
{
    public int CharId { get; set; }

    public byte? Service { get; set; }

    public short? Version { get; set; }

    public byte? AttackWeaponSlotNum { get; set; }

    public byte? AttackShieldSlotNum { get; set; }

    public short? AttackBinarySize { get; set; }

    public byte[]? AttackBinary { get; set; }

    public byte? BuffWeaponSlotNum { get; set; }

    public byte? BuffShieldSlotNum { get; set; }

    public short? BuffBinarySize { get; set; }

    public byte[]? BuffBinary { get; set; }
}
