using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class Char
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

    public short WorldId { get; set; }

    public short TelWorldId { get; set; }

    public short DiedWorldId { get; set; }

    public byte HwanLevel { get; set; }

    public virtual ICollection<AchievementCondition> AchievementConditions { get; set; } = new List<AchievementCondition>();

    public virtual ICollection<Achievement> Achievements { get; set; } = new List<Achievement>();

    public virtual ICollection<CharAlchemyMkRecipe> CharAlchemyMkRecipes { get; set; } = new List<CharAlchemyMkRecipe>();

    public virtual CharFestivalBalloonLevel? CharFestivalBalloonLevel { get; set; }

    public virtual CharFestivalReceipt? CharFestivalReceipt { get; set; }

    public virtual ICollection<CharSkillMastery> CharSkillMasteries { get; set; } = new List<CharSkillMastery>();

    public virtual ICollection<CharSkill> CharSkills { get; set; } = new List<CharSkill>();

    public virtual CharTrijob? CharTrijob { get; set; }

    public virtual ICollection<GuildMember> GuildMembers { get; set; } = new List<GuildMember>();

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual ICollection<InventoryForAvatar> InventoryForAvatars { get; set; } = new List<InventoryForAvatar>();

    public virtual ICollection<Memo> Memos { get; set; } = new List<Memo>();

    public virtual StaticAvatar? StaticAvatar { get; set; }

    public virtual ICollection<TimedJobCopy> TimedJobCopies { get; set; } = new List<TimedJobCopy>();

    public virtual ICollection<TimedJob> TimedJobs { get; set; } = new List<TimedJob>();

    public virtual ICollection<TradeBagInventory> TradeBagInventories { get; set; } = new List<TradeBagInventory>();

    public virtual ICollection<TradeEquipInventory> TradeEquipInventories { get; set; } = new List<TradeEquipInventory>();

    public virtual ICollection<TrainingCampMember> TrainingCampMembers { get; set; } = new List<TrainingCampMember>();

    public virtual TrainingCampSubMentorHonorPoint? TrainingCampSubMentorHonorPoint { get; set; }
}
