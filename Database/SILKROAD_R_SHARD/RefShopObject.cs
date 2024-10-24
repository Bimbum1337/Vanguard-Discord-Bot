using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class RefShopObject
{
    public int Id { get; set; }

    public string CodeName128 { get; set; } = null!;

    public virtual ICollection<RefMappingShopGroup> RefMappingShopGroups { get; set; } = new List<RefMappingShopGroup>();

    public virtual ICollection<RefMappingShopWithTab> RefMappingShopWithTabs { get; set; } = new List<RefMappingShopWithTab>();

    public virtual ICollection<RefPackageItem> RefPackageItems { get; set; } = new List<RefPackageItem>();

    public virtual ICollection<RefPricePolicyOfItem> RefPricePolicyOfItems { get; set; } = new List<RefPricePolicyOfItem>();

    public virtual ICollection<RefShopGood> RefShopGoods { get; set; } = new List<RefShopGood>();

    public virtual ICollection<RefShopGroup> RefShopGroups { get; set; } = new List<RefShopGroup>();

    public virtual ICollection<RefShopTabGroup> RefShopTabGroups { get; set; } = new List<RefShopTabGroup>();

    public virtual ICollection<RefShopTab> RefShopTabs { get; set; } = new List<RefShopTab>();

    public virtual ICollection<RefShop> RefShops { get; set; } = new List<RefShop>();
}
