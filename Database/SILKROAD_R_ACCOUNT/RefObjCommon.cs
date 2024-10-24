using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class RefObjCommon
{
    public int Service { get; set; }

    public int Id { get; set; }

    public string CodeName128 { get; set; } = null!;

    public string ObjName128 { get; set; } = null!;

    public string OrgObjCodeName128 { get; set; } = null!;

    public string NameStrId128 { get; set; } = null!;

    public string DescStrId128 { get; set; } = null!;

    public byte CashItem { get; set; }

    public byte Bionic { get; set; }

    public byte TypeId1 { get; set; }

    public byte TypeId2 { get; set; }

    public byte TypeId3 { get; set; }

    public byte TypeId4 { get; set; }

    public int DecayTime { get; set; }

    public byte Country { get; set; }

    public byte Rarity { get; set; }

    public byte CanTrade { get; set; }

    public byte CanSell { get; set; }

    public byte CanBuy { get; set; }

    public byte CanBorrow { get; set; }

    public byte CanDrop { get; set; }

    public byte CanPick { get; set; }

    public byte CanRepair { get; set; }

    public byte CanRevive { get; set; }

    public byte CanUse { get; set; }

    public byte CanThrow { get; set; }

    public int Price { get; set; }

    public int CostRepair { get; set; }

    public int CostRevive { get; set; }

    public int CostBorrow { get; set; }

    public int KeepingFee { get; set; }

    public int SellPrice { get; set; }

    public int ReqLevelType1 { get; set; }

    public byte ReqLevel1 { get; set; }

    public int ReqLevelType2 { get; set; }

    public byte ReqLevel2 { get; set; }

    public int ReqLevelType3 { get; set; }

    public byte ReqLevel3 { get; set; }

    public int ReqLevelType4 { get; set; }

    public byte ReqLevel4 { get; set; }

    public int MaxContain { get; set; }

    public short RegionId { get; set; }

    public short Dir { get; set; }

    public short OffsetX { get; set; }

    public short OffsetY { get; set; }

    public short OffsetZ { get; set; }

    public short Speed1 { get; set; }

    public short Speed2 { get; set; }

    public int Scale { get; set; }

    public short Bcheight { get; set; }

    public short Bcradius { get; set; }

    public int EventId { get; set; }

    public string AssocFileObj128 { get; set; } = null!;

    public string AssocFileDrop128 { get; set; } = null!;

    public string AssocFileIcon128 { get; set; } = null!;

    public string AssocFile1128 { get; set; } = null!;

    public string AssocFile2128 { get; set; } = null!;

    public int Link { get; set; }
}
