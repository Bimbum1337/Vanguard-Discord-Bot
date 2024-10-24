using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class TabRefTactic
{
    public int DwTacticsId { get; set; }

    public int DwObjId { get; set; }

    public byte BtAiqoS { get; set; }

    public int NMaxStamina { get; set; }

    public byte BtMaxStaminaVariance { get; set; }

    public int NSightRange { get; set; }

    public byte BtAggressType { get; set; }

    public int AggressData { get; set; }

    public byte BtChangeTarget { get; set; }

    public byte BtHelpRequestTo { get; set; }

    public byte BtHelpResponseTo { get; set; }

    public byte BtBattleStyle { get; set; }

    public int BattleStyleData { get; set; }

    public byte BtDiversionBasis { get; set; }

    public int DiversionBasisData1 { get; set; }

    public int DiversionBasisData2 { get; set; }

    public int DiversionBasisData3 { get; set; }

    public int DiversionBasisData4 { get; set; }

    public int DiversionBasisData5 { get; set; }

    public int DiversionBasisData6 { get; set; }

    public int DiversionBasisData7 { get; set; }

    public int DiversionBasisData8 { get; set; }

    public byte BtDiversionKeepBasis { get; set; }

    public int DiversionKeepBasisData1 { get; set; }

    public int DiversionKeepBasisData2 { get; set; }

    public int DiversionKeepBasisData3 { get; set; }

    public int DiversionKeepBasisData4 { get; set; }

    public int DiversionKeepBasisData5 { get; set; }

    public int DiversionKeepBasisData6 { get; set; }

    public int DiversionKeepBasisData7 { get; set; }

    public int DiversionKeepBasisData8 { get; set; }

    public byte BtKeepDistance { get; set; }

    public int KeepDistanceData { get; set; }

    public byte BtTraceType { get; set; }

    public byte BtTraceBoundary { get; set; }

    public int TraceData { get; set; }

    public byte BtHomingType { get; set; }

    public int HomingData { get; set; }

    public byte BtAggressTypeOnHoming { get; set; }

    public byte BtFleeType { get; set; }

    public int DwChampionTacticsId { get; set; }

    public int AdditionOptionFlag { get; set; }

    public string SzDescString128 { get; set; } = null!;

    public byte BtAggroType { get; set; }
}
