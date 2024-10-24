using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class Item
{
    public long Id64 { get; set; }

    public int RefItemId { get; set; }

    public byte? OptLevel { get; set; }

    public long? Variance { get; set; }

    public int Data { get; set; }

    public string? CreaterName { get; set; }

    public byte MagParamNum { get; set; }

    public long? MagParam1 { get; set; }

    public long? MagParam2 { get; set; }

    public long? MagParam3 { get; set; }

    public long? MagParam4 { get; set; }

    public long? MagParam5 { get; set; }

    public long? MagParam6 { get; set; }

    public long? MagParam7 { get; set; }

    public long? MagParam8 { get; set; }

    public long? MagParam9 { get; set; }

    public long? MagParam10 { get; set; }

    public long? MagParam11 { get; set; }

    public long? MagParam12 { get; set; }

    public long Serial64 { get; set; }

    public virtual ICollection<Chest> Chests { get; set; } = new List<Chest>();

    public virtual ICollection<EquipInvCo> EquipInvCos { get; set; } = new List<EquipInvCo>();

    public virtual ICollection<InvCo> InvCos { get; set; } = new List<InvCo>();

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual ICollection<InventoryForAvatar> InventoryForAvatars { get; set; } = new List<InventoryForAvatar>();

    public virtual ItemPool? ItemPool { get; set; }

    public virtual ICollection<OpenMarket> OpenMarkets { get; set; } = new List<OpenMarket>();

    public virtual ICollection<TradeBagInventory> TradeBagInventories { get; set; } = new List<TradeBagInventory>();

    public virtual ICollection<TradeEquipInventory> TradeEquipInventories { get; set; } = new List<TradeEquipInventory>();
}
