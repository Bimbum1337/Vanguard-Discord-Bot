using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_SHARD;

public partial class ServerGoldStatistic
{
    public int SgIdx { get; set; }

    public DateTime SgEventTime { get; set; }

    public int SgCharCount { get; set; }

    public int SgAccountCount { get; set; }

    public int SgGuildCount { get; set; }

    public int SgHunterCount { get; set; }

    public int SgRobberCount { get; set; }

    public long SgChar { get; set; }

    public long SgChest { get; set; }

    public long SgGuildChest { get; set; }

    public long SgGuildWarBooty { get; set; }

    public long SgGuildWarLodgedGold { get; set; }

    public long SgHunterReward { get; set; }

    public long SgRobberReward { get; set; }

    public long SgFortressJanganTax { get; set; }

    public long SgFortressDonwhangTax { get; set; }

    public long SgFortressHotanTax { get; set; }

    public long SgFortressConstantiopleTax { get; set; }

    public long SgFortressSamarkandTax { get; set; }

    public long SgFortressBijeokdanTax { get; set; }

    public long SgFortressHeukmakdanTax { get; set; }

    public long SgFortressEvilorderTax { get; set; }

    public long SgOpenMarketReceipt { get; set; }
}
