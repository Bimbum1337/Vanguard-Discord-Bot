using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TempChar
{
    public int CharId { get; set; }

    public byte Deleted { get; set; }

    public int RefObjId { get; set; }

    public string CharName16 { get; set; } = null!;

    public string NickName16 { get; set; } = null!;

    public byte Scale { get; set; }

    public byte CurLevel { get; set; }

    public byte MaxLevel { get; set; }

    public long ExpOffset { get; set; }

    public int SexpOffset { get; set; }

    public short Strength { get; set; }

    public short Intellect { get; set; }

    public long RemainGold { get; set; }

    public int RemainSkillPoint { get; set; }

    public short RemainStatPoint { get; set; }

    public byte RemainHwanCount { get; set; }

    public int GatheredExpPoint { get; set; }

    public int Hp { get; set; }

    public int Mp { get; set; }

    public short LatestRegion { get; set; }

    public float PosX { get; set; }

    public float PosY { get; set; }

    public float PosZ { get; set; }

    public int AppointedTeleport { get; set; }

    public byte AutoInvestExp { get; set; }

    public int InventorySize { get; set; }

    public byte DailyPk { get; set; }

    public short TotalPk { get; set; }

    public int PkpenaltyPoint { get; set; }

    public int Tpp { get; set; }

    public int PenaltyForfeit { get; set; }

    public int JobPenaltyTime { get; set; }

    public byte JobLvlTrader { get; set; }

    public int TraderExp { get; set; }

    public byte JobLvlHunter { get; set; }

    public int HunterExp { get; set; }

    public byte JobLvlRobber { get; set; }

    public int RobberExp { get; set; }

    public int? GuildId { get; set; }

    public DateTime LastLogout { get; set; }

    public short TelRegion { get; set; }

    public float TelPosX { get; set; }

    public float TelPosY { get; set; }

    public float TelPosZ { get; set; }

    public short DiedRegion { get; set; }

    public float DiedPosX { get; set; }

    public float DiedPosY { get; set; }

    public float DiedPosZ { get; set; }
}
