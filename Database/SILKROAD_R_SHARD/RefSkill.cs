using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefSkill
{
    public byte Service { get; set; }

    public int Id { get; set; }

    public int GroupId { get; set; }

    public string BasicCode { get; set; } = null!;

    public string BasicName { get; set; } = null!;

    public string BasicGroup { get; set; } = null!;

    public int BasicOriginal { get; set; }

    public byte BasicLevel { get; set; }

    public byte BasicActivity { get; set; }

    public int BasicChainCode { get; set; }

    public int BasicRecycleCost { get; set; }

    public int ActionPreparingTime { get; set; }

    public int ActionCastingTime { get; set; }

    public int ActionActionDuration { get; set; }

    public int ActionReuseDelay { get; set; }

    public int ActionCoolTime { get; set; }

    public int ActionFlyingSpeed { get; set; }

    public byte ActionInterruptable { get; set; }

    public int ActionOverlap { get; set; }

    public byte ActionAutoAttackType { get; set; }

    public byte ActionInTown { get; set; }

    public short ActionRange { get; set; }

    public byte TargetRequired { get; set; }

    public byte TargetTypeAnimal { get; set; }

    public byte TargetTypeLand { get; set; }

    public byte TargetTypeBuilding { get; set; }

    public byte TargetGroupSelf { get; set; }

    public byte TargetGroupAlly { get; set; }

    public byte TargetGroupParty { get; set; }

    public byte TargetGroupEnemyM { get; set; }

    public byte TargetGroupEnemyP { get; set; }

    public byte TargetGroupNeutral { get; set; }

    public byte TargetGroupDontCare { get; set; }

    public byte TargetEtcSelectDeadBody { get; set; }

    public int ReqCommonMastery1 { get; set; }

    public int ReqCommonMastery2 { get; set; }

    public byte ReqCommonMasteryLevel1 { get; set; }

    public byte ReqCommonMasteryLevel2 { get; set; }

    public short ReqCommonStr { get; set; }

    public short ReqCommonInt { get; set; }

    public int ReqLearnSkill1 { get; set; }

    public int ReqLearnSkill2 { get; set; }

    public int ReqLearnSkill3 { get; set; }

    public byte ReqLearnSkillLevel1 { get; set; }

    public byte ReqLearnSkillLevel2 { get; set; }

    public byte ReqLearnSkillLevel3 { get; set; }

    public int ReqLearnSp { get; set; }

    public byte ReqLearnRace { get; set; }

    public byte ReqRestriction1 { get; set; }

    public byte ReqRestriction2 { get; set; }

    public byte ReqCastWeapon1 { get; set; }

    public byte ReqCastWeapon2 { get; set; }

    public short ConsumeHp { get; set; }

    public int ConsumeMp { get; set; }

    public short ConsumeHpratio { get; set; }

    public short ConsumeMpratio { get; set; }

    public byte ConsumeWhan { get; set; }

    public byte UiSkillTab { get; set; }

    public byte UiSkillPage { get; set; }

    public byte UiSkillColumn { get; set; }

    public byte UiSkillRow { get; set; }

    public string UiIconFile { get; set; } = null!;

    public string UiSkillName { get; set; } = null!;

    public string UiSkillToolTip { get; set; } = null!;

    public string UiSkillToolTipDesc { get; set; } = null!;

    public string UiSkillStudyDesc { get; set; } = null!;

    public short AiAttackChance { get; set; }

    public byte AiSkillType { get; set; }

    public int Param1 { get; set; }

    public int Param2 { get; set; }

    public int Param3 { get; set; }

    public int Param4 { get; set; }

    public int Param5 { get; set; }

    public int Param6 { get; set; }

    public int Param7 { get; set; }

    public int Param8 { get; set; }

    public int Param9 { get; set; }

    public int Param10 { get; set; }

    public int Param11 { get; set; }

    public int Param12 { get; set; }

    public int Param13 { get; set; }

    public int Param14 { get; set; }

    public int Param15 { get; set; }

    public int Param16 { get; set; }

    public int Param17 { get; set; }

    public int Param18 { get; set; }

    public int Param19 { get; set; }

    public int Param20 { get; set; }

    public int Param21 { get; set; }

    public int Param22 { get; set; }

    public int Param23 { get; set; }

    public int Param24 { get; set; }

    public int Param25 { get; set; }

    public int? Param26 { get; set; }

    public int? Param27 { get; set; }

    public int? Param28 { get; set; }

    public int? Param29 { get; set; }

    public int? Param30 { get; set; }

    public int? Param31 { get; set; }

    public int? Param32 { get; set; }

    public int? Param33 { get; set; }

    public int? Param34 { get; set; }

    public int? Param35 { get; set; }

    public int? Param36 { get; set; }

    public int? Param37 { get; set; }

    public int? Param38 { get; set; }

    public int? Param39 { get; set; }

    public int? Param40 { get; set; }

    public int? Param41 { get; set; }

    public int? Param42 { get; set; }

    public int? Param43 { get; set; }

    public int? Param44 { get; set; }

    public int? Param45 { get; set; }

    public int? Param46 { get; set; }

    public int? Param47 { get; set; }

    public int? Param48 { get; set; }

    public int? Param49 { get; set; }

    public int? Param50 { get; set; }

    public virtual ICollection<RefSiegeBlessBuff> RefSiegeBlessBuffs { get; set; } = new List<RefSiegeBlessBuff>();
}
