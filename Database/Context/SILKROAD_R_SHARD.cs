using BimBot.Database.SILKROAD_R_SHARD;
using Microsoft.EntityFrameworkCore;

namespace BimBot.Database.Context;

public partial class SILKROAD_R_SHARD : DbContext
{
    public SILKROAD_R_SHARD()
    {
    }

    public virtual DbSet<AccountJid> AccountJids { get; set; }

    public virtual DbSet<Achievement> Achievements { get; set; }

    public virtual DbSet<AchievementCondition> AchievementConditions { get; set; }

    public virtual DbSet<ActiveUser> ActiveUsers { get; set; }

    public virtual DbSet<ActiveUser1> ActiveUser1s { get; set; }

    public virtual DbSet<ActiveUser2> ActiveUser2s { get; set; }

    public virtual DbSet<ActiveUser3> ActiveUser3s { get; set; }

    public virtual DbSet<ActiveUser4> ActiveUser4s { get; set; }

    public virtual DbSet<ActiveUser5> ActiveUser5s { get; set; }

    public virtual DbSet<ActiveUser6> ActiveUser6s { get; set; }

    public virtual DbSet<ActiveUser7> ActiveUser7s { get; set; }

    public virtual DbSet<ActiveUserRigid> ActiveUserRigids { get; set; }

    public virtual DbSet<AllInventoryItem> AllInventoryItems { get; set; }

    public virtual DbSet<AllItem> AllItems { get; set; }

    public virtual DbSet<AllianceCrest> AllianceCrests { get; set; }

    public virtual DbSet<AlliedClan> AlliedClans { get; set; }

    public virtual DbSet<AlliedClans8> AlliedClans8s { get; set; }

    public virtual DbSet<AssociationReputation> AssociationReputations { get; set; }

    public virtual DbSet<BindingOptionWithItem> BindingOptionWithItems { get; set; }

    public virtual DbSet<BlockedPartyInviter> BlockedPartyInviters { get; set; }

    public virtual DbSet<BlockedWhisperer> BlockedWhisperers { get; set; }

    public virtual DbSet<BuyCashItemListByWeb> BuyCashItemListByWebs { get; set; }

    public virtual DbSet<CalcCharExpLog> CalcCharExpLogs { get; set; }

    public virtual DbSet<Database.SILKROAD_R_SHARD.Char> Chars { get; set; }

    public virtual DbSet<CharAlchemyMkRecipe> CharAlchemyMkRecipes { get; set; }

    public virtual DbSet<CharCo> CharCos { get; set; }

    public virtual DbSet<CharCollectionBook> CharCollectionBooks { get; set; }

    public virtual DbSet<CharFestivalBalloonLevel> CharFestivalBalloonLevels { get; set; }

    public virtual DbSet<CharFestivalReceipt> CharFestivalReceipts { get; set; }

    public virtual DbSet<CharImprisonment> CharImprisonments { get; set; }

    public virtual DbSet<CharInstanceWorldDatum> CharInstanceWorldData { get; set; }

    public virtual DbSet<CharNameList> CharNameLists { get; set; }

    public virtual DbSet<CharNewTrade> CharNewTrades { get; set; }

    public virtual DbSet<CharNickNameList> CharNickNameLists { get; set; }

    public virtual DbSet<CharQuest> CharQuests { get; set; }

    public virtual DbSet<CharSkill> CharSkills { get; set; }

    public virtual DbSet<CharSkillMastery> CharSkillMasteries { get; set; }

    public virtual DbSet<CharSupportItemByLevel> CharSupportItemByLevels { get; set; }

    public virtual DbSet<CharTeleport> CharTeleports { get; set; }

    public virtual DbSet<CharTitle> CharTitles { get; set; }

    public virtual DbSet<CharTradeConflictJob> CharTradeConflictJobs { get; set; }

    public virtual DbSet<CharTradeConflictJobKill> CharTradeConflictJobKills { get; set; }

    public virtual DbSet<CharTrijob> CharTrijobs { get; set; }

    public virtual DbSet<CharTrijobSafeTrade> CharTrijobSafeTrades { get; set; }

    public virtual DbSet<CharUniqueKill> CharUniqueKills { get; set; }

    public virtual DbSet<Chest> Chests { get; set; }

    public virtual DbSet<ChestInfo> ChestInfos { get; set; }

    public virtual DbSet<ClientConfig> ClientConfigs { get; set; }

    public virtual DbSet<ConsignmentTradeInvest> ConsignmentTradeInvests { get; set; }

    public virtual DbSet<ConsignmentTradeProgress> ConsignmentTradeProgresses { get; set; }

    public virtual DbSet<ContentConfig> ContentConfigs { get; set; }

    public virtual DbSet<ContentConfigCopy1> ContentConfigCopy1s { get; set; }

    public virtual DbSet<CraftedMacroUser> CraftedMacroUsers { get; set; }

    public virtual DbSet<CrestInitFlag> CrestInitFlags { get; set; }

    public virtual DbSet<DelItemNRewardList> DelItemNRewardLists { get; set; }

    public virtual DbSet<DeleteEventItemList> DeleteEventItemLists { get; set; }

    public virtual DbSet<DeleteItemChestLog> DeleteItemChestLogs { get; set; }

    public virtual DbSet<DeletedChar> DeletedChars { get; set; }

    public virtual DbSet<DropItem> DropItems { get; set; }

    public virtual DbSet<ESuppliedJidlist080321> ESuppliedJidlist080321s { get; set; }

    public virtual DbSet<EntryTicketCandidatesList> EntryTicketCandidatesLists { get; set; }

    public virtual DbSet<EntryTicketDrawingList> EntryTicketDrawingLists { get; set; }

    public virtual DbSet<EntryTicketWinnerList> EntryTicketWinnerLists { get; set; }

    public virtual DbSet<EquipErrorCo> EquipErrorCos { get; set; }

    public virtual DbSet<EquipInvCo> EquipInvCos { get; set; }

    public virtual DbSet<EventBuffReceipt> EventBuffReceipts { get; set; }

    public virtual DbSet<EventForgottenWorld> EventForgottenWorlds { get; set; }

    public virtual DbSet<EventHiSilkRoadPrizeList> EventHiSilkRoadPrizeLists { get; set; }

    public virtual DbSet<EventRamadanVoucher> EventRamadanVouchers { get; set; }

    public virtual DbSet<EventSupportHighLevelUser> EventSupportHighLevelUsers { get; set; }

    public virtual DbSet<EventSurvivalReward> EventSurvivalRewards { get; set; }

    public virtual DbSet<EventTicketParticipant> EventTicketParticipants { get; set; }

    public virtual DbSet<Eventnpccount> Eventnpccounts { get; set; }

    public virtual DbSet<ExchangeItemPaymentDatum> ExchangeItemPaymentData { get; set; }

    public virtual DbSet<ExploitLog> ExploitLogs { get; set; }

    public virtual DbSet<FatigueForShard> FatigueForShards { get; set; }

    public virtual DbSet<FlagWorldCoinRewardLog> FlagWorldCoinRewardLogs { get; set; }

    public virtual DbSet<FlagWorldEventParticipant> FlagWorldEventParticipants { get; set; }

    public virtual DbSet<FleaMarketNetwork> FleaMarketNetworks { get; set; }

    public virtual DbSet<FortressTemp> FortressTemps { get; set; }

    public virtual DbSet<FreeAccessBanLvl> FreeAccessBanLvls { get; set; }

    public virtual DbSet<Friend> Friends { get; set; }

    public virtual DbSet<FriendGroup> FriendGroups { get; set; }

    public virtual DbSet<GoldTrace> GoldTraces { get; set; }

    public virtual DbSet<GoldTrace1> GoldTraces1 { get; set; }

    public virtual DbSet<Gphistory> Gphistories { get; set; }

    public virtual DbSet<Guild> Guilds { get; set; }

    public virtual DbSet<GuildChest> GuildChests { get; set; }

    public virtual DbSet<GuildCrest> GuildCrests { get; set; }

    public virtual DbSet<GuildLogGuildChest> GuildLogGuildChests { get; set; }

    public virtual DbSet<GuildLogGuildMain> GuildLogGuildMains { get; set; }

    public virtual DbSet<GuildLogGuildPoint> GuildLogGuildPoints { get; set; }

    public virtual DbSet<GuildMember> GuildMembers { get; set; }

    public virtual DbSet<GuildWar> GuildWars { get; set; }

    public virtual DbSet<InvCo> InvCos { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<InventoryForAvatar> InventoryForAvatars { get; set; }

    public virtual DbSet<InventoryForLinkedStorage> InventoryForLinkedStorages { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<ItemPool> ItemPools { get; set; }

    public virtual DbSet<ItemQuotation> ItemQuotations { get; set; }

    public virtual DbSet<KeepDelCharName> KeepDelCharNames { get; set; }

    public virtual DbSet<LastestOpenMarketPesnalId> LastestOpenMarketPesnalIds { get; set; }

    public virtual DbSet<LatestItemSerial> LatestItemSerials { get; set; }

    public virtual DbSet<LogDelItemNRewardAmount> LogDelItemNRewardAmounts { get; set; }

    public virtual DbSet<LogEventGold> LogEventGolds { get; set; }

    public virtual DbSet<LogEventGoldInfo> LogEventGoldInfos { get; set; }

    public virtual DbSet<LogEventGoldNew> LogEventGoldNews { get; set; }

    public virtual DbSet<LogEventItem1Tt> LogEventItem1Tts { get; set; }

    public virtual DbSet<LogEventLevelRigid> LogEventLevelRigids { get; set; }

    public virtual DbSet<LogEventPaymentItemOccupySiegefortress> LogEventPaymentItemOccupySiegefortresses { get; set; }

    public virtual DbSet<LogEventPaymentItemOccupySiegefortressTemp> LogEventPaymentItemOccupySiegefortressTemps { get; set; }

    public virtual DbSet<LogRepairListReward3jobRelatedItem> LogRepairListReward3jobRelatedItems { get; set; }

    public virtual DbSet<LogResultRewardSilk> LogResultRewardSilks { get; set; }

    public virtual DbSet<LogSeekNDestroyItemFast> LogSeekNDestroyItemFasts { get; set; }

    public virtual DbSet<Memo> Memos { get; set; }

    public virtual DbSet<MemoBlock> MemoBlocks { get; set; }

    public virtual DbSet<Notice> Notices { get; set; }

    public virtual DbSet<NoticeDetail> NoticeDetails { get; set; }

    public virtual DbSet<OffsetItemUpgradeNreinforceRatio> OffsetItemUpgradeNreinforceRatios { get; set; }

    public virtual DbSet<OffsetItemUpgradeNreinforceRatioBackup> OffsetItemUpgradeNreinforceRatioBackups { get; set; }

    public virtual DbSet<OldTrijob> OldTrijobs { get; set; }

    public virtual DbSet<OpenMarket> OpenMarkets { get; set; }

    public virtual DbSet<OrphanItem> OrphanItems { get; set; }

    public virtual DbSet<PathPositionRememberPathPatrol> PathPositionRememberPathPatrols { get; set; }

    public virtual DbSet<PreoccupancyName> PreoccupancyNames { get; set; }

    public virtual DbSet<RankingForChar> RankingForChars { get; set; }

    public virtual DbSet<RankingForGold> RankingForGolds { get; set; }

    public virtual DbSet<RankingForGuild> RankingForGuilds { get; set; }

    public virtual DbSet<RankingForLevel> RankingForLevels { get; set; }

    public virtual DbSet<RefAbilityByItemOptLevel> RefAbilityByItemOptLevels { get; set; }

    public virtual DbSet<RefAccessPermissionOfShop> RefAccessPermissionOfShops { get; set; }

    public virtual DbSet<RefAchievement> RefAchievements { get; set; }

    public virtual DbSet<RefAchievementCondition> RefAchievementConditions { get; set; }

    public virtual DbSet<RefAchievementConditionItem> RefAchievementConditionItems { get; set; }

    public virtual DbSet<RefAchievementConditionLevel> RefAchievementConditionLevels { get; set; }

    public virtual DbSet<RefAchievementConditionMonster> RefAchievementConditionMonsters { get; set; }

    public virtual DbSet<RefAchievementRewardTitle> RefAchievementRewardTitles { get; set; }

    public virtual DbSet<RefAlchemyCorrection> RefAlchemyCorrections { get; set; }

    public virtual DbSet<RefAlchemyMerit> RefAlchemyMerits { get; set; }

    public virtual DbSet<RefAlchemyMkMaterialGroup> RefAlchemyMkMaterialGroups { get; set; }

    public virtual DbSet<RefAlchemyMkRecipe> RefAlchemyMkRecipes { get; set; }

    public virtual DbSet<RefAlchemyMkResultGroup> RefAlchemyMkResultGroups { get; set; }

    public virtual DbSet<RefAlchemyMkShop> RefAlchemyMkShops { get; set; }

    public virtual DbSet<RefAlchemyMkToolTip> RefAlchemyMkToolTips { get; set; }

    public virtual DbSet<RefAlchemyMkUi> RefAlchemyMkUis { get; set; }

    public virtual DbSet<RefCartCosInfo> RefCartCosInfos { get; set; }

    public virtual DbSet<RefCharDefaultQuest> RefCharDefaultQuests { get; set; }

    public virtual DbSet<RefCharDefaultSkill> RefCharDefaultSkills { get; set; }

    public virtual DbSet<RefCharDefaultSkillMastery> RefCharDefaultSkillMasteries { get; set; }

    public virtual DbSet<RefCharGen> RefCharGens { get; set; }

    public virtual DbSet<RefClassUpgradeEquipItem> RefClassUpgradeEquipItems { get; set; }

    public virtual DbSet<RefClimate> RefClimates { get; set; }

    public virtual DbSet<RefClimateSnowflake> RefClimateSnowflakes { get; set; }

    public virtual DbSet<RefCollectionBookItem> RefCollectionBookItems { get; set; }

    public virtual DbSet<RefCollectionBookTheme> RefCollectionBookThemes { get; set; }

    public virtual DbSet<RefConditionToBuyScrapItem> RefConditionToBuyScrapItems { get; set; }

    public virtual DbSet<RefConditionToSellPackageItem> RefConditionToSellPackageItems { get; set; }

    public virtual DbSet<RefConditionToSellScrapItem> RefConditionToSellScrapItems { get; set; }

    public virtual DbSet<RefCustomizingReservedItemDropForMonster> RefCustomizingReservedItemDropForMonsters { get; set; }

    public virtual DbSet<RefDropClassSelAlchemyAttrstone> RefDropClassSelAlchemyAttrstones { get; set; }

    public virtual DbSet<RefDropClassSelAlchemyEnhancer> RefDropClassSelAlchemyEnhancers { get; set; }

    public virtual DbSet<RefDropClassSelAlchemyMagicStone> RefDropClassSelAlchemyMagicStones { get; set; }

    public virtual DbSet<RefDropClassSelAlchemyTablet> RefDropClassSelAlchemyTablets { get; set; }

    public virtual DbSet<RefDropClassSelAlchemyUpgradeStone> RefDropClassSelAlchemyUpgradeStones { get; set; }

    public virtual DbSet<RefDropClassSelAmmo> RefDropClassSelAmmos { get; set; }

    public virtual DbSet<RefDropClassSelCoin> RefDropClassSelCoins { get; set; }

    public virtual DbSet<RefDropClassSelCosequip> RefDropClassSelCosequips { get; set; }

    public virtual DbSet<RefDropClassSelCosmagicStone> RefDropClassSelCosmagicStones { get; set; }

    public virtual DbSet<RefDropClassSelCospotion> RefDropClassSelCospotions { get; set; }

    public virtual DbSet<RefDropClassSelCosskill> RefDropClassSelCosskills { get; set; }

    public virtual DbSet<RefDropClassSelCosskillRemove> RefDropClassSelCosskillRemoves { get; set; }

    public virtual DbSet<RefDropClassSelCure> RefDropClassSelCures { get; set; }

    public virtual DbSet<RefDropClassSelEquip> RefDropClassSelEquips { get; set; }

    public virtual DbSet<RefDropClassSelLimitReinforce> RefDropClassSelLimitReinforces { get; set; }

    public virtual DbSet<RefDropClassSelNewCure> RefDropClassSelNewCures { get; set; }

    public virtual DbSet<RefDropClassSelRareEquip> RefDropClassSelRareEquips { get; set; }

    public virtual DbSet<RefDropClassSelRecover> RefDropClassSelRecovers { get; set; }

    public virtual DbSet<RefDropClassSelReinforce> RefDropClassSelReinforces { get; set; }

    public virtual DbSet<RefDropClassSelScroll> RefDropClassSelScrolls { get; set; }

    public virtual DbSet<RefDropClassSelSpecialty> RefDropClassSelSpecialties { get; set; }

    public virtual DbSet<RefDropGold> RefDropGolds { get; set; }

    public virtual DbSet<RefDropItemAssign> RefDropItemAssigns { get; set; }

    public virtual DbSet<RefDropItemGroup> RefDropItemGroups { get; set; }

    public virtual DbSet<RefDropOptLvlSel> RefDropOptLvlSels { get; set; }

    public virtual DbSet<RefDummySlot> RefDummySlots { get; set; }

    public virtual DbSet<RefEntryTicket> RefEntryTickets { get; set; }

    public virtual DbSet<RefEntryTicketSchedule> RefEntryTicketSchedules { get; set; }

    public virtual DbSet<RefEquipItemPenalty> RefEquipItemPenalties { get; set; }

    public virtual DbSet<RefEquipItemPenaltyBalance> RefEquipItemPenaltyBalances { get; set; }

    public virtual DbSet<RefEvent> RefEvents { get; set; }

    public virtual DbSet<RefEventFestivalReward> RefEventFestivalRewards { get; set; }

    public virtual DbSet<RefEventMonsterSpawn> RefEventMonsterSpawns { get; set; }

    public virtual DbSet<RefEventReward> RefEventRewards { get; set; }

    public virtual DbSet<RefEventRewardItem> RefEventRewardItems { get; set; }

    public virtual DbSet<RefEventZone> RefEventZones { get; set; }

    public virtual DbSet<RefExtraAbilityByEquipItemOptLevel> RefExtraAbilityByEquipItemOptLevels { get; set; }

    public virtual DbSet<RefFmnCategoryTree> RefFmnCategoryTrees { get; set; }

    public virtual DbSet<RefFmnTidGroup> RefFmnTidGroups { get; set; }

    public virtual DbSet<RefFmnTidGroupMap> RefFmnTidGroupMaps { get; set; }

    public virtual DbSet<RefFreeAvatar> RefFreeAvatars { get; set; }

    public virtual DbSet<RefFreeFellow> RefFreeFellows { get; set; }

    public virtual DbSet<RefGachaCode> RefGachaCodes { get; set; }

    public virtual DbSet<RefGachaItemSet> RefGachaItemSets { get; set; }

    public virtual DbSet<RefGachaNpcMap> RefGachaNpcMaps { get; set; }

    public virtual DbSet<RefGachaTreeForClientUi> RefGachaTreeForClientUis { get; set; }

    public virtual DbSet<RefGameWorld> RefGameWorlds { get; set; }

    public virtual DbSet<RefGameWorldBindGameWorldGroup> RefGameWorldBindGameWorldGroups { get; set; }

    public virtual DbSet<RefGameWorldBindTriggerCategory> RefGameWorldBindTriggerCategories { get; set; }

    public virtual DbSet<RefGameWorldConfig> RefGameWorldConfigs { get; set; }

    public virtual DbSet<RefGameWorldGroup> RefGameWorldGroups { get; set; }

    public virtual DbSet<RefGameWorldGroupConfig> RefGameWorldGroupConfigs { get; set; }

    public virtual DbSet<RefGameWorldNpc> RefGameWorldNpcs { get; set; }

    public virtual DbSet<RefGiftExchangeCoupon> RefGiftExchangeCoupons { get; set; }

    public virtual DbSet<RefGiftExchangeItem> RefGiftExchangeItems { get; set; }

    public virtual DbSet<RefHwanlevel> RefHwanlevels { get; set; }

    public virtual DbSet<RefInstanceWorldRegion> RefInstanceWorldRegions { get; set; }

    public virtual DbSet<RefInstanceWorldStartPo> RefInstanceWorldStartPos { get; set; }

    public virtual DbSet<RefItemUpgradeNreinforceRatio> RefItemUpgradeNreinforceRatios { get; set; }

    public virtual DbSet<RefLearnRecipeByReqType> RefLearnRecipeByReqTypes { get; set; }

    public virtual DbSet<RefLevel> RefLevels { get; set; }

    public virtual DbSet<RefMagicOpt> RefMagicOpts { get; set; }

    public virtual DbSet<RefMagicOptAssign> RefMagicOptAssigns { get; set; }

    public virtual DbSet<RefMagicOptAssignForTradeEquip> RefMagicOptAssignForTradeEquips { get; set; }

    public virtual DbSet<RefMagicOptByItemOptLevel> RefMagicOptByItemOptLevels { get; set; }

    public virtual DbSet<RefMagicOptByTitle> RefMagicOptByTitles { get; set; }

    public virtual DbSet<RefMagicOptGroup> RefMagicOptGroups { get; set; }

    public virtual DbSet<RefMappingAlchemyMkShopWithNpc> RefMappingAlchemyMkShopWithNpcs { get; set; }

    public virtual DbSet<RefMappingShopGroup> RefMappingShopGroups { get; set; }

    public virtual DbSet<RefMappingShopWithTab> RefMappingShopWithTabs { get; set; }

    public virtual DbSet<RefMonsterAssignedItemDrop> RefMonsterAssignedItemDrops { get; set; }

    public virtual DbSet<RefMonsterAssignedItemRndDrop> RefMonsterAssignedItemRndDrops { get; set; }

    public virtual DbSet<RefMuhanMonsterTransMask> RefMuhanMonsterTransMasks { get; set; }

    public virtual DbSet<RefMuhanMonsterWave> RefMuhanMonsterWaves { get; set; }

    public virtual DbSet<RefNewTradeRewardItem> RefNewTradeRewardItems { get; set; }

    public virtual DbSet<RefNewTradeRewardRatio> RefNewTradeRewardRatios { get; set; }

    public virtual DbSet<RefNonSplitItem> RefNonSplitItems { get; set; }

    public virtual DbSet<RefObjChar> RefObjChars { get; set; }

    public virtual DbSet<RefObjCharExtraSkill> RefObjCharExtraSkills { get; set; }

    public virtual DbSet<RefObjCharGrow> RefObjCharGrows { get; set; }

    public virtual DbSet<RefObjCommon> RefObjCommons { get; set; }

    public virtual DbSet<RefObjItem> RefObjItems { get; set; }

    public virtual DbSet<RefObjStruct> RefObjStructs { get; set; }

    public virtual DbSet<RefOptionalTeleport> RefOptionalTeleports { get; set; }

    public virtual DbSet<RefPackageItem> RefPackageItems { get; set; }

    public virtual DbSet<RefPath> RefPaths { get; set; }

    public virtual DbSet<RefPathConfigType> RefPathConfigTypes { get; set; }

    public virtual DbSet<RefPathConst> RefPathConsts { get; set; }

    public virtual DbSet<RefPathFlock> RefPathFlocks { get; set; }

    public virtual DbSet<RefPathFlockMember> RefPathFlockMembers { get; set; }

    public virtual DbSet<RefPathPosition> RefPathPositions { get; set; }

    public virtual DbSet<RefPathPositionConfig> RefPathPositionConfigs { get; set; }

    public virtual DbSet<RefPathPositionConfigGroup> RefPathPositionConfigGroups { get; set; }

    public virtual DbSet<RefPricePolicyOfItem> RefPricePolicyOfItems { get; set; }

    public virtual DbSet<RefQuest> RefQuests { get; set; }

    public virtual DbSet<RefQuestReward> RefQuestRewards { get; set; }

    public virtual DbSet<RefQuestRewardGrade> RefQuestRewardGrades { get; set; }

    public virtual DbSet<RefQuestRewardItem> RefQuestRewardItems { get; set; }

    public virtual DbSet<RefRegion> RefRegions { get; set; }

    public virtual DbSet<RefRegionBindAssocServer> RefRegionBindAssocServers { get; set; }

    public virtual DbSet<RefRegionBindAssocServerCopy> RefRegionBindAssocServerCopies { get; set; }

    public virtual DbSet<RefRegionBindAssocServerCopy1> RefRegionBindAssocServerCopy1s { get; set; }

    public virtual DbSet<RefRegionBindAssocServerCopy2> RefRegionBindAssocServerCopy2s { get; set; }

    public virtual DbSet<RefRegionBindAssocServerCopy3> RefRegionBindAssocServerCopy3s { get; set; }

    public virtual DbSet<RefRegionBindAssocServerCopy4> RefRegionBindAssocServerCopy4s { get; set; }

    public virtual DbSet<RefRegionBindAssocServerCopy5> RefRegionBindAssocServerCopy5s { get; set; }

    public virtual DbSet<RefRegionBindAssocServerCopy6Live> RefRegionBindAssocServerCopy6Lives { get; set; }

    public virtual DbSet<RefRegionBindAssocServerMycenae> RefRegionBindAssocServerMycenaes { get; set; }

    public virtual DbSet<RefRegionBindAssocServerRigid> RefRegionBindAssocServerRigids { get; set; }

    public virtual DbSet<RefRegionBindOptionalFunction> RefRegionBindOptionalFunctions { get; set; }

    public virtual DbSet<RefRegionEnterCheckLevel> RefRegionEnterCheckLevels { get; set; }

    public virtual DbSet<RefRegionRigid> RefRegionRigids { get; set; }

    public virtual DbSet<RefReinforceLimitDegree> RefReinforceLimitDegrees { get; set; }

    public virtual DbSet<RefRentItem> RefRentItems { get; set; }

    public virtual DbSet<RefRewardPackageItem> RefRewardPackageItems { get; set; }

    public virtual DbSet<RefRewardPolicyToBuyScrapItem> RefRewardPolicyToBuyScrapItems { get; set; }

    public virtual DbSet<RefRewardPolicyToSellPackageItem> RefRewardPolicyToSellPackageItems { get; set; }

    public virtual DbSet<RefRewardPolicyToSellScrapItem> RefRewardPolicyToSellScrapItems { get; set; }

    public virtual DbSet<RefRndMagicOpt> RefRndMagicOpts { get; set; }

    public virtual DbSet<RefRndMagicOptNumRatio> RefRndMagicOptNumRatios { get; set; }

    public virtual DbSet<RefRollBook> RefRollBooks { get; set; }

    public virtual DbSet<RefRollBookPayItemList> RefRollBookPayItemLists { get; set; }

    public virtual DbSet<RefScheduleDefine> RefScheduleDefines { get; set; }

    public virtual DbSet<RefScrapOfPackageItem> RefScrapOfPackageItems { get; set; }

    public virtual DbSet<RefServerEvent> RefServerEvents { get; set; }

    public virtual DbSet<RefServerEventReward> RefServerEventRewards { get; set; }

    public virtual DbSet<RefServerEventRewardExpUpforPlayer> RefServerEventRewardExpUpforPlayers { get; set; }

    public virtual DbSet<RefServerEventRewardSpawnMonster> RefServerEventRewardSpawnMonsters { get; set; }

    public virtual DbSet<RefSetItemGroup> RefSetItemGroups { get; set; }

    public virtual DbSet<RefShardContentConfig> RefShardContentConfigs { get; set; }

    public virtual DbSet<RefShop> RefShops { get; set; }

    public virtual DbSet<RefShopGood> RefShopGoods { get; set; }

    public virtual DbSet<RefShopGroup> RefShopGroups { get; set; }

    public virtual DbSet<RefShopItemGroup> RefShopItemGroups { get; set; }

    public virtual DbSet<RefShopItemStockPeriod> RefShopItemStockPeriods { get; set; }

    public virtual DbSet<RefShopObject> RefShopObjects { get; set; }

    public virtual DbSet<RefShopTab> RefShopTabs { get; set; }

    public virtual DbSet<RefShopTabGroup> RefShopTabGroups { get; set; }

    public virtual DbSet<RefSiegeBlessBuff> RefSiegeBlessBuffs { get; set; }

    public virtual DbSet<RefSiegeDungeon> RefSiegeDungeons { get; set; }

    public virtual DbSet<RefSiegeFortress> RefSiegeFortresses { get; set; }

    public virtual DbSet<RefSiegeFortressBattleRank> RefSiegeFortressBattleRanks { get; set; }

    public virtual DbSet<RefSiegeFortressGuard> RefSiegeFortressGuards { get; set; }

    public virtual DbSet<RefSiegeFortressItemForge> RefSiegeFortressItemForges { get; set; }

    public virtual DbSet<RefSiegeFortressReward> RefSiegeFortressRewards { get; set; }

    public virtual DbSet<RefSiegeLvlSummonMonster> RefSiegeLvlSummonMonsters { get; set; }

    public virtual DbSet<RefSiegeQuest> RefSiegeQuests { get; set; }

    public virtual DbSet<RefSiegeQuestReward> RefSiegeQuestRewards { get; set; }

    public virtual DbSet<RefSiegeStructUpgrade> RefSiegeStructUpgrades { get; set; }

    public virtual DbSet<RefSkill> RefSkills { get; set; }

    public virtual DbSet<RefSkillByItemOptLevel> RefSkillByItemOptLevels { get; set; }

    public virtual DbSet<RefSkillGroup> RefSkillGroups { get; set; }

    public virtual DbSet<RefSkillMastery> RefSkillMasteries { get; set; }

    public virtual DbSet<RefSroMacro> RefSroMacros { get; set; }

    public virtual DbSet<RefSupportItemByLevel> RefSupportItemByLevels { get; set; }

    public virtual DbSet<RefSurvivalPvPoption> RefSurvivalPvPoptions { get; set; }

    public virtual DbSet<RefSurvivalPvpbalance> RefSurvivalPvpbalances { get; set; }

    public virtual DbSet<RefSurvivalPvpreward> RefSurvivalPvprewards { get; set; }

    public virtual DbSet<RefTeleLink> RefTeleLinks { get; set; }

    public virtual DbSet<RefTeleport> RefTeleports { get; set; }

    public virtual DbSet<RefTitle> RefTitles { get; set; }

    public virtual DbSet<RefTradeConflictClass> RefTradeConflictClasses { get; set; }

    public virtual DbSet<RefTradeConflictJobLevel> RefTradeConflictJobLevels { get; set; }

    public virtual DbSet<RefTradeConflictPromotionReq> RefTradeConflictPromotionReqs { get; set; }

    public virtual DbSet<RefTradeConflictReputationPoint> RefTradeConflictReputationPoints { get; set; }

    public virtual DbSet<RefTreatItemOfShop> RefTreatItemOfShops { get; set; }

    public virtual DbSet<RefTrigger> RefTriggers { get; set; }

    public virtual DbSet<RefTriggerAction> RefTriggerActions { get; set; }

    public virtual DbSet<RefTriggerActionParam> RefTriggerActionParams { get; set; }

    public virtual DbSet<RefTriggerBindAction> RefTriggerBindActions { get; set; }

    public virtual DbSet<RefTriggerBindCondition> RefTriggerBindConditions { get; set; }

    public virtual DbSet<RefTriggerBindEvent> RefTriggerBindEvents { get; set; }

    public virtual DbSet<RefTriggerCategory> RefTriggerCategories { get; set; }

    public virtual DbSet<RefTriggerCategoryBindTrigger> RefTriggerCategoryBindTriggers { get; set; }

    public virtual DbSet<RefTriggerCommon> RefTriggerCommons { get; set; }

    public virtual DbSet<RefTriggerCondition> RefTriggerConditions { get; set; }

    public virtual DbSet<RefTriggerConditionParam> RefTriggerConditionParams { get; set; }

    public virtual DbSet<RefTriggerEvent> RefTriggerEvents { get; set; }

    public virtual DbSet<RefTriggerVariable> RefTriggerVariables { get; set; }

    public virtual DbSet<RefUistringMt> RefUistringMts { get; set; }

    public virtual DbSet<RefUpgradeEquipItem> RefUpgradeEquipItems { get; set; }

    public virtual DbSet<RenameLogChar> RenameLogChars { get; set; }

    public virtual DbSet<RenameLogGuild> RenameLogGuilds { get; set; }

    public virtual DbSet<RentItemInfo> RentItemInfos { get; set; }

    public virtual DbSet<RentItemRepairedLog> RentItemRepairedLogs { get; set; }

    public virtual DbSet<ResultOfPackageItemToMappingWithServerSide> ResultOfPackageItemToMappingWithServerSides { get; set; }

    public virtual DbSet<RollBookUserEventDatum> RollBookUserEventData { get; set; }

    public virtual DbSet<RollBookUserRollDatum> RollBookUserRollData { get; set; }

    public virtual DbSet<SCopy> SCopies { get; set; }

    public virtual DbSet<SCopy2> SCopy2s { get; set; }

    public virtual DbSet<SKpiSalesRawDatum> SKpiSalesRawData { get; set; }

    public virtual DbSet<SUnUsedItems0812> SUnUsedItems0812s { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<ScheduleCopy1> ScheduleCopy1s { get; set; }

    public virtual DbSet<ServerEvent> ServerEvents { get; set; }

    public virtual DbSet<ServerEventReward> ServerEventRewards { get; set; }

    public virtual DbSet<ServerGoldStatistic> ServerGoldStatistics { get; set; }

    public virtual DbSet<ShardDbinfo> ShardDbinfos { get; set; }

    public virtual DbSet<ShopItemStockQuantity> ShopItemStockQuantities { get; set; }

    public virtual DbSet<ShuffleExploiter> ShuffleExploiters { get; set; }

    public virtual DbSet<ShuffleExploitersBackup> ShuffleExploitersBackups { get; set; }

    public virtual DbSet<ShuffleExploitersBak090804> ShuffleExploitersBak090804s { get; set; }

    public virtual DbSet<ShuffleExploitersByIp> ShuffleExploitersByIps { get; set; }

    public virtual DbSet<ShuffleExploitersByIpBak090804> ShuffleExploitersByIpBak090804s { get; set; }

    public virtual DbSet<SiegeFortress> SiegeFortresses { get; set; }

    public virtual DbSet<SiegeFortressBattleRecord> SiegeFortressBattleRecords { get; set; }

    public virtual DbSet<SiegeFortressItemForge> SiegeFortressItemForges { get; set; }

    public virtual DbSet<SiegeFortressObject> SiegeFortressObjects { get; set; }

    public virtual DbSet<SiegeFortressOccupyReward> SiegeFortressOccupyRewards { get; set; }

    public virtual DbSet<SiegeFortressRequest> SiegeFortressRequests { get; set; }

    public virtual DbSet<SiegeFortressStoneState> SiegeFortressStoneStates { get; set; }

    public virtual DbSet<SiegeFortressStruct> SiegeFortressStructs { get; set; }

    public virtual DbSet<SilkItemRepairedLog> SilkItemRepairedLogs { get; set; }

    public virtual DbSet<SkSilk> SkSilks { get; set; }

    public virtual DbSet<SroMacroConfigHunting> SroMacroConfigHuntings { get; set; }

    public virtual DbSet<SroMacroConfigHuntingCopy1> SroMacroConfigHuntingCopy1s { get; set; }

    public virtual DbSet<SroMacroConfigPotion> SroMacroConfigPotions { get; set; }

    public virtual DbSet<SroMacroConfigPotionCopy1> SroMacroConfigPotionCopy1s { get; set; }

    public virtual DbSet<SroMacroConfigSkill> SroMacroConfigSkills { get; set; }

    public virtual DbSet<SroMacroConfigSkillCopy1> SroMacroConfigSkillCopy1s { get; set; }

    public virtual DbSet<StaticAvatar> StaticAvatars { get; set; }

    public virtual DbSet<StatisticsAbnormalChar> StatisticsAbnormalChars { get; set; }

    public virtual DbSet<StatisticsCharLastLogout> StatisticsCharLastLogouts { get; set; }

    public virtual DbSet<StatisticsGacha> StatisticsGachas { get; set; }

    public virtual DbSet<StatisticsGachaByChanneling> StatisticsGachaByChannelings { get; set; }

    public virtual DbSet<StatisticsItemsAboveOpt8> StatisticsItemsAboveOpt8s { get; set; }

    public virtual DbSet<StatisticsItemsCountInMall> StatisticsItemsCountInMalls { get; set; }

    public virtual DbSet<StatisticsItemsGradeOptLevelRare> StatisticsItemsGradeOptLevelRares { get; set; }

    public virtual DbSet<StatisticsItemsGradeOptLvRareMagOpt> StatisticsItemsGradeOptLvRareMagOpts { get; set; }

    public virtual DbSet<StatisticsItemsOptLevel> StatisticsItemsOptLevels { get; set; }

    public virtual DbSet<StatisticsPerformanceLog> StatisticsPerformanceLogs { get; set; }

    public virtual DbSet<StatisticsPetCount> StatisticsPetCounts { get; set; }

    public virtual DbSet<StatisticsRentItem> StatisticsRentItems { get; set; }

    public virtual DbSet<StatisticsSystemExchageCoupon> StatisticsSystemExchageCoupons { get; set; }

    public virtual DbSet<SupportGoldConfig> SupportGoldConfigs { get; set; }

    public virtual DbSet<SurvivalPvphallOfFameLastSurviving> SurvivalPvphallOfFameLastSurvivings { get; set; }

    public virtual DbSet<SurvivalPvphallOfFamePartyMatching> SurvivalPvphallOfFamePartyMatchings { get; set; }

    public virtual DbSet<SurvivalPvprecordLastSurviving> SurvivalPvprecordLastSurvivings { get; set; }

    public virtual DbSet<SurvivalPvprecordLastSurvivingForReward> SurvivalPvprecordLastSurvivingForRewards { get; set; }

    public virtual DbSet<SurvivalPvprecordPartyMatching> SurvivalPvprecordPartyMatchings { get; set; }

    public virtual DbSet<SurvivalPvprecordPartyMatchingForReward> SurvivalPvprecordPartyMatchingForRewards { get; set; }

    public virtual DbSet<SurvivalPvpseason> SurvivalPvpseasons { get; set; }

    public virtual DbSet<TabDbsafeCheckState> TabDbsafeCheckStates { get; set; }

    public virtual DbSet<TabRefAiskill> TabRefAiskills { get; set; }

    public virtual DbSet<TabRefHive> TabRefHives { get; set; }

    public virtual DbSet<TabRefNest> TabRefNests { get; set; }

    public virtual DbSet<TabRefRankingHunterActivity> TabRefRankingHunterActivities { get; set; }

    public virtual DbSet<TabRefRankingHunterContribution> TabRefRankingHunterContributions { get; set; }

    public virtual DbSet<TabRefRankingRobberActivity> TabRefRankingRobberActivities { get; set; }

    public virtual DbSet<TabRefRankingRobberContribution> TabRefRankingRobberContributions { get; set; }

    public virtual DbSet<TabRefRankingTraderActivity> TabRefRankingTraderActivities { get; set; }

    public virtual DbSet<TabRefRankingTraderContribution> TabRefRankingTraderContributions { get; set; }

    public virtual DbSet<TabRefSpawnToolVersion> TabRefSpawnToolVersions { get; set; }

    public virtual DbSet<TabRefTactic> TabRefTactics { get; set; }

    public virtual DbSet<TabRefTacticsOld> TabRefTacticsOlds { get; set; }

    public virtual DbSet<TargetInventoryItem> TargetInventoryItems { get; set; }

    public virtual DbSet<Temp100lvChar0309> Temp100lvChar0309s { get; set; }

    public virtual DbSet<Temp13thEquipOptlevel8Over> Temp13thEquipOptlevel8Overs { get; set; }

    public virtual DbSet<Temp13thEquipOptlevel8OverLog> Temp13thEquipOptlevel8OverLogs { get; set; }

    public virtual DbSet<Temp13thEquipOptlevel8OverTemp> Temp13thEquipOptlevel8OverTemps { get; set; }

    public virtual DbSet<Temp13thEquipUpgradeList> Temp13thEquipUpgradeLists { get; set; }

    public virtual DbSet<TempAdditemexternChestLog> TempAdditemexternChestLogs { get; set; }

    public virtual DbSet<TempAdditemexternChestLogTmp> TempAdditemexternChestLogTmps { get; set; }

    public virtual DbSet<TempAdditemexternLog> TempAdditemexternLogs { get; set; }

    public virtual DbSet<TempAlliedClan> TempAlliedClans { get; set; }

    public virtual DbSet<TempCanRewardList> TempCanRewardLists { get; set; }

    public virtual DbSet<TempCannotRewardList> TempCannotRewardLists { get; set; }

    public virtual DbSet<TempChar> TempChars { get; set; }

    public virtual DbSet<TempChest> TempChests { get; set; }

    public virtual DbSet<TempDeathCharSf> TempDeathCharSfs { get; set; }

    public virtual DbSet<TempDropitem> TempDropitems { get; set; }

    public virtual DbSet<TempGachaitem> TempGachaitems { get; set; }

    public virtual DbSet<TempGuild> TempGuilds { get; set; }

    public virtual DbSet<TempGuildChest> TempGuildChests { get; set; }

    public virtual DbSet<TempInvalidEquipSlotItem> TempInvalidEquipSlotItems { get; set; }

    public virtual DbSet<TempItem> TempItems { get; set; }

    public virtual DbSet<TempItem1> TempItems1 { get; set; }

    public virtual DbSet<TempItemPay> TempItemPays { get; set; }

    public virtual DbSet<TempItemlistTimedjobRelated> TempItemlistTimedjobRelateds { get; set; }

    public virtual DbSet<TempJobLevelOverCharacter> TempJobLevelOverCharacters { get; set; }

    public virtual DbSet<TempOpt15overItem100320> TempOpt15overItem100320s { get; set; }

    public virtual DbSet<TempRemovedStaleChar> TempRemovedStaleChars { get; set; }

    public virtual DbSet<TempRewardItem> TempRewardItems { get; set; }

    public virtual DbSet<TempUserList> TempUserLists { get; set; }

    public virtual DbSet<TempUserMaxLevel> TempUserMaxLevels { get; set; }

    public virtual DbSet<TempUserRewardLog> TempUserRewardLogs { get; set; }

    public virtual DbSet<TestTable> TestTables { get; set; }

    public virtual DbSet<TimeService> TimeServices { get; set; }

    public virtual DbSet<TimedJob> TimedJobs { get; set; }

    public virtual DbSet<TimedJobCopy> TimedJobCopies { get; set; }

    public virtual DbSet<TimedJobForPet> TimedJobForPets { get; set; }

    public virtual DbSet<TimedJobForPetCopy> TimedJobForPetCopies { get; set; }

    public virtual DbSet<TraceItem> TraceItems { get; set; }

    public virtual DbSet<TradeBagInventory> TradeBagInventories { get; set; }

    public virtual DbSet<TradeEquipInventory> TradeEquipInventories { get; set; }

    public virtual DbSet<TrainingCamp> TrainingCamps { get; set; }

    public virtual DbSet<TrainingCampBuffStatus> TrainingCampBuffStatuses { get; set; }

    public virtual DbSet<TrainingCampHonorRank> TrainingCampHonorRanks { get; set; }

    public virtual DbSet<TrainingCampHonorRankUpdateDate> TrainingCampHonorRankUpdateDates { get; set; }

    public virtual DbSet<TrainingCampMember> TrainingCampMembers { get; set; }

    public virtual DbSet<TrainingCampSubMentorHonorPoint> TrainingCampSubMentorHonorPoints { get; set; }

    public virtual DbSet<TrijobRanking4Web> TrijobRanking4Webs { get; set; }

    public virtual DbSet<TrijobReward> TrijobRewards { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserFestivalScore> UserFestivalScores { get; set; }

    public virtual DbSet<UserOld> UserOlds { get; set; }

    public virtual DbSet<UserTradeConflictJob> UserTradeConflictJobs { get; set; }
    public virtual DbSet<_GameServerRefMonsterDropData> RefMonsterDropData { get; set; }

    public virtual DbSet<_20100329Buybuguser2E12g> _20100329Buybuguser2E12gs { get; set; }

    public virtual DbSet<_20100329BuybuguserLogE12g> _20100329BuybuguserLogE12gs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(DatabaseManager.SroVtShardConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Korean_Wansung_CI_AS");

        modelBuilder.Entity<AccountJid>(entity =>
        {
            entity.HasKey(e => new { e.AccountId, e.ServiceCompany });

            entity.ToTable("_AccountJID", tb => tb.HasTrigger("_AccountJID_TR_U"));

            entity.HasIndex(e => e.Jid, "IX__AccountJID").IsUnique();

            entity.Property(e => e.AccountId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Chinese_Taiwan_Stroke_CI_AS")
                .HasColumnName("AccountID");
            entity.Property(e => e.Jid).HasColumnName("JID");
        });

        modelBuilder.Entity<Achievement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Achievement_ID");

            entity.ToTable("_Achievement");

            entity.HasIndex(e => new { e.CharId, e.RefAchievementId }, "IX__Achievement_CharID_RefAchievementID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.RefAchievementId).HasColumnName("RefAchievementID");

            entity.HasOne(d => d.Char).WithMany(p => p.Achievements)
                .HasForeignKey(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Achievement_CharID_Char_CharID");
        });

        modelBuilder.Entity<AchievementCondition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AchievementCondition_ID");

            entity.ToTable("_AchievementCondition");

            entity.HasIndex(e => e.AchievementId, "IX__AchievementCondition_AchievementID").HasFillFactor(90);

            entity.HasIndex(e => e.CharId, "IX__AchievementCondition_CharID").HasFillFactor(70);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AchievementId).HasColumnName("AchievementID");
            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.RefAchievementConditionId).HasColumnName("RefAchievementConditionID");

            entity.HasOne(d => d.Achievement).WithMany(p => p.AchievementConditions)
                .HasForeignKey(d => d.AchievementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AchievementCondition_AchievementID_Achievement_ID");

            entity.HasOne(d => d.Char).WithMany(p => p.AchievementConditions)
                .HasForeignKey(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AchievementCondition_CharID_Char_CharID");
        });

        modelBuilder.Entity<ActiveUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_ActiveUser");

            entity.HasIndex(e => e.ShardId, "IX__ActiveUser");

            entity.HasIndex(e => new { e.ShardId, e.LoginMonthDay }, "IX__ActiveUser_1");

            entity.Property(e => e.CountryCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ip)
                .HasMaxLength(26)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IP");
            entity.Property(e => e.LoginTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ShardId).HasColumnName("ShardID");
            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<ActiveUser1>(entity =>
        {
            entity.HasKey(e => e.UserJid).HasName("PK___ActiveUser_1__60B04667");

            entity.ToTable("_ActiveUser_1");

            entity.Property(e => e.UserJid)
                .ValueGeneratedNever()
                .HasColumnName("UserJID");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Ip)
                .HasMaxLength(26)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("IP");
            entity.Property(e => e.LoginTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ShardId).HasColumnName("ShardID");
        });

        modelBuilder.Entity<ActiveUser2>(entity =>
        {
            entity.HasKey(e => e.UserJid).HasName("PK___ActiveUser_2__61A46AA0");

            entity.ToTable("_ActiveUser_2");

            entity.Property(e => e.UserJid)
                .ValueGeneratedNever()
                .HasColumnName("UserJID");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Ip)
                .HasMaxLength(26)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("IP");
            entity.Property(e => e.LoginTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ShardId).HasColumnName("ShardID");
        });

        modelBuilder.Entity<ActiveUser3>(entity =>
        {
            entity.HasKey(e => e.UserJid).HasName("PK___ActiveUser_3__62988ED9");

            entity.ToTable("_ActiveUser_3");

            entity.Property(e => e.UserJid)
                .ValueGeneratedNever()
                .HasColumnName("UserJID");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Ip)
                .HasMaxLength(26)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("IP");
            entity.Property(e => e.LoginTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ShardId).HasColumnName("ShardID");
        });

        modelBuilder.Entity<ActiveUser4>(entity =>
        {
            entity.HasKey(e => e.UserJid).HasName("PK___ActiveUser_4__638CB312");

            entity.ToTable("_ActiveUser_4");

            entity.Property(e => e.UserJid)
                .ValueGeneratedNever()
                .HasColumnName("UserJID");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Ip)
                .HasMaxLength(26)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("IP");
            entity.Property(e => e.LoginTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ShardId).HasColumnName("ShardID");
        });

        modelBuilder.Entity<ActiveUser5>(entity =>
        {
            entity.HasKey(e => e.UserJid).HasName("PK___ActiveUser_5__6480D74B");

            entity.ToTable("_ActiveUser_5");

            entity.Property(e => e.UserJid)
                .ValueGeneratedNever()
                .HasColumnName("UserJID");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Ip)
                .HasMaxLength(26)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("IP");
            entity.Property(e => e.LoginTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ShardId).HasColumnName("ShardID");
        });

        modelBuilder.Entity<ActiveUser6>(entity =>
        {
            entity.HasKey(e => e.UserJid).HasName("PK___ActiveUser_6__6574FB84");

            entity.ToTable("_ActiveUser_6");

            entity.Property(e => e.UserJid)
                .ValueGeneratedNever()
                .HasColumnName("UserJID");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Ip)
                .HasMaxLength(26)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("IP");
            entity.Property(e => e.LoginTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ShardId).HasColumnName("ShardID");
        });

        modelBuilder.Entity<ActiveUser7>(entity =>
        {
            entity.HasKey(e => e.UserJid).HasName("PK___ActiveUser_7__66691FBD");

            entity.ToTable("_ActiveUser_7");

            entity.Property(e => e.UserJid)
                .ValueGeneratedNever()
                .HasColumnName("UserJID");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Ip)
                .HasMaxLength(26)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("IP");
            entity.Property(e => e.LoginTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ShardId).HasColumnName("ShardID");
        });

        modelBuilder.Entity<ActiveUserRigid>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_ActiveUser_Rigid");

            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.LastLoginCharId).HasColumnName("LastLoginCharID");
            entity.Property(e => e.LastLoginTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastLogoutTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<AllInventoryItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_All_Inventory_Item");

            entity.HasIndex(e => e.Id64, "IX__All_Inventory_Item_1").HasFillFactor(80);

            entity.Property(e => e.Id64).HasColumnName("ID64");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
        });

        modelBuilder.Entity<AllItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ALL_ITEMS");

            entity.HasIndex(e => e.ItemId, "ITEMS_1").HasFillFactor(70);

            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<AllianceCrest>(entity =>
        {
            entity.HasKey(e => e.AllianceId);

            entity.ToTable("_AllianceCrest");

            entity.Property(e => e.AllianceId)
                .ValueGeneratedNever()
                .HasColumnName("AllianceID");
            entity.Property(e => e.CrestBinary)
                .HasMaxLength(256)
                .IsFixedLength();

            entity.HasOne(d => d.Alliance).WithOne(p => p.AllianceCrest)
                .HasForeignKey<AllianceCrest>(d => d.AllianceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AllianceCrest__AlliedClans");
        });

        modelBuilder.Entity<AlliedClan>(entity =>
        {
            entity.ToTable("_AlliedClans");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FoundationDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<AlliedClans8>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AlliedClans_copy1");

            entity.ToTable("_AlliedClans_8");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FoundationDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<AssociationReputation>(entity =>
        {
            entity.HasKey(e => new { e.AssociationCodeName, e.AssociationTypeName });

            entity.ToTable("_AssociationReputation");

            entity.HasIndex(e => e.AssociationCodeName, "IX__AssociationReputation_AssociationCodeName").HasFillFactor(90);

            entity.Property(e => e.AssociationCodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.AssociationTypeName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BindingOptionWithItem>(entity =>
        {
            entity.HasKey(e => new { e.NItemDbid, e.BOptType, e.NSlot });

            entity.ToTable("_BindingOptionWithItem");

            entity.Property(e => e.NItemDbid).HasColumnName("nItemDBID");
            entity.Property(e => e.BOptType).HasColumnName("bOptType");
            entity.Property(e => e.NSlot).HasColumnName("nSlot");
            entity.Property(e => e.NOptId).HasColumnName("nOptID");
            entity.Property(e => e.NOptLvl).HasColumnName("nOptLvl");
            entity.Property(e => e.NOptValue).HasColumnName("nOptValue");
            entity.Property(e => e.NParam1).HasColumnName("nParam1");
            entity.Property(e => e.NParam2).HasColumnName("nParam2");
        });

        modelBuilder.Entity<BlockedPartyInviter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_BlockedPartyInviter");

            entity.HasIndex(e => new { e.CharId, e.BlockedName }, "BP_NIDX_CID_BN").HasFillFactor(90);

            entity.Property(e => e.BlockedName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.CharId).HasColumnName("CharID");
        });

        modelBuilder.Entity<BlockedWhisperer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_BlockedWhisperers");

            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.TargetName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");

            entity.HasOne(d => d.Owner).WithMany()
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK___BlockedW__Owner__0F5626B7");
        });

        modelBuilder.Entity<BuyCashItemListByWeb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_BuyCashItemList_By_Web");

            entity.HasIndex(e => e.Jid, "IX__BuyCashItemList_By_Web_JID").IsClustered();

            entity.Property(e => e.DateBegin).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEnd).HasColumnType("smalldatetime");
            entity.Property(e => e.Idx).HasColumnName("IDX");
            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.PackageCodeName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.SubIdx).HasColumnName("SubIDX");
        });

        modelBuilder.Entity<CalcCharExpLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_CalcCharExpLog");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.CharName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RefExpC).HasColumnName("RefExp_C");
        });

        modelBuilder.Entity<Database.SILKROAD_R_SHARD.Char>(entity =>
        {
            entity.HasKey(e => e.CharId).HasName("PK__Char_1");

            entity.ToTable("_Char", tb =>
            {
                tb.HasTrigger("_Char_TR_U");
                tb.HasTrigger("_Char_TR_U_old");
            });

            entity.HasIndex(e => e.CharName16, "IX__Char").IsUnique();

            entity.HasIndex(e => e.NickName16, "IX__Char_1").HasFillFactor(90);

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.AutoInvestExp).HasDefaultValue((byte)1);
            entity.Property(e => e.CharName16)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.CurLevel).HasDefaultValue((byte)1);
            entity.Property(e => e.DailyPk).HasColumnName("DailyPK");
            entity.Property(e => e.DiedWorldId)
                .HasDefaultValue((short)1)
                .HasColumnName("DiedWorldID");
            entity.Property(e => e.GuildId)
                .HasDefaultValue(0)
                .HasColumnName("GuildID");
            entity.Property(e => e.Hp)
                .HasDefaultValue(200)
                .HasColumnName("HP");
            entity.Property(e => e.HunterExp).HasColumnName("Hunter_Exp");
            entity.Property(e => e.JobLvlHunter)
                .HasDefaultValue((byte)1)
                .HasColumnName("JobLvl_Hunter");
            entity.Property(e => e.JobLvlRobber)
                .HasDefaultValue((byte)1)
                .HasColumnName("JobLvl_Robber");
            entity.Property(e => e.JobLvlTrader)
                .HasDefaultValue((byte)1)
                .HasColumnName("JobLvl_Trader");
            entity.Property(e => e.LastLogout).HasColumnType("smalldatetime");
            entity.Property(e => e.MaxLevel).HasDefaultValue((byte)1);
            entity.Property(e => e.Mp)
                .HasDefaultValue(200)
                .HasColumnName("MP");
            entity.Property(e => e.NickName16)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasDefaultValue("")
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.PkpenaltyPoint).HasColumnName("PKPenaltyPoint");
            entity.Property(e => e.RefObjId).HasColumnName("RefObjID");
            entity.Property(e => e.RobberExp).HasColumnName("Robber_Exp");
            entity.Property(e => e.SexpOffset).HasColumnName("SExpOffset");
            entity.Property(e => e.TelWorldId)
                .HasDefaultValue((short)1)
                .HasColumnName("TelWorldID");
            entity.Property(e => e.TotalPk).HasColumnName("TotalPK");
            entity.Property(e => e.Tpp).HasColumnName("TPP");
            entity.Property(e => e.TraderExp).HasColumnName("Trader_Exp");
            entity.Property(e => e.WorldId)
                .HasDefaultValue((short)1)
                .HasColumnName("WorldID");
        });

        modelBuilder.Entity<CharAlchemyMkRecipe>(entity =>
        {
            entity.HasKey(e => new { e.CharId, e.RcId }).HasName("PK_CharAlchemy_MK_Recipe");

            entity.ToTable("_CharAlchemy_MK_Recipe");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.RcId).HasColumnName("RC_ID");

            entity.HasOne(d => d.Char).WithMany(p => p.CharAlchemyMkRecipes)
                .HasForeignKey(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CharAlchemy_MK_Recipe");
        });

        modelBuilder.Entity<CharCo>(entity =>
        {
            entity.ToTable("_CharCOS");

            entity.HasIndex(e => e.OwnerCharId, "IX__CharCOS").HasFillFactor(90);

            entity.HasIndex(e => e.CharName, "IX__CharCOS_1").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CharName)
                .HasMaxLength(16)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.ExtraOption).HasDefaultValue(0);
            entity.Property(e => e.Hgp).HasColumnName("HGP");
            entity.Property(e => e.Hp).HasColumnName("HP");
            entity.Property(e => e.KeeperNpc).HasColumnName("KeeperNPC");
            entity.Property(e => e.Lvl).HasDefaultValue((byte)1);
            entity.Property(e => e.Mp).HasColumnName("MP");
            entity.Property(e => e.OwnerCharId).HasColumnName("OwnerCharID");
            entity.Property(e => e.RefCharId).HasColumnName("RefCharID");
            entity.Property(e => e.RentEndTime).HasColumnType("smalldatetime");
            entity.Property(e => e.SexpOffset)
                .HasDefaultValue((short)0)
                .HasColumnName("SExpOffset");
            entity.Property(e => e.SkillSlot).HasDefaultValue(0);
            entity.Property(e => e.Sp)
                .HasDefaultValue(0)
                .HasColumnName("SP");
        });

        modelBuilder.Entity<CharCollectionBook>(entity =>
        {
            entity.HasKey(e => new { e.CharId, e.ThemeId, e.SlotIndex });

            entity.ToTable("_CharCollectionBook");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.ThemeId).HasColumnName("ThemeID");
            entity.Property(e => e.RegDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<CharFestivalBalloonLevel>(entity =>
        {
            entity.HasKey(e => e.CharId);

            entity.ToTable("_CharFestivalBalloonLevel");

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");
            entity.Property(e => e.RefBalloonId).HasColumnName("RefBalloonID");

            entity.HasOne(d => d.Char).WithOne(p => p.CharFestivalBalloonLevel)
                .HasForeignKey<CharFestivalBalloonLevel>(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CharFestivalBalloonLevel__Char");
        });

        modelBuilder.Entity<CharFestivalReceipt>(entity =>
        {
            entity.HasKey(e => e.CharId);

            entity.ToTable("_CharFestivalReceipt");

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");

            entity.HasOne(d => d.Char).WithOne(p => p.CharFestivalReceipt)
                .HasForeignKey<CharFestivalReceipt>(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CharFestivalReceipt__Char");
        });

        modelBuilder.Entity<CharImprisonment>(entity =>
        {
            entity.HasKey(e => e.CharId);

            entity.ToTable("_CharImprisonment");

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");
        });

        modelBuilder.Entity<CharInstanceWorldDatum>(entity =>
        {
            entity.HasKey(e => new { e.CharId, e.WorldId });

            entity.ToTable("_CharInstanceWorldData");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.WorldId).HasColumnName("WorldID");
            entity.Property(e => e.DungeonKeyId).HasColumnName("DungeonKeyID");
            entity.Property(e => e.LastEnterTime).HasColumnType("datetime");
            entity.Property(e => e.LayerId).HasColumnName("LayerID");
            entity.Property(e => e.OpenedTime).HasColumnType("datetime");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
        });

        modelBuilder.Entity<CharNameList>(entity =>
        {
            entity.HasKey(e => new { e.CharName16, e.CharId }).IsClustered(false);

            entity.ToTable("_CharNameList");

            entity.HasIndex(e => e.CharId, "IX_CharID").HasFillFactor(70);

            entity.Property(e => e.CharName16)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.CharId).HasColumnName("CharID");
        });

        modelBuilder.Entity<CharNewTrade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_CharNewTrade");

            entity.HasIndex(e => e.CharId, "UQ___CharNewTrade__3B14AD64").IsUnique();

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.DepartureRegionId).HasColumnName("DepartureRegionID");
        });

        modelBuilder.Entity<CharNickNameList>(entity =>
        {
            entity.HasKey(e => new { e.NickName16, e.CharId });

            entity.ToTable("_CharNickNameList");

            entity.HasIndex(e => e.CharId, "IX_CharNickNameList").HasFillFactor(90);

            entity.Property(e => e.NickName16)
                .HasMaxLength(17)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.CharId).HasColumnName("CharID");
        });

        modelBuilder.Entity<CharQuest>(entity =>
        {
            entity.HasKey(e => new { e.CharId, e.QuestId });

            entity.ToTable("_CharQuest");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.QuestId).HasColumnName("QuestID");
            entity.Property(e => e.DailyStatus).IsSparse();
            entity.Property(e => e.EndTime).HasColumnType("smalldatetime");
            entity.Property(e => e.QuestData1).IsSparse();
            entity.Property(e => e.QuestData2).IsSparse();
            entity.Property(e => e.QuestData3).IsSparse();
            entity.Property(e => e.StartTime).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<CharSkill>(entity =>
        {
            entity.HasKey(e => new { e.CharId, e.SkillId });

            entity.ToTable("_CharSkill");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.SkillId).HasColumnName("SkillID");
            entity.Property(e => e.Enable).HasDefaultValue((byte)1);

            entity.HasOne(d => d.Char).WithMany(p => p.CharSkills)
                .HasForeignKey(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CharSkill__Char");
        });

        modelBuilder.Entity<CharSkillMastery>(entity =>
        {
            entity.HasKey(e => new { e.CharId, e.MasteryId });

            entity.ToTable("_CharSkillMastery");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.MasteryId).HasColumnName("MasteryID");

            entity.HasOne(d => d.Char).WithMany(p => p.CharSkillMasteries)
                .HasForeignKey(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CharSkillMastery__Char");
        });

        modelBuilder.Entity<CharSupportItemByLevel>(entity =>
        {
            entity.HasKey(e => e.CharId);

            entity.ToTable("_CharSupportItemByLevel");

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");
        });

        modelBuilder.Entity<CharTeleport>(entity =>
        {
            entity.HasKey(e => new { e.CharId, e.Index });

            entity.ToTable("_CharTeleport");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.WorldId).HasColumnName("WorldID");
        });

        modelBuilder.Entity<CharTitle>(entity =>
        {
            entity.HasKey(e => new { e.CharId, e.TitleId }).HasName("PK_CharTitle");

            entity.ToTable("_CharTitle");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.TitleId).HasColumnName("TitleID");
            entity.Property(e => e.LimitTime).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<CharTradeConflictJob>(entity =>
        {
            entity.HasKey(e => e.CharId);

            entity.ToTable("_CharTradeConflictJob");

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");
            entity.Property(e => e.NickNameRegDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<CharTradeConflictJobKill>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_CharTradeConflictJob_Kill");

            entity.HasIndex(e => e.CharId, "IX_CharTradeConflictJob_Kill")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.KilledCharId).HasColumnName("KilledCharID");
        });

        modelBuilder.Entity<CharTrijob>(entity =>
        {
            entity.HasKey(e => e.CharId);

            entity.ToTable("_CharTrijob");

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");
            entity.Property(e => e.Level).HasDefaultValue((byte)1);

            entity.HasOne(d => d.Char).WithOne(p => p.CharTrijob)
                .HasForeignKey<CharTrijob>(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CharTrijob__Char");
        });

        modelBuilder.Entity<CharTrijobSafeTrade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_CharTrijobSafeTrade");

            entity.HasIndex(e => e.CharId, "IX__CharTrijobSafeTrade")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.LastSafeTrade).HasColumnType("datetime");

            entity.HasOne(d => d.Char).WithOne()
                .HasForeignKey<CharTrijobSafeTrade>(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CharTrijobSafeTrade__CharTrijob");
        });

        modelBuilder.Entity<CharUniqueKill>(entity =>
        {
            entity.HasKey(e => new { e.CharId, e.EventDate }).HasName("PK___CharUni__1C28F59B615DD640");

            entity.ToTable("_CharUniqueKill");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.EventDate).HasColumnType("datetime");
            entity.Property(e => e.MobId).HasColumnName("MobID");
        });

        modelBuilder.Entity<Chest>(entity =>
        {
            entity.HasKey(e => new { e.UserJid, e.Slot });

            entity.ToTable("_Chest");

            entity.Property(e => e.UserJid).HasColumnName("UserJID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");

            entity.HasOne(d => d.Item).WithMany(p => p.Chests)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK__Chest__Items");

            entity.HasOne(d => d.UserJ).WithMany(p => p.Chests)
                .HasPrincipalKey(p => p.Jid)
                .HasForeignKey(d => d.UserJid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Chest__User");
        });

        modelBuilder.Entity<ChestInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_ChestInfo");

            entity.HasIndex(e => e.Jid, "IX__ChestInfo__JID")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.ChestSize).HasDefaultValue((byte)150);
            entity.Property(e => e.Jid).HasColumnName("JID");

            entity.HasOne(d => d.JidNavigation).WithMany()
                .HasPrincipalKey(p => p.Jid)
                .HasForeignKey(d => d.Jid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChestInfo__AccountJID");
        });

        modelBuilder.Entity<ClientConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_ClientConfig");

            entity.HasIndex(e => e.CharId, "IX__ClientConfig")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.CharId).HasColumnName("CharID");
        });

        modelBuilder.Entity<ConsignmentTradeInvest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ConsignmentTrade_Invest__ID");

            entity.ToTable("_ConsignmentTrade_Invest");

            entity.HasIndex(e => new { e.CharId, e.ProgressId }, "IX__ConsignmentTrade_Invest_CharID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.ProgressId).HasColumnName("ProgressID");
            entity.Property(e => e.RefObjId).HasColumnName("RefObjID");
        });

        modelBuilder.Entity<ConsignmentTradeProgress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ConsignmentTrade_Progress__ID");

            entity.ToTable("_ConsignmentTrade_Progress");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.FlockId).HasColumnName("FlockID");
            entity.Property(e => e.PathId).HasColumnName("PathID");
        });

        modelBuilder.Entity<ContentConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_ContentConfig");

            entity.HasIndex(e => e.Id, "IX__ContentService")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CodeDesc128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Value)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ContentConfigCopy1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_ContentConfig_copy1");

            entity.HasIndex(e => e.Id, "UQ___Content__3214EC274BDF2C52")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CodeDesc128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Value)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CraftedMacroUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_CraftedMacroUser");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Ip)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.Jid).HasColumnName("JID");
        });

        modelBuilder.Entity<CrestInitFlag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_CrestInitFlag");
        });

        modelBuilder.Entity<DelItemNRewardList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_DelItem_N_RewardList");

            entity.Property(e => e.CodeName128)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
        });

        modelBuilder.Entity<DeleteEventItemList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_DeleteEventItemList");

            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
        });

        modelBuilder.Entity<DeleteItemChestLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_DeleteItemChestLog");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.CharName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.ItemCodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.Log)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
        });

        modelBuilder.Entity<DeletedChar>(entity =>
        {
            entity.HasKey(e => e.CharId);

            entity.ToTable("_DeletedChar");

            entity.HasIndex(e => e.UserJid, "IX__DeletedChar").HasFillFactor(90);

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<DropItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DROP_ITEMS");

            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<ESuppliedJidlist080321>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("E_SuppliedJIDList_080321");

            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.ItemRefId).HasColumnName("ItemRefID");
            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<EntryTicketCandidatesList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_EntryTicketCandidatesList");

            entity.HasIndex(e => e.EventId, "IX__EntryTicketCandidatesList_EventID").HasFillFactor(90);

            entity.HasIndex(e => e.Jid, "IX__EntryTicketCandidatesList_JID").HasFillFactor(90);

            entity.Property(e => e.CharName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.EntryDate).HasColumnType("smalldatetime");
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ItemCodeName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Jid).HasColumnName("JID");
        });

        modelBuilder.Entity<EntryTicketDrawingList>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("_EntryTicketDrawingList");

            entity.HasIndex(e => e.EventId, "IX__EntryTicketDrawingList_EventID").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EventId).HasColumnName("EventID");
        });

        modelBuilder.Entity<EntryTicketWinnerList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_EntryTicketWinnerList");

            entity.HasIndex(e => e.EventId, "IX__EntryticketWinnerlist_EventID").HasFillFactor(90);

            entity.HasIndex(e => e.Jid, "IX__EntryticketWinnerlist_JID").HasFillFactor(90);

            entity.Property(e => e.CharName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ItemCodeName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Jid).HasColumnName("JID");
        });

        modelBuilder.Entity<EquipErrorCo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_EquipErrorCOS");

            entity.Property(e => e.Id64).HasColumnName("ID64");
            entity.Property(e => e.NewCosid).HasColumnName("NewCOSID");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
        });

        modelBuilder.Entity<EquipInvCo>(entity =>
        {
            entity.HasKey(e => new { e.NewCosid, e.Slot }).HasName("PK__EquipInvCos");

            entity.ToTable("_EquipInvCOS");

            entity.Property(e => e.NewCosid).HasColumnName("NewCOSID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");

            entity.HasOne(d => d.Item).WithMany(p => p.EquipInvCos)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK__EquipInvCOS__Items");
        });

        modelBuilder.Entity<EventBuffReceipt>(entity =>
        {
            entity.HasKey(e => e.CharId);

            entity.ToTable("_EventBuffReceipt");

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");
        });

        modelBuilder.Entity<EventForgottenWorld>(entity =>
        {
            entity.HasKey(e => e.CharId);

            entity.ToTable("_EventForgottenWorld");

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");
        });

        modelBuilder.Entity<EventHiSilkRoadPrizeList>(entity =>
        {
            entity.HasKey(e => e.Jid);

            entity.ToTable("_Event_HiSilkRoad_PrizeList");

            entity.Property(e => e.Jid)
                .ValueGeneratedNever()
                .HasColumnName("JID");
            entity.Property(e => e.LastLogOut).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdateTime).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<EventRamadanVoucher>(entity =>
        {
            entity.HasKey(e => e.CharId).IsClustered(false);

            entity.ToTable("_EventRamadanVoucher");

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");
            entity.Property(e => e.CharName16)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Ranking).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EventSupportHighLevelUser>(entity =>
        {
            entity.HasKey(e => e.UserJid);

            entity.ToTable("_EventSupportHighLevelUser");

            entity.Property(e => e.UserJid)
                .ValueGeneratedNever()
                .HasColumnName("UserJID");
            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.CharName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.EventTime).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<EventSurvivalReward>(entity =>
        {
            entity.HasKey(e => e.CharId);

            entity.ToTable("_EventSurvivalReward");

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");
        });

        modelBuilder.Entity<EventTicketParticipant>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_EventTicket_Participants");

            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.LatestAttempt).HasColumnType("datetime");
        });

        modelBuilder.Entity<Eventnpccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_EVENTNPCCOUNT");

            entity.Property(e => e.Date)
                .HasColumnType("smalldatetime")
                .HasColumnName("date");
            entity.Property(e => e.Npccount).HasColumnName("NPCCOUNT");
        });

        modelBuilder.Entity<ExchangeItemPaymentDatum>(entity =>
        {
            entity.HasKey(e => new { e.CharId, e.Slot });

            entity.ToTable("_ExchangeItem_Payment_Data");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.MeterRateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
            entity.Property(e => e.RentCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ExploitLog>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.CharId });

            entity.ToTable("_ExploitLog");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.DetectedApp)
                .HasMaxLength(256)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.LogTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<FatigueForShard>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_Fatigue_For_Shard");

            entity.HasIndex(e => e.UserId, "IX_Fatigue_For_Shard_UserID");

            entity.HasIndex(e => e.Id, "IX__Fatigue_For_Shard")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LatestUpdateTimeToPlayTime).HasColumnName("LatestUpdateTime_ToPlayTime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<FlagWorldCoinRewardLog>(entity =>
        {
            entity.HasKey(e => new { e.Jid, e.CharId, e.LogTime });

            entity.ToTable("_FlagWorld_CoinRewardLog");

            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.LogTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<FlagWorldEventParticipant>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_FlagWorld_EventParticipants");

            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.LatestAttempt).HasColumnType("datetime");
        });

        modelBuilder.Entity<FleaMarketNetwork>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_FleaMarketNetwork");

            entity.HasIndex(e => new { e.CharId, e.Slot }, "CIX__FleaMarketNetwork")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.TidGroupId).HasColumnName("TidGroupID");

            entity.HasOne(d => d.Char).WithMany()
                .HasForeignKey(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FleaMarketNetwork__Char");
        });

        modelBuilder.Entity<FortressTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_FortressTemp");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.CharName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.FortressName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("fortressName");
            entity.Property(e => e.FotressId).HasColumnName("fotressID");
            entity.Property(e => e.GuildId).HasColumnName("guildID");
            entity.Property(e => e.GuildName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("guildName");
            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<FreeAccessBanLvl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_FreeAccessBanLvl");

            entity.HasIndex(e => e.EndTime, "IX__FreeAccessBanLvl_EndTime").HasFillFactor(90);

            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.Jid).HasColumnName("JID");
        });

        modelBuilder.Entity<Friend>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_Friend");

            entity.HasIndex(e => e.FriendCharId, "IX_FriendCharID").HasFillFactor(90);

            entity.HasIndex(e => e.CharId, "IX__Friend")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.FriendCharId).HasColumnName("FriendCharID");
            entity.Property(e => e.FriendCharName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.RefObjId)
                .HasDefaultValue(0)
                .HasColumnName("RefObjID");

            entity.HasOne(d => d.Char).WithMany()
                .HasForeignKey(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Friend__Char");

            entity.HasOne(d => d.FriendChar).WithMany()
                .HasForeignKey(d => d.FriendCharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Friend__Char1");
        });

        modelBuilder.Entity<FriendGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_FriendGroup");

            entity.HasIndex(e => e.CharId, "NC_IDX_FG_CharID").HasFillFactor(90);

            entity.HasIndex(e => new { e.CharId, e.GroupId }, "NC_IDX_FG_CharID_GroupID").HasFillFactor(70);

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.GroupName)
                .HasMaxLength(31)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GoldTrace>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK____GoldTrace__70B1A406");

            entity.ToTable("__GoldTrace");

            entity.HasIndex(e => e.DEventTime, "IX___GoldTrace_dEventTime").HasFillFactor(90);

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.DEventTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("dEventTime");
        });

        modelBuilder.Entity<GoldTrace1>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK___GoldTrace__7D4C8515");

            entity.ToTable("_GoldTrace");

            entity.HasIndex(e => e.DEventTime, "IX__GoldTrace_dEventTime").HasFillFactor(90);

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.DEventTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("dEventTime");
        });

        modelBuilder.Entity<Gphistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK___GPHistory__7C5860DC");

            entity.ToTable("_GPHistory");

            entity.HasIndex(e => e.GuildId, "IX_GPHistory_GuildID").HasFillFactor(90);

            entity.HasIndex(e => e.UsedTime, "IX_GPHistory_UsedTime").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CharName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.GuildId).HasColumnName("GuildID");
            entity.Property(e => e.UsedGp).HasColumnName("UsedGP");
            entity.Property(e => e.UsedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Guild>(entity =>
        {
            entity.ToTable("_Guild", tb => tb.HasTrigger("_Guild_TR_U"));

            entity.HasIndex(e => e.Name, "IX__Guild").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FoundationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.GatheredSp).HasColumnName("GatheredSP");
            entity.Property(e => e.MasterComment)
                .HasMaxLength(2049)
                .IsUnicode(false);
            entity.Property(e => e.MasterCommentTitle)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");

            entity.HasOne(d => d.AllianceNavigation).WithMany(p => p.Guilds)
                .HasForeignKey(d => d.Alliance)
                .HasConstraintName("FK__Guild__AlliedClans");
        });

        modelBuilder.Entity<GuildChest>(entity =>
        {
            entity.HasKey(e => new { e.GuildId, e.Slot });

            entity.ToTable("_GuildChest");

            entity.Property(e => e.GuildId).HasColumnName("GuildID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");

            entity.HasOne(d => d.Guild).WithMany(p => p.GuildChests)
                .HasForeignKey(d => d.GuildId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GuildChest_Guild");
        });

        modelBuilder.Entity<GuildCrest>(entity =>
        {
            entity.HasKey(e => e.GuildId);

            entity.ToTable("_GuildCrest");

            entity.Property(e => e.GuildId)
                .ValueGeneratedNever()
                .HasColumnName("GuildID");
            entity.Property(e => e.CrestBinary)
                .HasMaxLength(256)
                .IsFixedLength();

            entity.HasOne(d => d.Guild).WithOne(p => p.GuildCrest)
                .HasForeignKey<GuildCrest>(d => d.GuildId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GuildCrest__Guild");
        });

        modelBuilder.Entity<GuildLogGuildChest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_GuildLogGuildChest");

            entity.HasIndex(e => new { e.GuildId, e.Date }, "IX__GuildLogGuildChest")
                .IsDescending(false, true)
                .HasFillFactor(90);

            entity.Property(e => e.Actor)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Japanese_CI_AS_KS_WS");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.GuildId).HasColumnName("GuildID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
        });

        modelBuilder.Entity<GuildLogGuildMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_GuildLogGuildMain");

            entity.HasIndex(e => new { e.GuildId, e.Date }, "IX__GuildLogGuildMain")
                .IsDescending(false, true)
                .HasFillFactor(90);

            entity.Property(e => e.Actor)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Japanese_CI_AS_KS_WS");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.GuildId).HasColumnName("GuildID");
        });

        modelBuilder.Entity<GuildLogGuildPoint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_GuildLogGuildPoint");

            entity.HasIndex(e => new { e.GuildId, e.Date }, "IX__GuildLogGuildPoint")
                .IsDescending(false, true)
                .HasFillFactor(90);

            entity.Property(e => e.Actor)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Japanese_CI_AS_KS_WS");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.GuildId).HasColumnName("GuildID");
        });

        modelBuilder.Entity<GuildMember>(entity =>
        {
            entity.HasKey(e => new { e.GuildId, e.CharId });

            entity.ToTable("_GuildMember");

            entity.HasIndex(e => e.CharId, "IX_CharID_GuildMember").HasFillFactor(90);

            entity.Property(e => e.GuildId).HasColumnName("GuildID");
            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.CharName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.GpDonation).HasColumnName("GP_Donation");
            entity.Property(e => e.JoinDate).HasColumnType("smalldatetime");
            entity.Property(e => e.LastLevelup)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.LastLogout)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Nickname)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.RefObjId)
                .HasDefaultValue(0)
                .HasColumnName("RefObjID");
            entity.Property(e => e.SiegeAuthority).HasDefaultValue((byte)0);

            entity.HasOne(d => d.Char).WithMany(p => p.GuildMembers)
                .HasForeignKey(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GuildMember__Char");

            entity.HasOne(d => d.Guild).WithMany(p => p.GuildMembers)
                .HasForeignKey(d => d.GuildId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GuildMember__Guild");
        });

        modelBuilder.Entity<GuildWar>(entity =>
        {
            entity.ToTable("_GuildWar", tb => tb.HasTrigger("_GuildWar_TR_U"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.WarEndTime).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<InvCo>(entity =>
        {
            entity.HasKey(e => new { e.Cosid, e.Slot });

            entity.ToTable("_InvCOS");

            entity.Property(e => e.Cosid).HasColumnName("COSID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");

            entity.HasOne(d => d.Cos).WithMany(p => p.InvCos)
                .HasForeignKey(d => d.Cosid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__InvCOS__CharCOS");

            entity.HasOne(d => d.Item).WithMany(p => p.InvCos)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK__InvCOS__Items");
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasKey(e => new { e.CharId, e.Slot });

            entity.ToTable("_Inventory");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");

            entity.HasOne(d => d.Char).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Inventory__Char");

            entity.HasOne(d => d.Item).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Inventory__Items");
        });

        modelBuilder.Entity<InventoryForAvatar>(entity =>
        {
            entity.HasKey(e => new { e.CharId, e.Slot });

            entity.ToTable("_InventoryForAvatar");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");

            entity.HasOne(d => d.Char).WithMany(p => p.InventoryForAvatars)
                .HasForeignKey(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__InventoryForAvatar__Char");

            entity.HasOne(d => d.Item).WithMany(p => p.InventoryForAvatars)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__InventoryForAvatar__Items");
        });

        modelBuilder.Entity<InventoryForLinkedStorage>(entity =>
        {
            entity.HasKey(e => new { e.LinkedItemId, e.Slot });

            entity.ToTable("_InventoryForLinkedStorage");

            entity.Property(e => e.LinkedItemId).HasColumnName("LinkedItemID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.Id64).HasName("PK__Items_ID64_SPARSE");

            entity.ToTable("_Items");

            entity.Property(e => e.Id64).HasColumnName("ID64");
            entity.Property(e => e.CreaterName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .IsSparse();
            entity.Property(e => e.MagParam1).IsSparse();
            entity.Property(e => e.MagParam10).IsSparse();
            entity.Property(e => e.MagParam11).IsSparse();
            entity.Property(e => e.MagParam12).IsSparse();
            entity.Property(e => e.MagParam2).IsSparse();
            entity.Property(e => e.MagParam3).IsSparse();
            entity.Property(e => e.MagParam4).IsSparse();
            entity.Property(e => e.MagParam5).IsSparse();
            entity.Property(e => e.MagParam6).IsSparse();
            entity.Property(e => e.MagParam7).IsSparse();
            entity.Property(e => e.MagParam8).IsSparse();
            entity.Property(e => e.MagParam9).IsSparse();
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
            entity.Property(e => e.Variance).IsSparse();
        });

        modelBuilder.Entity<ItemPool>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK_ItemPool");

            entity.ToTable("_ItemPool");

            entity.HasIndex(e => e.InUse, "IX__ItemPool");

            entity.Property(e => e.ItemId)
                .ValueGeneratedNever()
                .HasColumnName("ItemID");

            entity.HasOne(d => d.Item).WithOne(p => p.ItemPool)
                .HasForeignKey<ItemPool>(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ItemPool__Items");
        });

        modelBuilder.Entity<ItemQuotation>(entity =>
        {
            entity.ToTable("_ItemQuotation");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AssocNpc).HasColumnName("AssocNPC");
            entity.Property(e => e.QuotLb).HasColumnName("Quot_LB");
            entity.Property(e => e.QuotUb).HasColumnName("Quot_UB");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
        });

        modelBuilder.Entity<KeepDelCharName>(entity =>
        {
            entity.HasKey(e => e.CharName).HasName("PK__KeepDelCHarName_CharName");

            entity.ToTable("_KeepDelCharName");

            entity.Property(e => e.CharName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.DelTime).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<LastestOpenMarketPesnalId>(entity =>
        {
            entity.HasKey(e => e.Jid).HasName("PK__LastestOpenMarketPesnalID_JID");

            entity.ToTable("_LastestOpenMarketPesnalID");

            entity.Property(e => e.Jid)
                .ValueGeneratedNever()
                .HasColumnName("JID");
            entity.Property(e => e.LatestPersnalId).HasColumnName("LatestPersnalID");

            entity.HasOne(d => d.JidNavigation).WithOne(p => p.LastestOpenMarketPesnalId)
                .HasPrincipalKey<AccountJid>(p => p.Jid)
                .HasForeignKey<LastestOpenMarketPesnalId>(d => d.Jid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LastestOpenMarketPesnalID_JID");
        });

        modelBuilder.Entity<LatestItemSerial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LatestItemSerial");

            entity.Property(e => e.LatestItemSerial1).HasColumnName("LatestItemSerial");
        });

        modelBuilder.Entity<LogDelItemNRewardAmount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LOG_DEL_ITEM_N_REWARD_AMOUNT");

            entity.HasIndex(e => new { e.StorageType, e.OwnerId }, "_LOG_DEL_ITEM_N_REWARD_AMOUNT_INDEX")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.Id64).HasColumnName("ID64");
            entity.Property(e => e.IsReward)
                .HasMaxLength(2)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.ItemCodeName)
                .HasMaxLength(129)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.RewardDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.StorageType)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.StrDesc)
                .HasMaxLength(129)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("strDesc");
        });

        modelBuilder.Entity<LogEventGold>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LogEventGold");

            entity.HasIndex(e => e.CharId, "_LogEventGold_IDX_CharID").HasFillFactor(70);

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.CharName16)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.EventTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<LogEventGoldInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LogEventGoldInfo");

            entity.Property(e => e.AppName)
                .HasMaxLength(50)
                .HasColumnName("appName");
            entity.Property(e => e.CurrentMachine).HasMaxLength(30);
            entity.Property(e => e.CurrentUser).HasMaxLength(40);
            entity.Property(e => e.Eventtime)
                .HasColumnType("datetime")
                .HasColumnName("eventtime");
            entity.Property(e => e.Eventtype)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("eventtype");
            entity.Property(e => e.Tsql)
                .HasMaxLength(4000)
                .HasColumnName("tsql");
        });

        modelBuilder.Entity<LogEventGoldNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LogEventGold_new");

            entity.HasIndex(e => e.EventTime, "_LogEventGold_new_IDX_EventTime");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.CharName16)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.EtcId).HasColumnName("ETC_ID");
            entity.Property(e => e.Etype)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("EType");
            entity.Property(e => e.EventTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<LogEventItem1Tt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LogEventItem_1_tt");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.DwData).HasColumnName("dwData");
            entity.Property(e => e.EventPos)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.Gold).HasDefaultValue(0L);
            entity.Property(e => e.ItemRefId).HasColumnName("ItemRefID");
            entity.Property(e => e.SlotFrom).HasColumnName("Slot_From");
            entity.Property(e => e.SlotTo).HasColumnName("Slot_To");
            entity.Property(e => e.StrDesc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("strDesc");
        });

        modelBuilder.Entity<LogEventLevelRigid>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LOG_EVENT_LEVEL_RIGID");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.CharName)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
        });

        modelBuilder.Entity<LogEventPaymentItemOccupySiegefortress>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LOG_EVENT_PAYMENT_ITEM_OCCUPY_SIEGEFORTRESS");

            entity.Property(e => e.AccountId)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("AccountID");
            entity.Property(e => e.CharName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.ErrorCode)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.GuildName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.ItemCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OccupySf)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("OccupySF");
            entity.Property(e => e.PaymentDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<LogEventPaymentItemOccupySiegefortressTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LOG_EVENT_PAYMENT_ITEM_OCCUPY_SIEGEFORTRESS_TEMP");

            entity.Property(e => e.AccountId)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("AccountID");
            entity.Property(e => e.CharName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.ErrorCode)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.GuildName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.ItemCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OccupySf)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("OccupySF");
            entity.Property(e => e.PaymentDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<LogRepairListReward3jobRelatedItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LogRepairList_Reward_3Job_Related_Item");

            entity.Property(e => e.CharId).HasColumnName("CharID");
        });

        modelBuilder.Entity<LogResultRewardSilk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LOG_RESULT_REWARD_SILK");

            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.RewardDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<LogSeekNDestroyItemFast>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_Log_SEEK_N_DESTROY_ITEM_FAST");

            entity.Property(e => e.CodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.DeletedTime).HasColumnType("datetime");
            entity.Property(e => e.Id64).HasColumnName("ID64");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
        });

        modelBuilder.Entity<Memo>(entity =>
        {
            entity.HasKey(e => e.Id64).IsClustered(false);

            entity.ToTable("_Memo");

            entity.HasIndex(e => e.CharId, "IX__Memo")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.Id64).HasColumnName("ID64");
            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.FromCharName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Message)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.RefObjId)
                .HasDefaultValue(0)
                .HasColumnName("RefObjID");

            entity.HasOne(d => d.Char).WithMany(p => p.Memos)
                .HasForeignKey(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Memo__Char");
        });

        modelBuilder.Entity<MemoBlock>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_MemoBlock");

            entity.HasIndex(e => e.OwnerId, "IX_MemoBlock_OwnerID").HasFillFactor(90);

            entity.HasIndex(e => e.TargetCharName, "IX_MemoBlock_TargetCharName").HasFillFactor(90);

            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.TargetCharName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");

            entity.HasOne(d => d.Owner).WithMany()
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MemoBlock__Char");
        });

        modelBuilder.Entity<Notice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_Notice");

            entity.HasIndex(e => e.CodeName128, "IX_Notice")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .UseCollation("Japanese_CI_AS_KS_WS");
            entity.Property(e => e.Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .UseCollation("Japanese_CI_AS_KS_WS");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<NoticeDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_Notice_Detail");

            entity.Property(e => e.DetailMessage)
                .HasMaxLength(129)
                .IsUnicode(false)
                .UseCollation("Japanese_CI_AS_KS_WS");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<OffsetItemUpgradeNreinforceRatio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_OffsetItemUpgradeNReinforceRatio");
        });

        modelBuilder.Entity<OffsetItemUpgradeNreinforceRatioBackup>(entity =>
        {
            entity.HasKey(e => new { e.RatioType, e.RatioSubType });

            entity.ToTable("_OffsetItemUpgradeNReinforceRatio_Backup");
        });

        modelBuilder.Entity<OldTrijob>(entity =>
        {
            entity.HasKey(e => e.CharId);

            entity.ToTable("_OldTrijob");

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");
            entity.Property(e => e.HunterExp).HasColumnName("Hunter_Exp");
            entity.Property(e => e.JobLvlHunter).HasColumnName("JobLvl_Hunter");
            entity.Property(e => e.JobLvlRobber).HasColumnName("JobLvl_Robber");
            entity.Property(e => e.JobLvlTrader).HasColumnName("JobLvl_Trader");
            entity.Property(e => e.RobberExp).HasColumnName("Robber_Exp");
            entity.Property(e => e.TraderExp).HasColumnName("Trader_Exp");
        });

        modelBuilder.Entity<OpenMarket>(entity =>
        {
            entity.HasKey(e => new { e.Jid, e.PersnalId }).HasName("PK__OpenMarket_JID_PersnalID");

            entity.ToTable("_OpenMarket", tb => tb.HasTrigger("_OpenMarket_TR_U"));

            entity.HasIndex(e => new { e.Status, e.TidGroupId, e.ItemClass, e.RegDate }, "IX__OpenMarket_For_SMC").HasFillFactor(90);

            entity.HasIndex(e => new { e.Jid, e.Status }, "IX__OpenMarket_JID_STATUS").HasFillFactor(90);

            entity.HasIndex(e => new { e.TidGroupId, e.Status, e.EndDate }, "IX__OpenMarket_TID_STATUS_REGDATE").HasFillFactor(90);

            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.PersnalId)
                .HasDefaultValue(-1)
                .HasColumnName("PersnalID");
            entity.Property(e => e.CharName16)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
            entity.Property(e => e.RegDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TidGroupId).HasColumnName("TidGroupID");

            entity.HasOne(d => d.Item).WithMany(p => p.OpenMarkets)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OpenMarket__ItemID");

            entity.HasOne(d => d.JidNavigation).WithMany(p => p.OpenMarkets)
                .HasPrincipalKey(p => p.Jid)
                .HasForeignKey(d => d.Jid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OpenMarket__JID");
        });

        modelBuilder.Entity<OrphanItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_OrphanItems");

            entity.Property(e => e.CreaterName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Id64).HasColumnName("ID64");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
        });

        modelBuilder.Entity<PathPositionRememberPathPatrol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK___RefPath_FlockMemeber_Data_Memory__ID");

            entity.ToTable("_PathPositionRememberPathPatrol");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ConsignmentTradeId).HasColumnName("ConsignmentTradeID");
            entity.Property(e => e.FlockId).HasColumnName("FlockID");
            entity.Property(e => e.FlockMemberId).HasColumnName("FlockMemberID");
            entity.Property(e => e.Hp).HasColumnName("HP");
            entity.Property(e => e.Mp).HasColumnName("MP");
            entity.Property(e => e.PathId).HasColumnName("PathID");
        });

        modelBuilder.Entity<PreoccupancyName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_PreoccupancyName");

            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.ReqTime).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<RankingForChar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RankingForChar");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.CharName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.GuildId).HasColumnName("GuildID");
            entity.Property(e => e.RefObjId).HasColumnName("RefObjID");
            entity.Property(e => e.Sp).HasColumnName("SP");
        });

        modelBuilder.Entity<RankingForGold>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RankingForGold");

            entity.Property(e => e.CharName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.FirstMasteryId).HasColumnName("FirstMasteryID");
            entity.Property(e => e.SecondMasteryId).HasColumnName("SecondMasteryID");
        });

        modelBuilder.Entity<RankingForGuild>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RankingForGuild");

            entity.Property(e => e.Gp).HasColumnName("GP");
            entity.Property(e => e.GuildMasterName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.GuildName)
                .HasMaxLength(64)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RankingForLevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RankingForLevel");

            entity.Property(e => e.CharName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.FirstMasteryId).HasColumnName("FirstMasteryID");
            entity.Property(e => e.SecondMasteryId).HasColumnName("SecondMasteryID");
        });

        modelBuilder.Entity<RefAbilityByItemOptLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK___RefAbil__3214EC27575DD02C");

            entity.ToTable("_RefAbilityByItemOptLevel");

            entity.HasIndex(e => e.Id, "IX__RefAbilityByItemOptLevel").IsUnique();

            entity.HasIndex(e => new { e.RefItemId, e.ItemOptLevel }, "IX__RefAbilityByItemOptLevel_1").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");

            entity.HasOne(d => d.RefItem).WithMany(p => p.RefAbilityByItemOptLevels)
                .HasForeignKey(d => d.RefItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefAbilityByItemOptLevel__RefObjCommon");
        });

        modelBuilder.Entity<RefAccessPermissionOfShop>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefAccessPermissionOfShop");

            entity.HasIndex(e => new { e.Country, e.RefShopCodeName, e.FourCc }, "IX__RefAccessPermissionOfShop").IsUnique();

            entity.Property(e => e.FourCc).HasColumnName("FourCC");
            entity.Property(e => e.Param1Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc128");
            entity.Property(e => e.Param2Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc128");
            entity.Property(e => e.Param3Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc128");
            entity.Property(e => e.Param4Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param4_Desc128");
            entity.Property(e => e.RefShopCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);

            entity.HasOne(d => d.CountryNavigation).WithMany()
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefAccessPermissionOfShop__RefShopObject");
        });

        modelBuilder.Entity<RefAchievement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RefAchievement_ID");

            entity.ToTable("_RefAchievement");

            entity.HasIndex(e => e.CodeName, "IX__RefAchievement_CodeName").IsUnique();

            entity.HasIndex(e => e.UnlockLevel, "IX__RefAchievement_UnlockLevel").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<RefAchievementCondition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RefAchievementCondition_ID");

            entity.ToTable("_RefAchievementCondition");

            entity.HasIndex(e => e.RefAchievementId, "IX__RefAchievementCondition_RefAchievementID").HasFillFactor(90);

            entity.HasIndex(e => e.CodeName, "UQ__RefAchievementCondition_CodeName").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.RefAchievementId).HasColumnName("RefAchievementID");

            entity.HasOne(d => d.RefAchievement).WithMany(p => p.RefAchievementConditions)
                .HasForeignKey(d => d.RefAchievementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefAchievementCondition_RefAchievementID_RefAchievement_ID");
        });

        modelBuilder.Entity<RefAchievementConditionItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefAchievementConditionItem");

            entity.HasIndex(e => e.RefAchievementConditionId, "IX__RefAchievementConditionItem_RefAchievementConditionID").HasFillFactor(90);

            entity.Property(e => e.RefAchievementConditionId).HasColumnName("RefAchievementConditionID");
            entity.Property(e => e.RefItemId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("RefItemID");
            entity.Property(e => e.TypeId1)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("TypeID1");
            entity.Property(e => e.TypeId2)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("TypeID2");
            entity.Property(e => e.TypeId3)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("TypeID3");
            entity.Property(e => e.TypeId4)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("TypeID4");

            entity.HasOne(d => d.RefAchievementCondition).WithMany()
                .HasForeignKey(d => d.RefAchievementConditionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefAchievementConditionItem_RefAchievementConditionID_RefAchievementCondition_ID");
        });

        modelBuilder.Entity<RefAchievementConditionLevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefAchievementConditionLevel");

            entity.HasIndex(e => e.RefAchievementConditionId, "IX__RefAchievementConditionLevel_RefAchievementConditionID").HasFillFactor(90);

            entity.Property(e => e.RefAchievementConditionId).HasColumnName("RefAchievementConditionID");

            entity.HasOne(d => d.RefAchievementCondition).WithMany()
                .HasForeignKey(d => d.RefAchievementConditionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefAchievementConditionLevel_RefAchievementConditionID_RefAchievementCondition_ID");
        });

        modelBuilder.Entity<RefAchievementConditionMonster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefAchievementConditionMonster");

            entity.HasIndex(e => e.RefAchievementConditionId, "IX__RefAchievementConditionMonster_RefAchievementConditionID").HasFillFactor(90);

            entity.Property(e => e.Rarity).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.RefAchievementConditionId).HasColumnName("RefAchievementConditionID");
            entity.Property(e => e.RefMonsterId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("RefMonsterID");

            entity.HasOne(d => d.RefAchievementCondition).WithMany()
                .HasForeignKey(d => d.RefAchievementConditionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefAchievementConditionMonster_RefAchievementConditionID_RefAchievementCondition_ID");
        });

        modelBuilder.Entity<RefAchievementRewardTitle>(entity =>
        {
            entity.HasKey(e => e.RefAchievementId)
                .HasName("PK__RefAchievementRewardTitle_RefAchievementID")
                .IsClustered(false);

            entity.ToTable("_RefAchievementRewardTitle");

            entity.Property(e => e.RefAchievementId)
                .ValueGeneratedNever()
                .HasColumnName("RefAchievementID");
            entity.Property(e => e.RefTitleId).HasColumnName("RefTitleID");

            entity.HasOne(d => d.RefAchievement).WithOne(p => p.RefAchievementRewardTitle)
                .HasForeignKey<RefAchievementRewardTitle>(d => d.RefAchievementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefAchievementRewardTitle_RefAchievementID_RefAchievement_ID");
        });

        modelBuilder.Entity<RefAlchemyCorrection>(entity =>
        {
            entity.HasKey(e => new { e.RefMagicOptId, e.AlchemyCorrectionTagetCodeName128, e.CorrectionValue });

            entity.ToTable("_RefAlchemyCorrection");

            entity.Property(e => e.RefMagicOptId).HasColumnName("RefMagicOptID");
            entity.Property(e => e.AlchemyCorrectionTagetCodeName128)
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.HasOne(d => d.RefMagicOpt).WithMany(p => p.RefAlchemyCorrections)
                .HasForeignKey(d => d.RefMagicOptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefAlchemyCorrection__RefMagicOpt");
        });

        modelBuilder.Entity<RefAlchemyMerit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefAlchemyMerit");

            entity.Property(e => e.FreeParamDesc1)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.FreeParamDesc2)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.FreeParamDesc3)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OptName128)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefAlchemyMkMaterialGroup>(entity =>
        {
            entity.HasKey(e => new { e.GroupCodeName, e.ItemCodeName }).HasName("PK_RefAlchemy_MK_MaterialGroup");

            entity.ToTable("_RefAlchemy_MK_MaterialGroup");

            entity.Property(e => e.GroupCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.ItemCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.RequireCount).HasColumnName("Require_Count");
        });

        modelBuilder.Entity<RefAlchemyMkRecipe>(entity =>
        {
            entity.HasKey(e => e.RcId).HasName("PK_RefAlchemy_MK_Recipe");

            entity.ToTable("_RefAlchemy_MK_Recipe");

            entity.Property(e => e.RcId).HasColumnName("RC_ID");
            entity.Property(e => e.MkMaterialGroup1)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("MK_MaterialGroup1");
            entity.Property(e => e.MkMaterialGroup2)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("MK_MaterialGroup2");
            entity.Property(e => e.MkMaterialGroup3)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("MK_MaterialGroup3");
            entity.Property(e => e.MkResultGroup1)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("MK_ResultGroup1");
            entity.Property(e => e.MkResultGroup2)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("MK_ResultGroup2");
            entity.Property(e => e.MkResultGroup3)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("MK_ResultGroup3");
            entity.Property(e => e.MtGroup1Condition).HasColumnName("MtGroup1_Condition");
            entity.Property(e => e.MtGroup2Condition).HasColumnName("MtGroup2_Condition");
            entity.Property(e => e.MtGroup3Condition).HasColumnName("MtGroup3_Condition");
            entity.Property(e => e.Param1).HasDefaultValue(-1);
            entity.Property(e => e.Param1Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc128");
            entity.Property(e => e.Param2).HasDefaultValue(-1);
            entity.Property(e => e.Param2Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc128");
            entity.Property(e => e.Param3).HasDefaultValue(-1);
            entity.Property(e => e.Param3Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc128");
            entity.Property(e => e.RcCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("RC_CodeName128");
            entity.Property(e => e.RcDesc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("RC_Desc128");
            entity.Property(e => e.RcIcon)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("RC_Icon");
            entity.Property(e => e.RcLevel).HasColumnName("RC_Level");
            entity.Property(e => e.RcMakeTime).HasColumnName("RC_Make_Time");
            entity.Property(e => e.RcRarity).HasColumnName("RC_Rarity");
            entity.Property(e => e.RcReuseTime).HasColumnName("RC_Reuse_Time");
            entity.Property(e => e.RcSlot).HasColumnName("RC_Slot");
            entity.Property(e => e.RcStrId128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("RC_StrID128");
            entity.Property(e => e.RcTab).HasColumnName("RC_Tab");
            entity.Property(e => e.RcType).HasColumnName("RC_Type");
            entity.Property(e => e.RequireCharLevel).HasColumnName("Require_CharLevel");
            entity.Property(e => e.ResultStrId128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Result_StrID128");
            entity.Property(e => e.RtGroup1Condition).HasColumnName("RtGroup1_Condition");
            entity.Property(e => e.RtGroup2Condition).HasColumnName("RtGroup2_Condition");
            entity.Property(e => e.RtGroup3Condition).HasColumnName("RtGroup3_Condition");
        });

        modelBuilder.Entity<RefAlchemyMkResultGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefAlchemy_MK_ResultGroup");

            entity.Property(e => e.GroupCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.ItemCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.MakeCount).HasColumnName("Make_Count");
            entity.Property(e => e.MakeRatio).HasColumnName("Make_Ratio");
        });

        modelBuilder.Entity<RefAlchemyMkShop>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefAlchemy_MK_Shop");

            entity.Property(e => e.Param1).HasDefaultValue(-1);
            entity.Property(e => e.Param1Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc128");
            entity.Property(e => e.Param2).HasDefaultValue(-1);
            entity.Property(e => e.Param2Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc128");
            entity.Property(e => e.Param3).HasDefaultValue(-1);
            entity.Property(e => e.Param3Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc128");
            entity.Property(e => e.Param4).HasDefaultValue(-1);
            entity.Property(e => e.Param4Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param4_Desc128");
            entity.Property(e => e.Param5).HasDefaultValue(-1);
            entity.Property(e => e.Param5Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param5_Desc128");
            entity.Property(e => e.RcId).HasColumnName("RC_ID");
            entity.Property(e => e.ShopCodeName)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Shop_CodeName");

            entity.HasOne(d => d.Rc).WithMany()
                .HasForeignKey(d => d.RcId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RefAlchemy_MK_Shop_RC_CodeName");
        });

        modelBuilder.Entity<RefAlchemyMkToolTip>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefAlchemy_MK_ToolTip");

            entity.Property(e => e.Description)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.MaterialStrName1)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Material_StrName1");
            entity.Property(e => e.MaterialStrName1Count).HasColumnName("Material_StrName1_Count");
            entity.Property(e => e.MaterialStrName2)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Material_StrName2");
            entity.Property(e => e.MaterialStrName2Count).HasColumnName("Material_StrName2_Count");
            entity.Property(e => e.MaterialStrName3)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Material_StrName3");
            entity.Property(e => e.MaterialStrName3Count).HasColumnName("Material_StrName3_Count");
            entity.Property(e => e.MaterialStrName4)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Material_StrName4");
            entity.Property(e => e.MaterialStrName4Count).HasColumnName("Material_StrName4_Count");
            entity.Property(e => e.MaterialStrName5)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Material_StrName5");
            entity.Property(e => e.MaterialStrName5Count).HasColumnName("Material_StrName5_Count");
            entity.Property(e => e.MaterialStrName6)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Material_StrName6");
            entity.Property(e => e.MaterialStrName6Count).HasColumnName("Material_StrName6_Count");
            entity.Property(e => e.RcCodeName)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("RC_CodeName");
            entity.Property(e => e.ResultItemCount).HasColumnName("ResultItem_Count");
            entity.Property(e => e.ResultItemIcon)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("ResultItem_Icon");
            entity.Property(e => e.ResultItemStrName)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("ResultItem_StrName");
            entity.Property(e => e.ResultItemToolTip)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ResultItem_ToolTip");
        });

        modelBuilder.Entity<RefAlchemyMkUi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefAlchemy_MK_UI");

            entity.Property(e => e.UiTab).HasColumnName("UI_Tab");
            entity.Property(e => e.UiTabStrId128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("UI_Tab_StrID128");
        });

        modelBuilder.Entity<RefCartCosInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefCartCosInfo");

            entity.Property(e => e.CartCosCodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<RefCharDefaultQuest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefCharDefault_Quest");

            entity.Property(e => e.CodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<RefCharDefaultSkill>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefCharDefault_Skill");

            entity.Property(e => e.SkillId).HasColumnName("SkillID");
        });

        modelBuilder.Entity<RefCharDefaultSkillMastery>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefCharDefault_SkillMastery");

            entity.Property(e => e.MasteryId).HasColumnName("MasteryID");
        });

        modelBuilder.Entity<RefCharGen>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefCharGen");

            entity.Property(e => e.RefObjId).HasColumnName("RefObjID");
        });

        modelBuilder.Entity<RefClassUpgradeEquipItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefClassUpgradeEquipItem");

            entity.Property(e => e.RefId).HasColumnName("RefID");
            entity.Property(e => e.UpgradeRefId).HasColumnName("UpgradeRefID");
        });

        modelBuilder.Entity<RefClimate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefClimate");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<RefClimateSnowflake>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefClimate_SNOWFLAKE");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<RefCollectionBookItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefCollectionBook_Item");

            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Ddjfile128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("DDJFile128");
            entity.Property(e => e.ObjName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Story128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.ThemeCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefCollectionBookTheme>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefCollectionBook_Theme");

            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Desc128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.ObjName128)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefConditionToBuyScrapItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefConditionToBuyScrapItem");

            entity.HasIndex(e => new { e.Country, e.Cash, e.TypeId1, e.TypeId2, e.TypeId3, e.TypeId4, e.RefItemCodeName, e.AcceptOrReject, e.FourCc }, "IX__RefConditionToBuyScrapItem").IsUnique();

            entity.Property(e => e.FourCc).HasColumnName("FourCC");
            entity.Property(e => e.Param1Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc128");
            entity.Property(e => e.Param2Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc128");
            entity.Property(e => e.Param3Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc128");
            entity.Property(e => e.Param4Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param4_Desc128");
            entity.Property(e => e.RefItemCodeName)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.TypeId1).HasColumnName("TypeID1");
            entity.Property(e => e.TypeId2).HasColumnName("TypeID2");
            entity.Property(e => e.TypeId3).HasColumnName("TypeID3");
            entity.Property(e => e.TypeId4).HasColumnName("TypeID4");

            entity.HasOne(d => d.CountryNavigation).WithMany()
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefConditionToBuyScrapItem__RefShopObject");
        });

        modelBuilder.Entity<RefConditionToSellPackageItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefConditionToSellPackageItem");

            entity.HasIndex(e => new { e.Country, e.RefPackageItemCodeName, e.FourCc }, "IX__RefConditionToSellPackageItem").IsUnique();

            entity.Property(e => e.FourCc).HasColumnName("FourCC");
            entity.Property(e => e.Param1Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc128");
            entity.Property(e => e.Param2Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc128");
            entity.Property(e => e.Param3Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc128");
            entity.Property(e => e.Param4Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param4_Desc128");
            entity.Property(e => e.RefPackageItemCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);

            entity.HasOne(d => d.CountryNavigation).WithMany()
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefConditionToSellPackageItem__RefShopObject");
        });

        modelBuilder.Entity<RefConditionToSellScrapItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefConditionToSellScrapItem");

            entity.HasIndex(e => new { e.Country, e.Cash, e.TypeId1, e.TypeId2, e.TypeId3, e.TypeId4, e.RefItemCodeName, e.AcceptOrReject, e.FourCc }, "IX__RefConditionToSellScrapItem").IsUnique();

            entity.Property(e => e.FourCc).HasColumnName("FourCC");
            entity.Property(e => e.Param1Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc128");
            entity.Property(e => e.Param2Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc128");
            entity.Property(e => e.Param3Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc128");
            entity.Property(e => e.Param4Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param4_Desc128");
            entity.Property(e => e.RefItemCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.TypeId1).HasColumnName("TypeID1");
            entity.Property(e => e.TypeId2).HasColumnName("TypeID2");
            entity.Property(e => e.TypeId3).HasColumnName("TypeID3");
            entity.Property(e => e.TypeId4).HasColumnName("TypeID4");

            entity.HasOne(d => d.CountryNavigation).WithMany()
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefConditionToSellScrapItem__RefShopObject");
        });

        modelBuilder.Entity<RefCustomizingReservedItemDropForMonster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefCustomizingReservedItemDropForMonster");

            entity.Property(e => e.Param1).HasDefaultValue(0);
            entity.Property(e => e.Param2).HasDefaultValue(0);
            entity.Property(e => e.Param3).HasDefaultValue(0);
            entity.Property(e => e.Param4).HasDefaultValue(0);
            entity.Property(e => e.Param5).HasDefaultValue(0);
            entity.Property(e => e.RefMonsterId).HasColumnName("RefMonsterID");

            entity.HasOne(d => d.RefMonster).WithMany()
                .HasForeignKey(d => d.RefMonsterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefCustomizingReservedItemDropForMonster__RefObjCommon");
        });

        modelBuilder.Entity<RefDropClassSelAlchemyAttrstone>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_Alchemy_ATTRStone");
        });

        modelBuilder.Entity<RefDropClassSelAlchemyEnhancer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_Alchemy_Enhancer");
        });

        modelBuilder.Entity<RefDropClassSelAlchemyMagicStone>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_Alchemy_MagicStone");
        });

        modelBuilder.Entity<RefDropClassSelAlchemyTablet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_Alchemy_Tablet");
        });

        modelBuilder.Entity<RefDropClassSelAlchemyUpgradeStone>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_Alchemy_UpgradeStone");
        });

        modelBuilder.Entity<RefDropClassSelAmmo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_Ammo");
        });

        modelBuilder.Entity<RefDropClassSelCoin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_Coin");
        });

        modelBuilder.Entity<RefDropClassSelCosequip>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_COSEquip");
        });

        modelBuilder.Entity<RefDropClassSelCosmagicStone>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_COSMagicStone");
        });

        modelBuilder.Entity<RefDropClassSelCospotion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_COSPotion");
        });

        modelBuilder.Entity<RefDropClassSelCosskill>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_COSSkill");
        });

        modelBuilder.Entity<RefDropClassSelCosskillRemove>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_COSSkillRemove");
        });

        modelBuilder.Entity<RefDropClassSelCure>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_Cure");
        });

        modelBuilder.Entity<RefDropClassSelEquip>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_Equip");
        });

        modelBuilder.Entity<RefDropClassSelLimitReinforce>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_LimitReinforce");
        });

        modelBuilder.Entity<RefDropClassSelNewCure>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_NewCure");
        });

        modelBuilder.Entity<RefDropClassSelRareEquip>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_RareEquip");
        });

        modelBuilder.Entity<RefDropClassSelRecover>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_Recover");
        });

        modelBuilder.Entity<RefDropClassSelReinforce>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_Reinforce");
        });

        modelBuilder.Entity<RefDropClassSelScroll>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_Scroll");
        });

        modelBuilder.Entity<RefDropClassSelSpecialty>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropClassSel_Specialty");
        });

        modelBuilder.Entity<RefDropGold>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropGold");
        });

        modelBuilder.Entity<RefDropItemAssign>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropItemAssign");

            entity.Property(e => e.ProbAbsolute).HasColumnName("Prob_Absolute");
            entity.Property(e => e.ProbRelative).HasColumnName("Prob_Relative");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
        });

        modelBuilder.Entity<RefDropItemGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropItemGroup");

            entity.HasIndex(e => new { e.RefItemGroupId, e.RefItemId }, "UQ___RefDrop__8CCA4D2F2B36CFB9").IsUnique();

            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.RefItemGroupId).HasColumnName("RefItemGroupID");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
            entity.Property(e => e.RefMagicGroupId).HasColumnName("RefMagicGroupID");

            entity.HasOne(d => d.RefItem).WithMany()
                .HasForeignKey(d => d.RefItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK___RefDropI__RefIt__2D1F182B");
        });

        modelBuilder.Entity<RefDropOptLvlSel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDropOptLvlSel");
        });

        modelBuilder.Entity<RefDummySlot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefDummySlot");

            entity.Property(e => e.Cnt).HasColumnName("cnt");
        });

        modelBuilder.Entity<RefEntryTicket>(entity =>
        {
            entity.HasKey(e => e.EventId);

            entity.ToTable("_RefEntryTicket");

            entity.Property(e => e.EventId)
                .ValueGeneratedNever()
                .HasColumnName("EventID");
            entity.Property(e => e.CoinType1)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx");
            entity.Property(e => e.CoinType2)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx");
            entity.Property(e => e.CoinType3)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx");
            entity.Property(e => e.EventGroupId).HasColumnName("EventGroupID");
            entity.Property(e => e.ItemCodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Param1Desc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc");
            entity.Property(e => e.Param2Desc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc");
            entity.Property(e => e.Param3Desc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc");
        });

        modelBuilder.Entity<RefEntryTicketSchedule>(entity =>
        {
            entity.ToTable("_RefEntryTicketSchedule");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<RefEquipItemPenalty>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefEquipItemPenalty");
        });

        modelBuilder.Entity<RefEquipItemPenaltyBalance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefEquipItemPenaltyBalance");

            entity.Property(e => e.PenaltyMgcMax).HasColumnName("Penalty_Mgc_Max");
            entity.Property(e => e.PenaltyMgcMin).HasColumnName("Penalty_Mgc_Min");
            entity.Property(e => e.PenaltyPhyMax).HasColumnName("Penalty_Phy_Max");
            entity.Property(e => e.PenaltyPhyMin).HasColumnName("Penalty_Phy_Min");
            entity.Property(e => e.TypeId2).HasColumnName("TypeID2");
            entity.Property(e => e.TypeId3).HasColumnName("TypeID3");
            entity.Property(e => e.TypeId4).HasColumnName("TypeID4");
        });

        modelBuilder.Entity<RefEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefEvent");

            entity.Property(e => e.CodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.DescName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ScheduleName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<RefEventFestivalReward>(entity =>
        {
            entity.HasKey(e => e.ItemCodeName);

            entity.ToTable("_RefEventFestivalReward");

            entity.Property(e => e.ItemCodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Param1Desc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc");
            entity.Property(e => e.Param2Desc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc");
        });

        modelBuilder.Entity<RefEventMonsterSpawn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefEventMonsterSpawn");

            entity.Property(e => e.MonsterCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
        });

        modelBuilder.Entity<RefEventReward>(entity =>
        {
            entity.HasKey(e => e.EventId);

            entity.ToTable("_RefEventReward");

            entity.Property(e => e.EventId)
                .ValueGeneratedNever()
                .HasColumnName("EventID");
            entity.Property(e => e.EventCodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Param1Desc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc");
            entity.Property(e => e.Param2Desc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc");
            entity.Property(e => e.Param3Desc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc");
            entity.Property(e => e.Sp).HasColumnName("SP");
            entity.Property(e => e.Spexp).HasColumnName("SPExp");
        });

        modelBuilder.Entity<RefEventRewardItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefEventRewardItems");

            entity.Property(e => e.EventCodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.ItemCodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Param1Desc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc");
            entity.Property(e => e.Param2Desc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc");
            entity.Property(e => e.RentItemCodeName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx");
        });

        modelBuilder.Entity<RefEventZone>(entity =>
        {
            entity.ToTable("_RefEventZone");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EventName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.StrParam1)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("strParam1");
            entity.Property(e => e.StrParam2)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("strParam2");
            entity.Property(e => e.StrParam3)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("strParam3");
            entity.Property(e => e.StrParam4)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("strParam4");
            entity.Property(e => e.StrParam5)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("strParam5");
            entity.Property(e => e.ZoneName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefExtraAbilityByEquipItemOptLevel>(entity =>
        {
            entity.HasKey(e => new { e.RefItemId, e.OptLevel });

            entity.ToTable("_RefExtraAbilityByEquipItemOptLevel");

            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
            entity.Property(e => e.MgcIncOpt).HasColumnName("Mgc_Inc_Opt");
            entity.Property(e => e.MgcOptId1).HasColumnName("MgcOptID1");
            entity.Property(e => e.MgcOptId2).HasColumnName("MgcOptID2");
            entity.Property(e => e.MgcOptId3).HasColumnName("MgcOptID3");
            entity.Property(e => e.MgcOptId4).HasColumnName("MgcOptID4");
            entity.Property(e => e.MgcOptId5).HasColumnName("MgcOptID5");
            entity.Property(e => e.PhyIncOpt).HasColumnName("Phy_Inc_Opt");
            entity.Property(e => e.SkillId1).HasColumnName("SkillID1");
            entity.Property(e => e.SkillId2).HasColumnName("SkillID2");
            entity.Property(e => e.SkillId3).HasColumnName("SkillID3");
            entity.Property(e => e.SkillId4).HasColumnName("SkillID4");
            entity.Property(e => e.SkillId5).HasColumnName("SkillID5");
        });

        modelBuilder.Entity<RefFmnCategoryTree>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefFmnCategoryTree");

            entity.Property(e => e.CategoryName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ParentCategoryName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.StringId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("StringID");
            entity.Property(e => e.TidGroupId).HasColumnName("TidGroupID");
        });

        modelBuilder.Entity<RefFmnTidGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefFmnTidGroup");

            entity.Property(e => e.TidGroupId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TidGroupID");
            entity.Property(e => e.TidGroupName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefFmnTidGroupMap>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefFmnTidGroupMap");

            entity.Property(e => e.TidGroupId).HasColumnName("TidGroupID");
            entity.Property(e => e.TypeId1).HasColumnName("TypeID1");
            entity.Property(e => e.TypeId2).HasColumnName("TypeID2");
            entity.Property(e => e.TypeId3).HasColumnName("TypeID3");
            entity.Property(e => e.TypeId4).HasColumnName("TypeID4");
        });

        modelBuilder.Entity<RefFreeAvatar>(entity =>
        {
            entity.ToTable("_RefFreeAvatar");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Attach)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("ATTACH");
            entity.Property(e => e.Dress)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("DRESS");
            entity.Property(e => e.Hat)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("HAT");
        });

        modelBuilder.Entity<RefFreeFellow>(entity =>
        {
            entity.ToTable("_RefFreeFellow");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodeName128)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("xxx");
        });

        modelBuilder.Entity<RefGachaCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefGachaCode");

            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.GachaSetId)
                .ValueGeneratedOnAdd()
                .HasColumnName("GachaSetID");
        });

        modelBuilder.Entity<RefGachaItemSet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefGachaItemSet");

            entity.Property(e => e.DivisionLevel)
                .HasDefaultValue(1)
                .HasColumnName("Division_Level");
            entity.Property(e => e.DivisionLevel100Ratio)
                .HasDefaultValue((short)1)
                .HasColumnName("DivisionLevel_100_ratio");
            entity.Property(e => e.DivisionLevel110Ratio)
                .HasDefaultValue((short)1)
                .HasColumnName("DivisionLevel_110_ratio");
            entity.Property(e => e.DivisionLevel120Ratio)
                .HasDefaultValue((short)1)
                .HasColumnName("DivisionLevel_120_ratio");
            entity.Property(e => e.DivisionLevel90Ratio)
                .HasDefaultValue((short)1)
                .HasColumnName("DivisionLevel_90_ratio");
            entity.Property(e => e.GachaId)
                .ValueGeneratedOnAdd()
                .HasColumnName("GachaID");
            entity.Property(e => e.Param1).HasColumnName("param1");
            entity.Property(e => e.Param1Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("param1_Desc128");
            entity.Property(e => e.Param2).HasColumnName("param2");
            entity.Property(e => e.Param2Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("param2_Desc128");
            entity.Property(e => e.Param3).HasColumnName("param3");
            entity.Property(e => e.Param3Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("param3_Desc128");
            entity.Property(e => e.Param4).HasColumnName("param4");
            entity.Property(e => e.Param4Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("param4_Desc128");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
            entity.Property(e => e.SetId).HasColumnName("Set_ID");
        });

        modelBuilder.Entity<RefGachaNpcMap>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefGachaNpcMap");

            entity.Property(e => e.NpcId).HasColumnName("NPC_ID");
            entity.Property(e => e.SelectionGachaId).HasColumnName("SelectionGachaID");
            entity.Property(e => e.SelectionPreGachaId).HasColumnName("SelectionPreGachaID");
            entity.Property(e => e.WasteGachaId).HasColumnName("WasteGachaID");
            entity.Property(e => e.WastePreGachaId).HasColumnName("WastePreGachaID");
        });

        modelBuilder.Entity<RefGachaTreeForClientUi>(entity =>
        {
            entity.HasKey(e => new { e.Tid1, e.Tid2, e.Tid3, e.Tid4 });

            entity.ToTable("_RefGachaTreeForClientUI");

            entity.Property(e => e.FirstCategoryId).HasColumnName("First_CategoryID");
            entity.Property(e => e.FirstCategoryString)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("First_Category_String");
            entity.Property(e => e.SecondCategoryId).HasColumnName("Second_CategoryID");
            entity.Property(e => e.SecondCategoryString)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("Second_Category_String");
        });

        modelBuilder.Entity<RefGameWorld>(entity =>
        {
            entity.ToTable("_RefGame_World");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ConfigGroupCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx");
            entity.Property(e => e.WorldCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("INSTANC_WORLD_CODENAME");
        });

        modelBuilder.Entity<RefGameWorldBindGameWorldGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RefGameWorldBindGroupGameWorld");

            entity.ToTable("_RefGameWorldBindGameWorldGroup");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GameWorldGroupId).HasColumnName("GameWorldGroupID");
            entity.Property(e => e.GameWorldId).HasColumnName("GameWorldID");

            entity.HasOne(d => d.GameWorldGroup).WithMany(p => p.RefGameWorldBindGameWorldGroups)
                .HasForeignKey(d => d.GameWorldGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefGameWorldBindGroupGameWorld__RefGroupGameWorld");

            entity.HasOne(d => d.GameWorld).WithMany(p => p.RefGameWorldBindGameWorldGroups)
                .HasForeignKey(d => d.GameWorldId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefGameWorldBindGroupGameWorld__RefGame_World");
        });

        modelBuilder.Entity<RefGameWorldBindTriggerCategory>(entity =>
        {
            entity.ToTable("_RefGameWorldBindTriggerCategory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GameWorldId).HasColumnName("GameWorldID");
            entity.Property(e => e.TriggerCategoryId).HasColumnName("TriggerCategoryID");

            entity.HasOne(d => d.GameWorld).WithMany(p => p.RefGameWorldBindTriggerCategories)
                .HasForeignKey(d => d.GameWorldId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefGameWorldBindTriggerCategory__RefGame_World");

            entity.HasOne(d => d.TriggerCategory).WithMany(p => p.RefGameWorldBindTriggerCategories)
                .HasForeignKey(d => d.TriggerCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefGameWorldBindTriggerCategory__RefTriggerCategory");
        });

        modelBuilder.Entity<RefGameWorldConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefGame_World_Config");

            entity.HasIndex(e => e.GroupCodeName128, "IX__RefGame_World_Config")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.GroupCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Value)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.ValueCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefGameWorldGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RefGroupGameWorld");

            entity.ToTable("_RefGameWorldGroup");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.ConfigGroupCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.ObjName128)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefGameWorldGroupConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RefGroupGameWorld_Config");

            entity.ToTable("_RefGameWorldGroup_Config");

            entity.HasIndex(e => e.GroupCodeName128, "IX__RefGroupGameWorld_Config").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GroupCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Value)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.ValueCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefGameWorldNpc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefGameWorldNPC");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.NpccodeName128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("NPCCodeName128");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.WorldCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefGiftExchangeCoupon>(entity =>
        {
            entity.HasKey(e => e.CouponIndex);

            entity.ToTable("_RefGift_ExchangeCoupon");

            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");

            entity.HasOne(d => d.RefItem).WithMany(p => p.RefGiftExchangeCoupons)
                .HasForeignKey(d => d.RefItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefGift_ExchangeCoupon");
        });

        modelBuilder.Entity<RefGiftExchangeItem>(entity =>
        {
            entity.HasKey(e => new { e.CouponIndex, e.RefItemId });

            entity.ToTable("_RefGift_ExchangeItem");

            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
            entity.Property(e => e.MagicValue)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.RentCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);

            entity.HasOne(d => d.CouponIndexNavigation).WithMany(p => p.RefGiftExchangeItems)
                .HasForeignKey(d => d.CouponIndex)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefGift_ExchangeItem_1");

            entity.HasOne(d => d.RefItem).WithMany(p => p.RefGiftExchangeItems)
                .HasForeignKey(d => d.RefItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefGift_ExchangeItem_2");
        });

        modelBuilder.Entity<RefHwanlevel>(entity =>
        {
            entity.HasKey(e => e.HwanLevel);

            entity.ToTable("_RefHWANLevel");

            entity.Property(e => e.AssocFileObj128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.TitleCh70)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("Title_CH70");
            entity.Property(e => e.TitleEu70)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("Title_EU70");
        });

        modelBuilder.Entity<RefInstanceWorldRegion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefInstance_World_Region");

            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.WorldId).HasColumnName("WorldID");
        });

        modelBuilder.Entity<RefInstanceWorldStartPo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefInstance_World_Start_Pos");

            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.WorldId).HasColumnName("WorldID");
        });

        modelBuilder.Entity<RefItemUpgradeNreinforceRatio>(entity =>
        {
            entity.HasKey(e => new { e.RatioType, e.RatioSubType });

            entity.ToTable("_RefItemUpgradeNReinforceRatio");

            entity.Property(e => e.RatioSubTypeDesc)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("RatioSubType_Desc");
            entity.Property(e => e.RatioTypeDesc)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("RatioType_Desc");
        });

        modelBuilder.Entity<RefLearnRecipeByReqType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefLearnRecipeByReqType");

            entity.Property(e => e.RecipeCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefLevel>(entity =>
        {
            entity.HasKey(e => e.Lvl);

            entity.ToTable("_RefLevel");

            entity.Property(e => e.CostM).HasColumnName("Cost_M");
            entity.Property(e => e.CostSt).HasColumnName("Cost_ST");
            entity.Property(e => e.ExpC).HasColumnName("Exp_C");
            entity.Property(e => e.ExpM).HasColumnName("Exp_M");
            entity.Property(e => e.ExpP).HasColumnName("Exp_P");
            entity.Property(e => e.GustMobExp).HasColumnName("GUST_Mob_Exp");
            entity.Property(e => e.JobExpHunter).HasColumnName("JobExp_Hunter");
            entity.Property(e => e.JobExpRobber).HasColumnName("JobExp_Robber");
            entity.Property(e => e.JobExpTrader).HasColumnName("JobExp_Trader");
            entity.Property(e => e.MaxSp).HasColumnName("MaxSP");
        });

        modelBuilder.Entity<RefMagicOpt>(entity =>
        {
            entity.ToTable("_RefMagicOpt");

            entity.HasIndex(e => new { e.MoptName128, e.Mlevel }, "IX__RefMagicOpt").IsUnique();

            entity.HasIndex(e => e.Mlevel, "IX__RefMagicOpt_MLevel").HasFillFactor(90);

            entity.HasIndex(e => e.MoptName128, "IX__RefMagicOpt_MOptName128").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AttrType)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.AvailItemGroup1)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.AvailItemGroup10)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.AvailItemGroup2)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.AvailItemGroup3)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.AvailItemGroup4)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.AvailItemGroup5)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.AvailItemGroup6)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.AvailItemGroup7)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.AvailItemGroup8)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.AvailItemGroup9)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Mlevel).HasColumnName("MLevel");
            entity.Property(e => e.MoptName128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("MOptName128");
        });

        modelBuilder.Entity<RefMagicOptAssign>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefMagicOptAssign");

            entity.Property(e => e.AvailMopt1)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt1");
            entity.Property(e => e.AvailMopt10)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt10");
            entity.Property(e => e.AvailMopt11)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt11");
            entity.Property(e => e.AvailMopt12)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt12");
            entity.Property(e => e.AvailMopt13)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt13");
            entity.Property(e => e.AvailMopt14)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt14");
            entity.Property(e => e.AvailMopt15)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt15");
            entity.Property(e => e.AvailMopt16)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt16");
            entity.Property(e => e.AvailMopt17)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt17");
            entity.Property(e => e.AvailMopt18)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt18");
            entity.Property(e => e.AvailMopt19)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt19");
            entity.Property(e => e.AvailMopt2)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt2");
            entity.Property(e => e.AvailMopt20)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt20");
            entity.Property(e => e.AvailMopt21)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt21");
            entity.Property(e => e.AvailMopt22)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt22");
            entity.Property(e => e.AvailMopt23)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt23");
            entity.Property(e => e.AvailMopt24)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt24");
            entity.Property(e => e.AvailMopt25)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt25");
            entity.Property(e => e.AvailMopt3)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt3");
            entity.Property(e => e.AvailMopt4)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt4");
            entity.Property(e => e.AvailMopt5)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt5");
            entity.Property(e => e.AvailMopt6)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt6");
            entity.Property(e => e.AvailMopt7)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt7");
            entity.Property(e => e.AvailMopt8)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt8");
            entity.Property(e => e.AvailMopt9)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt9");
            entity.Property(e => e.Tid3).HasColumnName("TID3");
            entity.Property(e => e.Tid4).HasColumnName("TID4");
        });

        modelBuilder.Entity<RefMagicOptAssignForTradeEquip>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefMagicOptAssignForTradeEquip");

            entity.Property(e => e.AvailMopt1)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt1");
            entity.Property(e => e.AvailMopt10)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt10");
            entity.Property(e => e.AvailMopt11)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt11");
            entity.Property(e => e.AvailMopt12)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt12");
            entity.Property(e => e.AvailMopt13)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt13");
            entity.Property(e => e.AvailMopt14)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt14");
            entity.Property(e => e.AvailMopt15)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt15");
            entity.Property(e => e.AvailMopt16)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt16");
            entity.Property(e => e.AvailMopt17)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt17");
            entity.Property(e => e.AvailMopt18)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt18");
            entity.Property(e => e.AvailMopt19)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt19");
            entity.Property(e => e.AvailMopt2)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt2");
            entity.Property(e => e.AvailMopt20)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt20");
            entity.Property(e => e.AvailMopt21)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt21");
            entity.Property(e => e.AvailMopt22)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt22");
            entity.Property(e => e.AvailMopt23)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt23");
            entity.Property(e => e.AvailMopt24)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt24");
            entity.Property(e => e.AvailMopt25)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt25");
            entity.Property(e => e.AvailMopt3)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt3");
            entity.Property(e => e.AvailMopt4)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt4");
            entity.Property(e => e.AvailMopt5)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt5");
            entity.Property(e => e.AvailMopt6)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt6");
            entity.Property(e => e.AvailMopt7)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt7");
            entity.Property(e => e.AvailMopt8)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt8");
            entity.Property(e => e.AvailMopt9)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AvailMOpt9");
            entity.Property(e => e.Tid3).HasColumnName("TID3");
            entity.Property(e => e.Tid4).HasColumnName("TID4");
        });

        modelBuilder.Entity<RefMagicOptByItemOptLevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefMagicOptByItemOptLevel");

            entity.HasIndex(e => new { e.RefMagicOptId, e.Link }, "IX__RefMagicOptByItemOptLevel").IsUnique();

            entity.Property(e => e.RefMagicOptId).HasColumnName("RefMagicOptID");
            entity.Property(e => e.TooltipCodename)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx");

            entity.HasOne(d => d.LinkNavigation).WithMany()
                .HasForeignKey(d => d.Link)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefMagicOptByItemOptLevel__RefAbilityByItemOptLevel");

            entity.HasOne(d => d.RefMagicOpt).WithMany()
                .HasForeignKey(d => d.RefMagicOptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefMagicOptByItemOptLevel__RefMagicOpt1");
        });

        modelBuilder.Entity<RefMagicOptByTitle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefMagicOptByTitle");

            entity.HasIndex(e => new { e.TitleId, e.MagicOptId }, "IX__RefMagicOptByTitle")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.MagicOptId).HasColumnName("MagicOptID");
            entity.Property(e => e.TitleId).HasColumnName("TitleID");

            entity.HasOne(d => d.Title).WithMany()
                .HasForeignKey(d => d.TitleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefMagicOptByTitle");
        });

        modelBuilder.Entity<RefMagicOptGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefMagicOptGroup");

            entity.HasIndex(e => new { e.LinkId, e.MagicType, e.MoptId }, "IX__RefMagicOptGroup").IsUnique();

            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.LinkId).HasColumnName("LinkID");
            entity.Property(e => e.MoptId).HasColumnName("MOptID");
            entity.Property(e => e.MoptLevel).HasColumnName("MOptLevel");
            entity.Property(e => e.Param1Desc)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Param1_Desc");
            entity.Property(e => e.Param2Desc)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Param2_Desc");
        });

        modelBuilder.Entity<RefMappingAlchemyMkShopWithNpc>(entity =>
        {
            entity.HasKey(e => new { e.NpcCodeName, e.ShopCodeName }).HasName("PK_RefMappingAlchemy_MK_Shop_With_NPC");

            entity.ToTable("_RefMappingAlchemy_MK_Shop_With_NPC");

            entity.Property(e => e.NpcCodeName)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("NPC_CodeName");
            entity.Property(e => e.ShopCodeName)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Shop_CodeName");
        });

        modelBuilder.Entity<RefMappingShopGroup>(entity =>
        {
            entity.HasKey(e => new { e.Country, e.RefShopGroupCodeName, e.RefShopCodeName });

            entity.ToTable("_RefMappingShopGroup");

            entity.Property(e => e.RefShopGroupCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.RefShopCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);

            entity.HasOne(d => d.CountryNavigation).WithMany(p => p.RefMappingShopGroups)
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefMappingShopGroup__RefShopObject");
        });

        modelBuilder.Entity<RefMappingShopWithTab>(entity =>
        {
            entity.HasKey(e => new { e.Country, e.RefShopCodeName, e.RefTabGroupCodeName });

            entity.ToTable("_RefMappingShopWithTab");

            entity.Property(e => e.RefShopCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.RefTabGroupCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);

            entity.HasOne(d => d.CountryNavigation).WithMany(p => p.RefMappingShopWithTabs)
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefMappingShopWithTab__RefShopObject");
        });

        modelBuilder.Entity<RefMonsterAssignedItemDrop>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefMonster_AssignedItemDrop");

            entity.Property(e => e.CustomValue1).HasDefaultValue(0);
            entity.Property(e => e.CustomValue2).HasDefaultValue(0);
            entity.Property(e => e.CustomValue3).HasDefaultValue(0);
            entity.Property(e => e.CustomValue4).HasDefaultValue(0);
            entity.Property(e => e.CustomValue5).HasDefaultValue(0);
            entity.Property(e => e.CustomValue6).HasDefaultValue(0);
            entity.Property(e => e.CustomValue7).HasDefaultValue(0);
            entity.Property(e => e.CustomValue8).HasDefaultValue(0);
            entity.Property(e => e.CustomValue9).HasDefaultValue(0);
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
            entity.Property(e => e.RefMagicOptionId1)
                .HasDefaultValue((short)0)
                .HasColumnName("RefMagicOptionID1");
            entity.Property(e => e.RefMagicOptionId2)
                .HasDefaultValue((short)0)
                .HasColumnName("RefMagicOptionID2");
            entity.Property(e => e.RefMagicOptionId3)
                .HasDefaultValue((short)0)
                .HasColumnName("RefMagicOptionID3");
            entity.Property(e => e.RefMagicOptionId4)
                .HasDefaultValue((short)0)
                .HasColumnName("RefMagicOptionID4");
            entity.Property(e => e.RefMagicOptionId5)
                .HasDefaultValue((short)0)
                .HasColumnName("RefMagicOptionID5");
            entity.Property(e => e.RefMagicOptionId6)
                .HasDefaultValue((short)0)
                .HasColumnName("RefMagicOptionID6");
            entity.Property(e => e.RefMagicOptionId7)
                .HasDefaultValue((short)0)
                .HasColumnName("RefMagicOptionID7");
            entity.Property(e => e.RefMagicOptionId8)
                .HasDefaultValue((short)0)
                .HasColumnName("RefMagicOptionID8");
            entity.Property(e => e.RefMagicOptionId9)
                .HasDefaultValue((short)0)
                .HasColumnName("RefMagicOptionID9");
            entity.Property(e => e.RefMonsterId).HasColumnName("RefMonsterID");
            entity.Property(e => e.RentCodeName)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx");

            entity.HasOne(d => d.RefItem).WithMany()
                .HasForeignKey(d => d.RefItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefMonster_AssignedItemDrop__RefObjCommon1");

            entity.HasOne(d => d.RefMonster).WithMany()
                .HasForeignKey(d => d.RefMonsterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefMonster_AssignedItemDrop__RefObjCommon");
        });

        modelBuilder.Entity<RefMonsterAssignedItemRndDrop>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefMonster_AssignedItemRndDrop");

            entity.HasIndex(e => new { e.RefItemGroupId, e.RefMonsterId }, "IX__RefMonster_AssignedItemRndDrop").IsUnique();

            entity.Property(e => e.ItemGroupCodeName128)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Param1).HasColumnName("param1");
            entity.Property(e => e.Param2).HasColumnName("param2");
            entity.Property(e => e.RefItemGroupId).HasColumnName("RefItemGroupID");
            entity.Property(e => e.RefMonsterId).HasColumnName("RefMonsterID");

            entity.HasOne(d => d.RefMonster).WithMany()
                .HasForeignKey(d => d.RefMonsterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefMonster_AssignedItemRndDrop__RefObjCommon");
        });

        modelBuilder.Entity<RefMuhanMonsterTransMask>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefMuhanMonsterTransMask");

            entity.Property(e => e.ObjCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.SkillCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.TransObjCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefMuhanMonsterWave>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefMuhanMonsterWave");

            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.WorldId).HasColumnName("WorldID");
        });

        modelBuilder.Entity<RefNewTradeRewardItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefNewTrade_RewardItem");

            entity.Property(e => e.ObjCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefNewTradeRewardRatio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefNewTrade_RewardRatio");

            entity.Property(e => e.ArrivalName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.DepartureName)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefNonSplitItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefNonSplitItem");

            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
        });

        modelBuilder.Entity<RefObjChar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Char");

            entity.ToTable("_RefObjChar");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Br).HasColumnName("BR");
            entity.Property(e => e.CanStoreTid1).HasColumnName("CanStore_TID1");
            entity.Property(e => e.CanStoreTid2).HasColumnName("CanStore_TID2");
            entity.Property(e => e.CanStoreTid3).HasColumnName("CanStore_TID3");
            entity.Property(e => e.CanStoreTid4).HasColumnName("CanStore_TID4");
            entity.Property(e => e.Chr).HasColumnName("CHR");
            entity.Property(e => e.DefaultSkill1).HasColumnName("DefaultSkill_1");
            entity.Property(e => e.DefaultSkill10).HasColumnName("DefaultSkill_10");
            entity.Property(e => e.DefaultSkill2).HasColumnName("DefaultSkill_2");
            entity.Property(e => e.DefaultSkill3).HasColumnName("DefaultSkill_3");
            entity.Property(e => e.DefaultSkill4).HasColumnName("DefaultSkill_4");
            entity.Property(e => e.DefaultSkill5).HasColumnName("DefaultSkill_5");
            entity.Property(e => e.DefaultSkill6).HasColumnName("DefaultSkill_6");
            entity.Property(e => e.DefaultSkill7).HasColumnName("DefaultSkill_7");
            entity.Property(e => e.DefaultSkill8).HasColumnName("DefaultSkill_8");
            entity.Property(e => e.DefaultSkill9).HasColumnName("DefaultSkill_9");
            entity.Property(e => e.Er).HasColumnName("ER");
            entity.Property(e => e.Except1).HasColumnName("Except_1");
            entity.Property(e => e.Except10).HasColumnName("Except_10");
            entity.Property(e => e.Except2).HasColumnName("Except_2");
            entity.Property(e => e.Except3).HasColumnName("Except_3");
            entity.Property(e => e.Except4).HasColumnName("Except_4");
            entity.Property(e => e.Except5).HasColumnName("Except_5");
            entity.Property(e => e.Except6).HasColumnName("Except_6");
            entity.Property(e => e.Except7).HasColumnName("Except_7");
            entity.Property(e => e.Except8).HasColumnName("Except_8");
            entity.Property(e => e.Except9).HasColumnName("Except_9");
            entity.Property(e => e.Hr).HasColumnName("HR");
            entity.Property(e => e.KoRecoverTime).HasColumnName("KO_RecoverTime");
            entity.Property(e => e.Mar).HasColumnName("MAR");
            entity.Property(e => e.MaxHp).HasColumnName("MaxHP");
            entity.Property(e => e.MaxMp).HasColumnName("MaxMP");
            entity.Property(e => e.Md).HasColumnName("MD");
            entity.Property(e => e.Par).HasColumnName("PAR");
            entity.Property(e => e.Pd).HasColumnName("PD");
            entity.Property(e => e.ResistCseHp).HasColumnName("ResistCseHP");
            entity.Property(e => e.ResistCseInt).HasColumnName("ResistCseINT");
            entity.Property(e => e.ResistCseMd).HasColumnName("ResistCseMD");
            entity.Property(e => e.ResistCseMp).HasColumnName("ResistCseMP");
            entity.Property(e => e.ResistCsePd).HasColumnName("ResistCsePD");
            entity.Property(e => e.ResistCseStr).HasColumnName("ResistCseSTR");
            entity.Property(e => e.ResistEshock).HasColumnName("ResistEShock");
        });

        modelBuilder.Entity<RefObjCharExtraSkill>(entity =>
        {
            entity.HasKey(e => e.CharId);

            entity.ToTable("_RefObjCharExtraSkill");

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");
            entity.Property(e => e.ExtraSkill1).HasColumnName("ExtraSkill_1");
            entity.Property(e => e.ExtraSkill10).HasColumnName("ExtraSkill_10");
            entity.Property(e => e.ExtraSkill11).HasColumnName("ExtraSkill_11");
            entity.Property(e => e.ExtraSkill12).HasColumnName("ExtraSkill_12");
            entity.Property(e => e.ExtraSkill13).HasColumnName("ExtraSkill_13");
            entity.Property(e => e.ExtraSkill14).HasColumnName("ExtraSkill_14");
            entity.Property(e => e.ExtraSkill15).HasColumnName("ExtraSkill_15");
            entity.Property(e => e.ExtraSkill16).HasColumnName("ExtraSkill_16");
            entity.Property(e => e.ExtraSkill17).HasColumnName("ExtraSkill_17");
            entity.Property(e => e.ExtraSkill18).HasColumnName("ExtraSkill_18");
            entity.Property(e => e.ExtraSkill19).HasColumnName("ExtraSkill_19");
            entity.Property(e => e.ExtraSkill2).HasColumnName("ExtraSkill_2");
            entity.Property(e => e.ExtraSkill20).HasColumnName("ExtraSkill_20");
            entity.Property(e => e.ExtraSkill3).HasColumnName("ExtraSkill_3");
            entity.Property(e => e.ExtraSkill4).HasColumnName("ExtraSkill_4");
            entity.Property(e => e.ExtraSkill5).HasColumnName("ExtraSkill_5");
            entity.Property(e => e.ExtraSkill6).HasColumnName("ExtraSkill_6");
            entity.Property(e => e.ExtraSkill7).HasColumnName("ExtraSkill_7");
            entity.Property(e => e.ExtraSkill8).HasColumnName("ExtraSkill_8");
            entity.Property(e => e.ExtraSkill9).HasColumnName("ExtraSkill_9");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<RefObjCharGrow>(entity =>
        {
            entity.ToTable("_RefObjCharGrow");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.Lv1Hp).HasColumnName("Lv1HP");
            entity.Property(e => e.LvUpHp).HasColumnName("LvUpHP");
        });

        modelBuilder.Entity<RefObjCommon>(entity =>
        {
            entity.ToTable("_RefObjCommon");

            entity.HasIndex(e => e.CodeName128, "IX_RefObjCommon_CodeName").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AssocFile1128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AssocFile1_128");
            entity.Property(e => e.AssocFile2128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("AssocFile2_128");
            entity.Property(e => e.AssocFileDrop128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.AssocFileIcon128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.AssocFileObj128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Bcheight).HasColumnName("BCHeight");
            entity.Property(e => e.Bcradius).HasColumnName("BCRadius");
            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.DescStrId128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("DescStrID128");
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.NameStrId128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("NameStrID128");
            entity.Property(e => e.ObjName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OrgObjCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.TypeId1).HasColumnName("TypeID1");
            entity.Property(e => e.TypeId2).HasColumnName("TypeID2");
            entity.Property(e => e.TypeId3).HasColumnName("TypeID3");
            entity.Property(e => e.TypeId4).HasColumnName("TypeID4");
        });

        modelBuilder.Entity<RefObjItem>(entity =>
        {
            entity.ToTable("_RefObjItem");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ammo1Tid4).HasColumnName("Ammo1_TID4");
            entity.Property(e => e.Ammo2Tid4).HasColumnName("Ammo2_TID4");
            entity.Property(e => e.Ammo3Tid4).HasColumnName("Ammo3_TID4");
            entity.Property(e => e.Ammo4Tid4).HasColumnName("Ammo4_TID4");
            entity.Property(e => e.Ammo5Tid4).HasColumnName("Ammo5_TID4");
            entity.Property(e => e.BrL).HasColumnName("BR_L");
            entity.Property(e => e.BrU).HasColumnName("BR_U");
            entity.Property(e => e.ChrL).HasColumnName("CHR_L");
            entity.Property(e => e.ChrU).HasColumnName("CHR_U");
            entity.Property(e => e.Desc10128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Desc10_128");
            entity.Property(e => e.Desc11128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Desc11_128");
            entity.Property(e => e.Desc1128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Desc1_128");
            entity.Property(e => e.Desc12128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Desc12_128");
            entity.Property(e => e.Desc13128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Desc13_128");
            entity.Property(e => e.Desc14128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Desc14_128");
            entity.Property(e => e.Desc15128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Desc15_128");
            entity.Property(e => e.Desc16128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Desc16_128");
            entity.Property(e => e.Desc17128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Desc17_128");
            entity.Property(e => e.Desc18128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Desc18_128");
            entity.Property(e => e.Desc19128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Desc19_128");
            entity.Property(e => e.Desc20128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Desc20_128");
            entity.Property(e => e.Desc2128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Desc2_128");
            entity.Property(e => e.Desc3128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Desc3_128");
            entity.Property(e => e.Desc4128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Desc4_128");
            entity.Property(e => e.Desc5128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Desc5_128");
            entity.Property(e => e.Desc6128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Desc6_128");
            entity.Property(e => e.Desc7128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Desc7_128");
            entity.Property(e => e.Desc8128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Desc8_128");
            entity.Property(e => e.Desc9128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Desc9_128");
            entity.Property(e => e.DurL).HasColumnName("Dur_L");
            entity.Property(e => e.DurU).HasColumnName("Dur_U");
            entity.Property(e => e.ErL).HasColumnName("ER_L");
            entity.Property(e => e.ErU).HasColumnName("ER_U");
            entity.Property(e => e.Erinc).HasColumnName("ERInc");
            entity.Property(e => e.HrL).HasColumnName("HR_L");
            entity.Property(e => e.HrU).HasColumnName("HR_U");
            entity.Property(e => e.Hrinc).HasColumnName("HRInc");
            entity.Property(e => e.MaintMaxL).HasColumnName("MAInt_Max_L");
            entity.Property(e => e.MaintMaxU).HasColumnName("MAInt_Max_U");
            entity.Property(e => e.MaintMinL).HasColumnName("MAInt_Min_L");
            entity.Property(e => e.MaintMinU).HasColumnName("MAInt_Min_U");
            entity.Property(e => e.MarL).HasColumnName("MAR_L");
            entity.Property(e => e.MarU).HasColumnName("MAR_U");
            entity.Property(e => e.Marinc).HasColumnName("MARInc");
            entity.Property(e => e.MattackInc).HasColumnName("MAttackInc");
            entity.Property(e => e.MattackMaxL).HasColumnName("MAttackMax_L");
            entity.Property(e => e.MattackMaxU).HasColumnName("MAttackMax_U");
            entity.Property(e => e.MattackMinL).HasColumnName("MAttackMin_L");
            entity.Property(e => e.MattackMinU).HasColumnName("MAttackMin_U");
            entity.Property(e => e.MdL).HasColumnName("MD_L");
            entity.Property(e => e.MdU).HasColumnName("MD_U");
            entity.Property(e => e.Mdinc).HasColumnName("MDInc");
            entity.Property(e => e.MdintL).HasColumnName("MDInt_L");
            entity.Property(e => e.MdintU).HasColumnName("MDInt_U");
            entity.Property(e => e.ParL).HasColumnName("PAR_L");
            entity.Property(e => e.ParU).HasColumnName("PAR_U");
            entity.Property(e => e.Parinc).HasColumnName("PARInc");
            entity.Property(e => e.PastrMaxL).HasColumnName("PAStrMax_L");
            entity.Property(e => e.PastrMaxU).HasColumnName("PAStrMax_U");
            entity.Property(e => e.PastrMinL).HasColumnName("PAStrMin_L");
            entity.Property(e => e.PastrMinU).HasColumnName("PAStrMin_U");
            entity.Property(e => e.PattackInc).HasColumnName("PAttackInc");
            entity.Property(e => e.PattackMaxL).HasColumnName("PAttackMax_L");
            entity.Property(e => e.PattackMaxU).HasColumnName("PAttackMax_U");
            entity.Property(e => e.PattackMinL).HasColumnName("PAttackMin_L");
            entity.Property(e => e.PattackMinU).HasColumnName("PAttackMin_U");
            entity.Property(e => e.PdL).HasColumnName("PD_L");
            entity.Property(e => e.PdU).HasColumnName("PD_U");
            entity.Property(e => e.Pdinc).HasColumnName("PDInc");
            entity.Property(e => e.PdstrL).HasColumnName("PDStr_L");
            entity.Property(e => e.PdstrU).HasColumnName("PDStr_U");
            entity.Property(e => e.SetId).HasColumnName("SetID");
        });

        modelBuilder.Entity<RefObjStruct>(entity =>
        {
            entity.ToTable("_RefObjStruct");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DummyData).HasColumnName("Dummy_Data");
        });

        modelBuilder.Entity<RefOptionalTeleport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("IX_RefOptionalTeleport");

            entity.ToTable("_RefOptionalTeleport");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DivisionLevel)
                .HasDefaultValue(1)
                .HasColumnName("Division_Level");
            entity.Property(e => e.ObjName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Param1Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Param1_Desc_128");
            entity.Property(e => e.Param2Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Param2_Desc_128");
            entity.Property(e => e.Param3Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Param3_Desc_128");
            entity.Property(e => e.PosX).HasColumnName("Pos_X");
            entity.Property(e => e.PosY).HasColumnName("Pos_Y");
            entity.Property(e => e.PosZ).HasColumnName("Pos_Z");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.RegionIdgroup).HasColumnName("RegionIDGroup");
            entity.Property(e => e.WorldId).HasColumnName("WorldID");
            entity.Property(e => e.ZoneName128)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefPackageItem>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Country });

            entity.ToTable("_RefPackageItem");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.AssocFileIcon)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx");
            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.DescStrId)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("DescStrID");
            entity.Property(e => e.ExpandTerm)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasDefaultValue("xxx");
            entity.Property(e => e.NameStrId)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("NameStrID");
            entity.Property(e => e.Param1Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc128");
            entity.Property(e => e.Param2Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc128");
            entity.Property(e => e.Param3Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc128");
            entity.Property(e => e.Param4Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param4_Desc128");

            entity.HasOne(d => d.CountryNavigation).WithMany(p => p.RefPackageItems)
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefPackageItem__RefShopObject");
        });

        modelBuilder.Entity<RefPath>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RefPath__ID");

            entity.ToTable("_RefPath");

            entity.HasIndex(e => e.Codename, "UK__RefPath__Codename").IsUnique();

            entity.HasIndex(e => e.Name, "UK__RefPath__Name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BehaviorTypeOnMasterDead)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Codename)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ObjectType)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.RelatedWorldId).HasColumnName("RelatedWorldID");
            entity.Property(e => e.RespawnType)
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.HasOne(d => d.BehaviorTypeOnMasterDeadNavigation).WithMany(p => p.RefPathBehaviorTypeOnMasterDeadNavigations)
                .HasForeignKey(d => d.BehaviorTypeOnMasterDead)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefPath_BehaviorTypeOnMasterDead__RefPath_Const__Codename");

            entity.HasOne(d => d.ObjectTypeNavigation).WithMany(p => p.RefPathObjectTypeNavigations)
                .HasForeignKey(d => d.ObjectType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefPath_ObjectType__RefPath_Const__Codename");

            entity.HasOne(d => d.RespawnTypeNavigation).WithMany(p => p.RefPathRespawnTypeNavigations)
                .HasForeignKey(d => d.RespawnType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefPath_RespawnType__RefPath_Const__Codename");
        });

        modelBuilder.Entity<RefPathConfigType>(entity =>
        {
            entity.HasKey(e => e.ConfigCodename).HasName("PK__RefPath_Config_Type__Codename");

            entity.ToTable("_RefPath_Config_Type");

            entity.Property(e => e.ConfigCodename)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefPathConst>(entity =>
        {
            entity.HasKey(e => e.Codename).HasName("PK__RefPath_Const__Codename");

            entity.ToTable("_RefPath_Const");

            entity.Property(e => e.Codename)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ConstType)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefPathFlock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RefPath_Flock__ID");

            entity.ToTable("_RefPath_Flock");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PathId).HasColumnName("PathID");

            entity.HasOne(d => d.Path).WithMany(p => p.RefPathFlocks)
                .HasForeignKey(d => d.PathId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefPath_Flock__RefPath__ID");
        });

        modelBuilder.Entity<RefPathFlockMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RefPath_FlockMember__ID");

            entity.ToTable("_RefPath_FlockMember");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FlockId).HasColumnName("FlockID");
            entity.Property(e => e.TacticsId).HasColumnName("TacticsID");

            entity.HasOne(d => d.Flock).WithMany(p => p.RefPathFlockMembers)
                .HasForeignKey(d => d.FlockId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefPath_Flock__RefFLock__ID");
        });

        modelBuilder.Entity<RefPathPosition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RefPath_Position__ID");

            entity.ToTable("_RefPath_Position");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Codename)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ConfigGroupId).HasColumnName("ConfigGroupID");
            entity.Property(e => e.PathId).HasColumnName("PathID");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");

            entity.HasOne(d => d.ConfigGroup).WithMany(p => p.RefPathPositions)
                .HasForeignKey(d => d.ConfigGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefPath_Position__RefPath_Position_Config_Group__ID");

            entity.HasOne(d => d.Path).WithMany(p => p.RefPathPositions)
                .HasForeignKey(d => d.PathId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefPath_Position__RefPath__ID");
        });

        modelBuilder.Entity<RefPathPositionConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RefPath_Position_Config__ID");

            entity.ToTable("_RefPath_Position_Config");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ConfigCodename)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ConfigGroupId).HasColumnName("ConfigGroupID");
            entity.Property(e => e.Value)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ValueCodename)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ValueType)
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.HasOne(d => d.ConfigCodenameNavigation).WithMany(p => p.RefPathPositionConfigs)
                .HasForeignKey(d => d.ConfigCodename)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefPath_Position_Config__RefPath_Config_Type__ConfigCodename");

            entity.HasOne(d => d.ConfigGroup).WithMany(p => p.RefPathPositionConfigs)
                .HasForeignKey(d => d.ConfigGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefPath_Position_Config__RefPath_Position_Config_Group__ID");
        });

        modelBuilder.Entity<RefPathPositionConfigGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RefPath_Position_Config_Group__ID");

            entity.ToTable("_RefPath_Position_Config_Group");

            entity.HasIndex(e => e.GroupCodename, "UK__RefPath_Position_Config_Group__GroupCodename").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GroupCodename)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefPricePolicyOfItem>(entity =>
        {
            entity.HasKey(e => new { e.RefPackageItemCodeName, e.PaymentDevice, e.Country });

            entity.ToTable("_RefPricePolicyOfItem");

            entity.Property(e => e.RefPackageItemCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Param1Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc128");
            entity.Property(e => e.Param2Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc128");
            entity.Property(e => e.Param3Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc128");
            entity.Property(e => e.Param4Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param4_Desc128");

            entity.HasOne(d => d.CountryNavigation).WithMany(p => p.RefPricePolicyOfItems)
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefPricePolicyOfItem__RefShopObject");
        });

        modelBuilder.Entity<RefQuest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefQuest");

            entity.Property(e => e.CodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ContentsString)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.DescName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.NameString)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.NoticeCondition)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.NoticeNpc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("NoticeNPC");
            entity.Property(e => e.PayContents)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.PayString)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefQuestReward>(entity =>
        {
            entity.HasKey(e => e.QuestId);

            entity.ToTable("_RefQuestReward");

            entity.Property(e => e.QuestId)
                .ValueGeneratedNever()
                .HasColumnName("QuestID");
            entity.Property(e => e.Ap).HasColumnName("AP");
            entity.Property(e => e.Aptype)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("APType");
            entity.Property(e => e.Param1Desc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc");
            entity.Property(e => e.Param2Desc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc");
            entity.Property(e => e.Param3Desc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc");
            entity.Property(e => e.QuestCodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Sp).HasColumnName("SP");
            entity.Property(e => e.Spexp).HasColumnName("SPExp");
        });

        modelBuilder.Entity<RefQuestRewardGrade>(entity =>
        {
            entity.HasKey(e => e.QuestId);

            entity.ToTable("_RefQuestRewardGrade");

            entity.Property(e => e.QuestId)
                .ValueGeneratedNever()
                .HasColumnName("QuestID");
            entity.Property(e => e.QuestCodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.SpexpRate).HasColumnName("SPExpRate");
            entity.Property(e => e.Sprate).HasColumnName("SPRate");
        });

        modelBuilder.Entity<RefQuestRewardItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefQuestRewardItems");

            entity.Property(e => e.ItemCodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.OptionalItemCode)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx");
            entity.Property(e => e.Param1Desc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc");
            entity.Property(e => e.Param2Desc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc");
            entity.Property(e => e.QuestCodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.QuestId).HasColumnName("QuestID");
            entity.Property(e => e.RentItemCodeName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("xxx");
        });

        modelBuilder.Entity<RefRegion>(entity =>
        {
            entity.HasKey(e => e.WRegionId);

            entity.ToTable("_RefRegion");

            entity.Property(e => e.WRegionId)
                .ValueGeneratedNever()
                .HasColumnName("wRegionID");
            entity.Property(e => e.AreaName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.AssocFile256)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.AssocObjId).HasColumnName("AssocObjID");
            entity.Property(e => e.ContinentName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.LinkedRegion1).HasColumnName("LinkedRegion_1");
            entity.Property(e => e.LinkedRegion10).HasColumnName("LinkedRegion_10");
            entity.Property(e => e.LinkedRegion2).HasColumnName("LinkedRegion_2");
            entity.Property(e => e.LinkedRegion3).HasColumnName("LinkedRegion_3");
            entity.Property(e => e.LinkedRegion4).HasColumnName("LinkedRegion_4");
            entity.Property(e => e.LinkedRegion5).HasColumnName("LinkedRegion_5");
            entity.Property(e => e.LinkedRegion6).HasColumnName("LinkedRegion_6");
            entity.Property(e => e.LinkedRegion7).HasColumnName("LinkedRegion_7");
            entity.Property(e => e.LinkedRegion8).HasColumnName("LinkedRegion_8");
            entity.Property(e => e.LinkedRegion9).HasColumnName("LinkedRegion_9");
        });

        modelBuilder.Entity<RefRegionBindAssocServer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefRegionBindAssocServer");

            entity.Property(e => e.AreaName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefRegionBindAssocServerCopy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefRegionBindAssocServer_copy");

            entity.Property(e => e.AreaName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefRegionBindAssocServerCopy1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefRegionBindAssocServer_copy1");

            entity.Property(e => e.AreaName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefRegionBindAssocServerCopy2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefRegionBindAssocServer_copy2");

            entity.Property(e => e.AreaName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefRegionBindAssocServerCopy3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefRegionBindAssocServer_copy3");

            entity.Property(e => e.AreaName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefRegionBindAssocServerCopy4>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefRegionBindAssocServer_copy4");

            entity.Property(e => e.AreaName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefRegionBindAssocServerCopy5>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefRegionBindAssocServer_copy5");

            entity.Property(e => e.AreaName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefRegionBindAssocServerCopy6Live>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefRegionBindAssocServer_copy6_live");

            entity.Property(e => e.AreaName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefRegionBindAssocServerMycenae>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefRegionBindAssocServer_MYCENAE");

            entity.Property(e => e.AreaName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefRegionBindAssocServerRigid>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefRegionBindAssocServer_rigid");

            entity.Property(e => e.AreaName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefRegionBindOptionalFunction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefRegionBindOptionalFunction");

            entity.HasIndex(e => new { e.RegionId, e.WorldId }, "IX__RefRegionBindOptionalFunction").HasFillFactor(90);

            entity.Property(e => e.FunctionId).HasColumnName("FunctionID");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.WorldId).HasColumnName("WorldID");
        });

        modelBuilder.Entity<RefRegionEnterCheckLevel>(entity =>
        {
            entity.HasKey(e => new { e.ContinentName, e.AreaName }).HasName("KEY_RefRegionEnterCheckLevel");

            entity.ToTable("_RefRegionEnterCheckLevel");

            entity.Property(e => e.ContinentName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.AreaName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefRegionRigid>(entity =>
        {
            entity.HasKey(e => e.WRegionId).HasName("PK__RefRegion2");

            entity.ToTable("_RefRegion_rigid");

            entity.Property(e => e.WRegionId)
                .ValueGeneratedNever()
                .HasColumnName("wRegionID");
            entity.Property(e => e.AreaName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.AssocFile256)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.AssocObjId).HasColumnName("AssocObjID");
            entity.Property(e => e.ContinentName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.LinkedRegion1).HasColumnName("LinkedRegion_1");
            entity.Property(e => e.LinkedRegion10).HasColumnName("LinkedRegion_10");
            entity.Property(e => e.LinkedRegion2).HasColumnName("LinkedRegion_2");
            entity.Property(e => e.LinkedRegion3).HasColumnName("LinkedRegion_3");
            entity.Property(e => e.LinkedRegion4).HasColumnName("LinkedRegion_4");
            entity.Property(e => e.LinkedRegion5).HasColumnName("LinkedRegion_5");
            entity.Property(e => e.LinkedRegion6).HasColumnName("LinkedRegion_6");
            entity.Property(e => e.LinkedRegion7).HasColumnName("LinkedRegion_7");
            entity.Property(e => e.LinkedRegion8).HasColumnName("LinkedRegion_8");
            entity.Property(e => e.LinkedRegion9).HasColumnName("LinkedRegion_9");
        });

        modelBuilder.Entity<RefReinforceLimitDegree>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefReinforceLimitDegree");

            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
        });

        modelBuilder.Entity<RefRentItem>(entity =>
        {
            entity.HasKey(e => new { e.RentCodeName, e.RefItemId });

            entity.ToTable("_RefRentItem");

            entity.HasIndex(e => e.RentCodeName, "UQ___RefRent__225D89DC2998A00A").IsUnique();

            entity.Property(e => e.RentCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
            entity.Property(e => e.EndTime).HasColumnType("smalldatetime");
            entity.Property(e => e.Service).HasColumnName("service");
            entity.Property(e => e.StartTime).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<RefRewardPackageItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefRewardPackageItems");

            entity.Property(e => e.PackageRefItemId).HasColumnName("PackageRefItemID");
            entity.Property(e => e.QuestId).HasColumnName("QuestID");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
        });

        modelBuilder.Entity<RefRewardPolicyToBuyScrapItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefRewardPolicyToBuyScrapItem");

            entity.HasIndex(e => new { e.Country, e.Cash, e.TypeId1, e.TypeId2, e.TypeId3, e.TypeId4, e.RefItemCodeName, e.AcceptOrReject, e.FourCc }, "IX__RefRewardPolicyToBuyScrapItem").IsUnique();

            entity.Property(e => e.FourCc).HasColumnName("FourCC");
            entity.Property(e => e.Param1Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc128");
            entity.Property(e => e.Param2Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc128");
            entity.Property(e => e.Param3Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc128");
            entity.Property(e => e.Param4Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param4_Desc128");
            entity.Property(e => e.RefItemCodeName)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.TypeId1).HasColumnName("TypeID1");
            entity.Property(e => e.TypeId2).HasColumnName("TypeID2");
            entity.Property(e => e.TypeId3).HasColumnName("TypeID3");
            entity.Property(e => e.TypeId4).HasColumnName("TypeID4");

            entity.HasOne(d => d.CountryNavigation).WithMany()
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefRewardPolicyToBuyScrapItem__RefShopObject");
        });

        modelBuilder.Entity<RefRewardPolicyToSellPackageItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefRewardPolicyToSellPackageItem");

            entity.HasIndex(e => new { e.Country, e.RefPackageItemCodeName, e.FourCc }, "IX__RefRewardPolicyToSellPackageItem").IsUnique();

            entity.Property(e => e.FourCc).HasColumnName("FourCC");
            entity.Property(e => e.Param1Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc128");
            entity.Property(e => e.Param2Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc128");
            entity.Property(e => e.Param3Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc128");
            entity.Property(e => e.Param4Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param4_Desc128");
            entity.Property(e => e.RefPackageItemCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);

            entity.HasOne(d => d.CountryNavigation).WithMany()
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefRewardPolicyToSellPackageItem__RefShopObject1");
        });

        modelBuilder.Entity<RefRewardPolicyToSellScrapItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefRewardPolicyToSellScrapItem");

            entity.HasIndex(e => new { e.Country, e.Cash, e.TypeId1, e.TypeId2, e.TypeId3, e.TypeId4, e.RefItemCodeName, e.AcceptOrReject, e.FourCc }, "IX__RefRewardPolicyToSellScrapItem").IsUnique();

            entity.Property(e => e.FourCc).HasColumnName("FourCC");
            entity.Property(e => e.Param1Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc128");
            entity.Property(e => e.Param2Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc128");
            entity.Property(e => e.Param3Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc128");
            entity.Property(e => e.Param4Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param4_Desc128");
            entity.Property(e => e.RefItemCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.TypeId1).HasColumnName("TypeID1");
            entity.Property(e => e.TypeId2).HasColumnName("TypeID2");
            entity.Property(e => e.TypeId3).HasColumnName("TypeID3");
            entity.Property(e => e.TypeId4).HasColumnName("TypeID4");

            entity.HasOne(d => d.CountryNavigation).WithMany()
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefRewardPolicyToSellScrapItem__RefShopObject");
        });

        modelBuilder.Entity<RefRndMagicOpt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefRnd_MagicOpt");

            entity.Property(e => e.Mattr1)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("MAttr1");
            entity.Property(e => e.Mattr10)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("MAttr10");
            entity.Property(e => e.Mattr10Ratio).HasColumnName("MAttr10_Ratio");
            entity.Property(e => e.Mattr1Ratio).HasColumnName("MAttr1_Ratio");
            entity.Property(e => e.Mattr2)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("MAttr2");
            entity.Property(e => e.Mattr2Ratio).HasColumnName("MAttr2_Ratio");
            entity.Property(e => e.Mattr3)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("MAttr3");
            entity.Property(e => e.Mattr3Ratio).HasColumnName("MAttr3_Ratio");
            entity.Property(e => e.Mattr4)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("MAttr4");
            entity.Property(e => e.Mattr4Ratio).HasColumnName("MAttr4_Ratio");
            entity.Property(e => e.Mattr5)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("MAttr5");
            entity.Property(e => e.Mattr5Ratio).HasColumnName("MAttr5_Ratio");
            entity.Property(e => e.Mattr6)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("MAttr6");
            entity.Property(e => e.Mattr6Ratio).HasColumnName("MAttr6_Ratio");
            entity.Property(e => e.Mattr7)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("MAttr7");
            entity.Property(e => e.Mattr7Ratio).HasColumnName("MAttr7_Ratio");
            entity.Property(e => e.Mattr8)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("MAttr8");
            entity.Property(e => e.Mattr8Ratio).HasColumnName("MAttr8_Ratio");
            entity.Property(e => e.Mattr9)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("MAttr9");
            entity.Property(e => e.Mattr9Ratio).HasColumnName("MAttr9_Ratio");
            entity.Property(e => e.TypeId3).HasColumnName("TypeID3");
            entity.Property(e => e.TypeId4).HasColumnName("TypeID4");
        });

        modelBuilder.Entity<RefRndMagicOptNumRatio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefRnd_MagicOpt_NumRatio");

            entity.Property(e => e.Grade)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefRollBook>(entity =>
        {
            entity.ToTable("_RefRollBook");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EndDay).HasColumnType("smalldatetime");
            entity.Property(e => e.EventCode)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Param1Desc)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc");
            entity.Property(e => e.Param2Desc)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc");
            entity.Property(e => e.Param3Desc)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc");
            entity.Property(e => e.Param4Desc)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param4_Desc");
            entity.Property(e => e.Param5Desc)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param5_Desc");
            entity.Property(e => e.StartDay).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<RefRollBookPayItemList>(entity =>
        {
            entity.ToTable("_RefRollBook_PayItemList");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.Itemcode)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Param1Desc)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc");
            entity.Property(e => e.Param2Desc)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc");
            entity.Property(e => e.Param3Desc)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc");
            entity.Property(e => e.Param4Desc)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param4_Desc");
            entity.Property(e => e.Param5Desc)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param5_Desc");
        });

        modelBuilder.Entity<RefScheduleDefine>(entity =>
        {
            entity.HasKey(e => e.ScheduleDefineIdx).HasName("PK___RefScheduleDefi__33A895C6");

            entity.ToTable("_RefScheduleDefine");

            entity.Property(e => e.Description)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ScheduleName)
                .HasMaxLength(124)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefScrapOfPackageItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefScrapOfPackageItem");

            entity.Property(e => e.Index).ValueGeneratedOnAdd();
            entity.Property(e => e.Param1Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc128");
            entity.Property(e => e.Param2Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc128");
            entity.Property(e => e.Param3Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc128");
            entity.Property(e => e.Param4Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param4_Desc128");
            entity.Property(e => e.RefItemCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.RefPackageItemCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);

            entity.HasOne(d => d.CountryNavigation).WithMany()
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefScrapOfPackageItem__RefShopObject");
        });

        modelBuilder.Entity<RefServerEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK___RefServ__3214EC276D2EB048");

            entity.ToTable("_RefServerEvent");

            entity.HasIndex(e => e.Name, "IX_RefServerEvent_Name").HasFillFactor(90);

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ActivateClientUi).HasColumnName("ActivateClientUI");
            entity.Property(e => e.BeginDate).HasColumnType("datetime");
            entity.Property(e => e.DetectingTargetId).HasColumnName("DetectingTargetID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefServerEventReward>(entity =>
        {
            entity.HasKey(e => e.RewardId).HasName("PK___RefServ__825015994A6F83F0");

            entity.ToTable("_RefServerEventReward");

            entity.Property(e => e.RewardId).HasColumnName("RewardID");
            entity.Property(e => e.OwnerServerEventId).HasColumnName("OwnerServerEventID");
            entity.Property(e => e.RefRewardId).HasColumnName("RefRewardID");

            entity.HasOne(d => d.OwnerServerEvent).WithMany(p => p.RefServerEventRewards)
                .HasForeignKey(d => d.OwnerServerEventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefServerEventReward__RefServerEvent");
        });

        modelBuilder.Entity<RefServerEventRewardExpUpforPlayer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefServerEventReward_ExpUPForPlayers");

            entity.Property(e => e.ApplyMdamageRatio).HasColumnName("ApplyMDamageRatio");
            entity.Property(e => e.ApplyPdamageRatio).HasColumnName("ApplyPDamageRatio");
            entity.Property(e => e.ApplySexpRatio).HasColumnName("ApplySExpRatio");
            entity.Property(e => e.OwnerRewardId).HasColumnName("OwnerRewardID");

            entity.HasOne(d => d.OwnerReward).WithMany()
                .HasForeignKey(d => d.OwnerRewardId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefServerEventReward_ExpUPForPlayers__RefServerEventReward");
        });

        modelBuilder.Entity<RefServerEventRewardSpawnMonster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefServerEventReward_SpawnMonster");

            entity.HasIndex(e => e.OwnerRewardId, "IX_RefServerEventReward_SpawnMonster")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.OwnerRewardId).HasColumnName("OwnerRewardID");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");

            entity.HasOne(d => d.OwnerReward).WithMany()
                .HasForeignKey(d => d.OwnerRewardId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefServerEventReward_SpawnMonster__RefServerEventReward");
        });

        modelBuilder.Entity<RefSetItemGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefSetItemGroup");

            entity.HasIndex(e => e.Id, "IX__RefSetItemGroup").IsUnique();

            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.DescStrId128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("DescStrID128");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.NameStrId128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("NameStrID128");
            entity.Property(e => e.ObjName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e._10setMoptGroupId).HasColumnName("10SetMOptGroupID");
            entity.Property(e => e._11setMoptGroupId).HasColumnName("11SetMOptGroupID");
            entity.Property(e => e._2setMoptGroupId).HasColumnName("2SetMOptGroupID");
            entity.Property(e => e._3setMoptGroupId).HasColumnName("3SetMOptGroupID");
            entity.Property(e => e._4setMoptGroupId).HasColumnName("4SetMOptGroupID");
            entity.Property(e => e._5setMoptGroupId).HasColumnName("5SetMOptGroupID");
            entity.Property(e => e._6setMoptGroupId).HasColumnName("6SetMOptGroupID");
            entity.Property(e => e._7setMoptGroupId).HasColumnName("7SetMOptGroupID");
            entity.Property(e => e._8setMoptGroupId).HasColumnName("8SetMOptGroupID");
            entity.Property(e => e._9setMoptGroupId).HasColumnName("9SetMOptGroupID");
        });

        modelBuilder.Entity<RefShardContentConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefShardContentConfig");

            entity.HasIndex(e => e.CodeName128, "IX__RefShardContentService")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CodeDesc128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Value)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefShop>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Country }).HasName("PK__RefShop_renewal");

            entity.ToTable("_RefShop");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Param1Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc128");
            entity.Property(e => e.Param2Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc128");
            entity.Property(e => e.Param3Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc128");
            entity.Property(e => e.Param4Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param4_Desc128");

            entity.HasOne(d => d.CountryNavigation).WithMany(p => p.RefShops)
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefShop__RefShopObject");
        });

        modelBuilder.Entity<RefShopGood>(entity =>
        {
            entity.HasKey(e => new { e.Country, e.RefTabCodeName, e.RefPackageItemCodeName }).HasName("PK__RefShopGoods_renewal");

            entity.ToTable("_RefShopGoods");

            entity.Property(e => e.RefTabCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.RefPackageItemCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Param1Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc128");
            entity.Property(e => e.Param2Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc128");
            entity.Property(e => e.Param3Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc128");
            entity.Property(e => e.Param4Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param4_Desc128");

            entity.HasOne(d => d.CountryNavigation).WithMany(p => p.RefShopGoods)
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefShopGoods__RefShopObject");
        });

        modelBuilder.Entity<RefShopGroup>(entity =>
        {
            entity.HasKey(e => new { e.Country, e.Id, e.RefNpccodeName }).HasName("PK__RefShopGroup_renewal");

            entity.ToTable("_RefShopGroup");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RefNpccodeName)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("RefNPCCodeName");
            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Param1Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc128");
            entity.Property(e => e.Param2Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc128");
            entity.Property(e => e.Param3Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc128");
            entity.Property(e => e.Param4Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param4_Desc128");

            entity.HasOne(d => d.CountryNavigation).WithMany(p => p.RefShopGroups)
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefShopGroup__RefShopObject");
        });

        modelBuilder.Entity<RefShopItemGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.ToTable("_RefShopItemGroup");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.StrId128Group)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("StrID128_Group");
        });

        modelBuilder.Entity<RefShopItemStockPeriod>(entity =>
        {
            entity.HasKey(e => new { e.Country, e.RefShopGroupCodeName, e.RefPackageItemCodeName }).HasName("PK__RefShopItemStockQuantity");

            entity.ToTable("_RefShopItemStockPeriod");

            entity.Property(e => e.RefShopGroupCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.RefPackageItemCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.StockExpireDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StockOpeningDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<RefShopObject>(entity =>
        {
            entity.ToTable("_RefShopObject");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefShopTab>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Country }).HasName("PK__RefShopTab_renewal");

            entity.ToTable("_RefShopTab");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.RefTabGroupCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.StrId128Tab)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("StrID128_Tab");

            entity.HasOne(d => d.CountryNavigation).WithMany(p => p.RefShopTabs)
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefShopTab__RefShopObject");
        });

        modelBuilder.Entity<RefShopTabGroup>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Country });

            entity.ToTable("_RefShopTabGroup");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.StrId128Group)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("StrID128_Group");

            entity.HasOne(d => d.CountryNavigation).WithMany(p => p.RefShopTabGroups)
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefShopTabGroup__RefShopObject1");
        });

        modelBuilder.Entity<RefSiegeBlessBuff>(entity =>
        {
            entity.HasKey(e => e.BlessId).HasName("PK___RefSieg__363DD5C5375CAF7C_copy1");

            entity.ToTable("_RefSiegeBlessBuff");

            entity.HasIndex(e => e.FortressId, "IX_RefSiegeBlessBuff_FortressID_copy1").HasFillFactor(90);

            entity.HasIndex(e => e.RefBlessBuffId, "IX_RefSiegeBlessBuff_RefBlessBuffID_copy1").HasFillFactor(90);

            entity.Property(e => e.BlessId).HasColumnName("BlessID");
            entity.Property(e => e.FortressId).HasColumnName("FortressID");
            entity.Property(e => e.NeedGold).HasDefaultValue(0L);
            entity.Property(e => e.NeedGp)
                .HasDefaultValue(0)
                .HasColumnName("NeedGP");
            entity.Property(e => e.RefBlessBuffId).HasColumnName("RefBlessBuffID");

            entity.HasOne(d => d.Fortress).WithMany(p => p.RefSiegeBlessBuffs)
                .HasForeignKey(d => d.FortressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK___RefSiege__Fortr__698907ED");

            entity.HasOne(d => d.RefBlessBuff).WithMany(p => p.RefSiegeBlessBuffs)
                .HasForeignKey(d => d.RefBlessBuffId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK___RefSiege__RefBl__6A7D2C26");
        });

        modelBuilder.Entity<RefSiegeDungeon>(entity =>
        {
            entity.HasKey(e => e.FortressId).HasName("PK___RefSieg__0657D1777E593C4A_copy1");

            entity.ToTable("_RefSiegeDungeon");

            entity.Property(e => e.FortressId)
                .ValueGeneratedNever()
                .HasColumnName("FortressID");
            entity.Property(e => e.EntryGp).HasColumnName("EntryGP");
            entity.Property(e => e.WorldId).HasColumnName("WorldID");
        });

        modelBuilder.Entity<RefSiegeFortress>(entity =>
        {
            entity.HasKey(e => e.FortressId);

            entity.ToTable("_RefSiegeFortress");

            entity.Property(e => e.FortressId).HasColumnName("FortressID");
            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.CrestPath128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.LinkedTeleportCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.NameId128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("NameID128");
            entity.Property(e => e.RequestNpcname128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("RequestNPCName128");
        });

        modelBuilder.Entity<RefSiegeFortressBattleRank>(entity =>
        {
            entity.HasKey(e => e.RankLvl);

            entity.ToTable("_RefSiegeFortressBattleRank");

            entity.Property(e => e.BindedSkillId).HasColumnName("BindedSkillID");
            entity.Property(e => e.CrestPath128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.RankName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.ReqPkcount).HasColumnName("ReqPKCount");
        });

        modelBuilder.Entity<RefSiegeFortressGuard>(entity =>
        {
            entity.HasKey(e => new { e.FortressId, e.GuardRefObjId }).HasName("PK__RefSiegeFortressGuard_copy1");

            entity.ToTable("_RefSiegeFortressGuard");

            entity.Property(e => e.FortressId).HasColumnName("FortressID");
            entity.Property(e => e.GuardRefObjId).HasColumnName("GuardRefObjID");
        });

        modelBuilder.Entity<RefSiegeFortressItemForge>(entity =>
        {
            entity.HasKey(e => new { e.FortressId, e.RefItemId }).HasName("PK__RefSiegeFortressItemForge_copy1");

            entity.ToTable("_RefSiegeFortressItemForge");

            entity.Property(e => e.FortressId).HasColumnName("FortressID");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
            entity.Property(e => e.ReqGp).HasColumnName("ReqGP");
        });

        modelBuilder.Entity<RefSiegeFortressReward>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefSiegeFortressRewards");

            entity.HasIndex(e => e.FortressId, "IX__RefSiegeFortressRewards_FortressID_copy1").HasFillFactor(90);

            entity.Property(e => e.FortressId).HasColumnName("FortressID");
            entity.Property(e => e.RewardTypeId).HasColumnName("RewardTypeID");

            entity.HasOne(d => d.Fortress).WithMany()
                .HasForeignKey(d => d.FortressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK___RefSiege__Fortr__64C452D0");
        });

        modelBuilder.Entity<RefSiegeLvlSummonMonster>(entity =>
        {
            entity.HasKey(e => e.RefObjId);

            entity.ToTable("_RefSiegeLvlSummonMonster");

            entity.Property(e => e.RefObjId)
                .ValueGeneratedNever()
                .HasColumnName("RefObjID");
            entity.Property(e => e.RefOrgObjId).HasColumnName("RefOrgObjID");
        });

        modelBuilder.Entity<RefSiegeQuest>(entity =>
        {
            entity.HasKey(e => e.QuestId).HasName("PK___RefSieg__B6619ACB536EDE45");

            entity.ToTable("_RefSiegeQuest");

            entity.HasIndex(e => e.QuestName, "IX_RefSiegeQuest_QuestName").HasFillFactor(90);

            entity.Property(e => e.QuestId).HasColumnName("QuestID");
            entity.Property(e => e.QuestName)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefSiegeQuestReward>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefSiegeQuestReward");

            entity.HasIndex(e => e.QuestId, "IX_RefSiegeQuestReward_QuestID").HasFillFactor(90);

            entity.Property(e => e.QuestId).HasColumnName("QuestID");
            entity.Property(e => e.RewardRefId).HasColumnName("RewardRefID");
        });

        modelBuilder.Entity<RefSiegeStructUpgrade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefSiegeStructUpgrade");

            entity.Property(e => e.BaseStructcodename)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Structname)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.UpgradeStructname1)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.UpgradeStructname2)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.UpgradeStructname3)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.UpgradeStructname4)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefSkill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK___RefSkill__01C9240F");

            entity.ToTable("_RefSkill");

            entity.HasIndex(e => e.BasicCode, "IX_RefSkill_BasicCode").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActionActionDuration).HasColumnName("Action_ActionDuration");
            entity.Property(e => e.ActionAutoAttackType).HasColumnName("Action_AutoAttackType");
            entity.Property(e => e.ActionCastingTime).HasColumnName("Action_CastingTime");
            entity.Property(e => e.ActionCoolTime).HasColumnName("Action_CoolTime");
            entity.Property(e => e.ActionFlyingSpeed).HasColumnName("Action_FlyingSpeed");
            entity.Property(e => e.ActionInTown).HasColumnName("Action_InTown");
            entity.Property(e => e.ActionInterruptable).HasColumnName("Action_Interruptable");
            entity.Property(e => e.ActionOverlap).HasColumnName("Action_Overlap");
            entity.Property(e => e.ActionPreparingTime).HasColumnName("Action_PreparingTime");
            entity.Property(e => e.ActionRange).HasColumnName("Action_Range");
            entity.Property(e => e.ActionReuseDelay).HasColumnName("Action_ReuseDelay");
            entity.Property(e => e.AiAttackChance).HasColumnName("AI_AttackChance");
            entity.Property(e => e.AiSkillType).HasColumnName("AI_SkillType");
            entity.Property(e => e.BasicActivity).HasColumnName("Basic_Activity");
            entity.Property(e => e.BasicChainCode).HasColumnName("Basic_ChainCode");
            entity.Property(e => e.BasicCode)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("Basic_Code");
            entity.Property(e => e.BasicGroup)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("Basic_Group");
            entity.Property(e => e.BasicLevel).HasColumnName("Basic_Level");
            entity.Property(e => e.BasicName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("Basic_Name");
            entity.Property(e => e.BasicOriginal).HasColumnName("Basic_Original");
            entity.Property(e => e.BasicRecycleCost).HasColumnName("Basic_RecycleCost");
            entity.Property(e => e.ConsumeHp).HasColumnName("Consume_HP");
            entity.Property(e => e.ConsumeHpratio).HasColumnName("Consume_HPRatio");
            entity.Property(e => e.ConsumeMp).HasColumnName("Consume_MP");
            entity.Property(e => e.ConsumeMpratio).HasColumnName("Consume_MPRatio");
            entity.Property(e => e.ConsumeWhan).HasColumnName("Consume_WHAN");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.ReqCastWeapon1).HasColumnName("ReqCast_Weapon1");
            entity.Property(e => e.ReqCastWeapon2).HasColumnName("ReqCast_Weapon2");
            entity.Property(e => e.ReqCommonInt).HasColumnName("ReqCommon_Int");
            entity.Property(e => e.ReqCommonMastery1).HasColumnName("ReqCommon_Mastery1");
            entity.Property(e => e.ReqCommonMastery2).HasColumnName("ReqCommon_Mastery2");
            entity.Property(e => e.ReqCommonMasteryLevel1).HasColumnName("ReqCommon_MasteryLevel1");
            entity.Property(e => e.ReqCommonMasteryLevel2).HasColumnName("ReqCommon_MasteryLevel2");
            entity.Property(e => e.ReqCommonStr).HasColumnName("ReqCommon_Str");
            entity.Property(e => e.ReqLearnRace).HasColumnName("ReqLearn_Race");
            entity.Property(e => e.ReqLearnSkill1).HasColumnName("ReqLearn_Skill1");
            entity.Property(e => e.ReqLearnSkill2).HasColumnName("ReqLearn_Skill2");
            entity.Property(e => e.ReqLearnSkill3).HasColumnName("ReqLearn_Skill3");
            entity.Property(e => e.ReqLearnSkillLevel1).HasColumnName("ReqLearn_SkillLevel1");
            entity.Property(e => e.ReqLearnSkillLevel2).HasColumnName("ReqLearn_SkillLevel2");
            entity.Property(e => e.ReqLearnSkillLevel3).HasColumnName("ReqLearn_SkillLevel3");
            entity.Property(e => e.ReqLearnSp).HasColumnName("ReqLearn_SP");
            entity.Property(e => e.ReqRestriction1).HasColumnName("Req_Restriction1");
            entity.Property(e => e.ReqRestriction2).HasColumnName("Req_Restriction2");
            entity.Property(e => e.TargetEtcSelectDeadBody).HasColumnName("TargetEtc_SelectDeadBody");
            entity.Property(e => e.TargetGroupAlly).HasColumnName("TargetGroup_Ally");
            entity.Property(e => e.TargetGroupDontCare).HasColumnName("TargetGroup_DontCare");
            entity.Property(e => e.TargetGroupEnemyM).HasColumnName("TargetGroup_Enemy_M");
            entity.Property(e => e.TargetGroupEnemyP).HasColumnName("TargetGroup_Enemy_P");
            entity.Property(e => e.TargetGroupNeutral).HasColumnName("TargetGroup_Neutral");
            entity.Property(e => e.TargetGroupParty).HasColumnName("TargetGroup_Party");
            entity.Property(e => e.TargetGroupSelf).HasColumnName("TargetGroup_Self");
            entity.Property(e => e.TargetRequired).HasColumnName("Target_Required");
            entity.Property(e => e.TargetTypeAnimal).HasColumnName("TargetType_Animal");
            entity.Property(e => e.TargetTypeBuilding).HasColumnName("TargetType_Building");
            entity.Property(e => e.TargetTypeLand).HasColumnName("TargetType_Land");
            entity.Property(e => e.UiIconFile)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("UI_IconFile");
            entity.Property(e => e.UiSkillColumn).HasColumnName("UI_SkillColumn");
            entity.Property(e => e.UiSkillName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("UI_SkillName");
            entity.Property(e => e.UiSkillPage).HasColumnName("UI_SkillPage");
            entity.Property(e => e.UiSkillRow).HasColumnName("UI_SkillRow");
            entity.Property(e => e.UiSkillStudyDesc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("UI_SkillStudy_Desc");
            entity.Property(e => e.UiSkillTab).HasColumnName("UI_SkillTab");
            entity.Property(e => e.UiSkillToolTip)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("UI_SkillToolTip");
            entity.Property(e => e.UiSkillToolTipDesc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("UI_SkillToolTip_Desc");
        });

        modelBuilder.Entity<RefSkillByItemOptLevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefSkillByItemOptLevel");

            entity.HasIndex(e => new { e.RefSkillId, e.Link }, "IX__RefSkillByItemOptLevel").IsUnique();

            entity.Property(e => e.RefSkillId).HasColumnName("RefSkillID");

            entity.HasOne(d => d.LinkNavigation).WithMany()
                .HasForeignKey(d => d.Link)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefSkillByItemOptLevel__RefAbilityByItemOptLevel");

            entity.HasOne(d => d.RefSkill).WithMany()
                .HasForeignKey(d => d.RefSkillId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefSkillByItemOptLevel__RefSkill");
        });

        modelBuilder.Entity<RefSkillGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK___RefSkil__3214EC27695E1F64");

            entity.ToTable("_RefSkillGroup");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefSkillMastery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tab_RefSkillMast__23DE44F1");

            entity.ToTable("_RefSkillMastery");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefSroMacro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefSroMacro");

            entity.Property(e => e.HuntingService).HasDefaultValue((byte)0);
            entity.Property(e => e.PotionService).HasDefaultValue((byte)0);
            entity.Property(e => e.SkillService).HasDefaultValue((byte)0);
        });

        modelBuilder.Entity<RefSupportItemByLevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefSupportItemByLevel");

            entity.Property(e => e.ItemCodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefSurvivalPvPoption>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefSurvivalPvPOption");

            entity.HasIndex(e => e.CodeName, "IX__RefSurvivalPVPOption")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CodeDesc)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.CodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Value)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefSurvivalPvpbalance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefSurvivalPVPBalance");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.MasteryId).HasColumnName("MasteryID");
            entity.Property(e => e.SkillId).HasColumnName("SkillID");
            entity.Property(e => e.StatId).HasColumnName("StatID");
        });

        modelBuilder.Entity<RefSurvivalPvpreward>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefSurvivalPVPRewards");

            entity.Property(e => e.MatchingTypeDesc)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("MatchingType_Desc");
            entity.Property(e => e.OutComeDesc)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("OutCome_Desc");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
            entity.Property(e => e.SurvivalTypeDesc)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("SurvivalType_Desc");
        });

        modelBuilder.Entity<RefTeleLink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefTeleLink");

            entity.HasIndex(e => e.OwnerTeleport, "IX__RefTeleLinks").IsClustered();

            entity.Property(e => e.Data11).HasColumnName("Data1_1");
            entity.Property(e => e.Data12).HasColumnName("Data1_2");
            entity.Property(e => e.Data21).HasColumnName("Data2_1");
            entity.Property(e => e.Data22).HasColumnName("Data2_2");
            entity.Property(e => e.Data31).HasColumnName("Data3_1");
            entity.Property(e => e.Data32).HasColumnName("Data3_2");
            entity.Property(e => e.Data41).HasColumnName("Data4_1");
            entity.Property(e => e.Data42).HasColumnName("Data4_2");
            entity.Property(e => e.Data51).HasColumnName("Data5_1");
            entity.Property(e => e.Data52).HasColumnName("Data5_2");
            entity.Property(e => e.DivisionLevel)
                .HasDefaultValue(1)
                .HasColumnName("Division_Level");
        });

        modelBuilder.Entity<RefTeleport>(entity =>
        {
            entity.ToTable("_RefTeleport");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AssocRefObjCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.AssocRefObjId).HasColumnName("AssocRefObjID");
            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.GenPosX).HasColumnName("GenPos_X");
            entity.Property(e => e.GenPosY).HasColumnName("GenPos_Y");
            entity.Property(e => e.GenPosZ).HasColumnName("GenPos_Z");
            entity.Property(e => e.GenRegionId).HasColumnName("GenRegionID");
            entity.Property(e => e.GenWorldId)
                .HasDefaultValue((short)1)
                .HasColumnName("GenWorldID");
            entity.Property(e => e.ZoneName128)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefTitle>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("_RefTitle");

            entity.Property(e => e.TitleId).HasColumnName("TitleID");
            entity.Property(e => e.CodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.EndDay)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.StartDay)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.TitleString)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefTradeConflictClass>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefTradeConflict_Class");

            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.Description128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.PassiveSkill1)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.PassiveSkill2)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.PassiveSkill3)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.PassiveSkill4)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.PassiveSkill5)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefTradeConflictJobLevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefTradeConflict_JobLevel");
        });

        modelBuilder.Entity<RefTradeConflictPromotionReq>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefTradeConflict_PromotionReq");

            entity.Property(e => e.Param1128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Param1_128");
            entity.Property(e => e.Param2128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Param2_128");
            entity.Property(e => e.Param3128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Param3_128");
            entity.Property(e => e.Param4128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Param4_128");
            entity.Property(e => e.Param5128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Param5_128");
        });

        modelBuilder.Entity<RefTradeConflictReputationPoint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefTradeConflict_ReputationPoint");
        });

        modelBuilder.Entity<RefTreatItemOfShop>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefTreatItemOfShop");

            entity.HasIndex(e => new { e.Country, e.RefShopCodeName, e.Cash, e.TypeId1, e.TypeId2, e.TypeId3, e.TypeId4, e.RefItemCodeName, e.AcceptOrReject, e.FourCc }, "IX__RefTreatItemOfShop").IsUnique();

            entity.Property(e => e.FourCc).HasColumnName("FourCC");
            entity.Property(e => e.Param1Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param1_Desc128");
            entity.Property(e => e.Param2Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param2_Desc128");
            entity.Property(e => e.Param3Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param3_Desc128");
            entity.Property(e => e.Param4Desc128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValue("xxx")
                .HasColumnName("Param4_Desc128");
            entity.Property(e => e.RefItemCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.RefShopCodeName)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.TypeId1).HasColumnName("TypeID1");
            entity.Property(e => e.TypeId2).HasColumnName("TypeID2");
            entity.Property(e => e.TypeId3).HasColumnName("TypeID3");
            entity.Property(e => e.TypeId4).HasColumnName("TypeID4");

            entity.HasOne(d => d.CountryNavigation).WithMany()
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefTreatItemOfShop__RefShopObject");
        });

        modelBuilder.Entity<RefTrigger>(entity =>
        {
            entity.ToTable("_RefTrigger");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Comment512)
                .HasMaxLength(513)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefTriggerAction>(entity =>
        {
            entity.ToTable("_RefTriggerAction");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ParamGroupCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.RefTriggerCommonId).HasColumnName("RefTriggerCommonID");

            entity.HasOne(d => d.RefTriggerCommon).WithMany(p => p.RefTriggerActions)
                .HasForeignKey(d => d.RefTriggerCommonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefTriggerAction__RefTriggerCommon");
        });

        modelBuilder.Entity<RefTriggerActionParam>(entity =>
        {
            entity.ToTable("_RefTriggerActionParam");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GroupCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Value)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.ValueCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefTriggerBindAction>(entity =>
        {
            entity.ToTable("_RefTriggerBindAction");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TriggerActionId).HasColumnName("TriggerActionID");
            entity.Property(e => e.TriggerId).HasColumnName("TriggerID");

            entity.HasOne(d => d.TriggerAction).WithMany(p => p.RefTriggerBindActions)
                .HasForeignKey(d => d.TriggerActionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefTriggerBindAction__RefTriggerAction");

            entity.HasOne(d => d.Trigger).WithMany(p => p.RefTriggerBindActions)
                .HasForeignKey(d => d.TriggerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefTriggerBindAction__RefTrigger");
        });

        modelBuilder.Entity<RefTriggerBindCondition>(entity =>
        {
            entity.ToTable("_RefTriggerBindCondition");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TriggerConditionId).HasColumnName("TriggerConditionID");
            entity.Property(e => e.TriggerId).HasColumnName("TriggerID");

            entity.HasOne(d => d.TriggerCondition).WithMany(p => p.RefTriggerBindConditions)
                .HasForeignKey(d => d.TriggerConditionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefTriggerBindCondition__RefTriggerCondition");

            entity.HasOne(d => d.Trigger).WithMany(p => p.RefTriggerBindConditions)
                .HasForeignKey(d => d.TriggerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefTriggerBindCondition__RefTrigger");
        });

        modelBuilder.Entity<RefTriggerBindEvent>(entity =>
        {
            entity.ToTable("_RefTriggerBindEvent");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TriggerEventId).HasColumnName("TriggerEventID");
            entity.Property(e => e.TriggerId).HasColumnName("TriggerID");

            entity.HasOne(d => d.TriggerEvent).WithMany(p => p.RefTriggerBindEvents)
                .HasForeignKey(d => d.TriggerEventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefTriggerBindEvent__RefTriggerEvent");

            entity.HasOne(d => d.Trigger).WithMany(p => p.RefTriggerBindEvents)
                .HasForeignKey(d => d.TriggerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefTriggerBindEvent__RefTrigger");
        });

        modelBuilder.Entity<RefTriggerCategory>(entity =>
        {
            entity.ToTable("_RefTriggerCategory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.ObjName128)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefTriggerCategoryBindTrigger>(entity =>
        {
            entity.ToTable("_RefTriggerCategoryBindTrigger");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TriggerCategoryId).HasColumnName("TriggerCategoryID");
            entity.Property(e => e.TriggerId).HasColumnName("TriggerID");

            entity.HasOne(d => d.Trigger).WithMany(p => p.RefTriggerCategoryBindTriggers)
                .HasForeignKey(d => d.TriggerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefTriggerCategoryBindTrigger__RefTrigger");
        });

        modelBuilder.Entity<RefTriggerCommon>(entity =>
        {
            entity.ToTable("_RefTriggerCommon");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.ObjName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Tid1).HasColumnName("TID1");
            entity.Property(e => e.Tid2).HasColumnName("TID2");
            entity.Property(e => e.Tid3).HasColumnName("TID3");
            entity.Property(e => e.Tid4).HasColumnName("TID4");
        });

        modelBuilder.Entity<RefTriggerCondition>(entity =>
        {
            entity.ToTable("_RefTriggerCondition");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.OnFalse)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OnTrue)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ParamGroupCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.RefTriggerCommonId).HasColumnName("RefTriggerCommonID");

            entity.HasOne(d => d.RefTriggerCommon).WithMany(p => p.RefTriggerConditions)
                .HasForeignKey(d => d.RefTriggerCommonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefTriggerCondition__RefTriggerCommon");
        });

        modelBuilder.Entity<RefTriggerConditionParam>(entity =>
        {
            entity.ToTable("_RefTriggerConditionParam");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GroupCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Value)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.ValueCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefTriggerEvent>(entity =>
        {
            entity.ToTable("_RefTriggerEvent");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.RefTriggerCommonId).HasColumnName("RefTriggerCommonID");

            entity.HasOne(d => d.RefTriggerCommon).WithMany(p => p.RefTriggerEvents)
                .HasForeignKey(d => d.RefTriggerCommonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefTriggerEvent__RefTriggerCommon");
        });

        modelBuilder.Entity<RefTriggerVariable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TriggerVariable");

            entity.ToTable("_RefTriggerVariable");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BindTriggerId).HasColumnName("BindTriggerID");
            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Comment128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(33)
                .IsUnicode(false);

            entity.HasOne(d => d.BindTrigger).WithMany(p => p.RefTriggerVariables)
                .HasForeignKey(d => d.BindTriggerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RefTriggerVariable__RefTrigger");
        });

        modelBuilder.Entity<RefUistringMt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RefDesignString_Mt");

            entity.ToTable("_RefUIString_Mt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GroupCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Value)
                .HasMaxLength(513)
                .IsUnicode(false);
            entity.Property(e => e.ValueCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RefUpgradeEquipItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RefUpgradeEquipItem");

            entity.Property(e => e.BeforeRefId).HasColumnName("BeforeRefID");
            entity.Property(e => e.UpgradeRefId).HasColumnName("UpgradeRefID");
        });

        modelBuilder.Entity<RenameLogChar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RenameLog_Char");

            entity.Property(e => e.NewName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.OldName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.RenameTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<RenameLogGuild>(entity =>
        {
            entity.HasKey(e => e.OldName);

            entity.ToTable("_RenameLog_Guild");

            entity.Property(e => e.OldName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.NewName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.RenameTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<RentItemInfo>(entity =>
        {
            entity.HasKey(e => e.NItemDbid);

            entity.ToTable("_RentItemInfo");

            entity.Property(e => e.NItemDbid)
                .ValueGeneratedNever()
                .HasColumnName("nItemDBID");
            entity.Property(e => e.MeterRateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.NCanDelete).HasColumnName("nCanDelete");
            entity.Property(e => e.NCanRecharge).HasColumnName("nCanRecharge");
            entity.Property(e => e.NPackingState).HasColumnName("nPackingState");
            entity.Property(e => e.NPackingTime).HasColumnName("nPackingTime");
            entity.Property(e => e.NRentType).HasColumnName("nRentType");
            entity.Property(e => e.PeriodBeginTime).HasColumnType("smalldatetime");
            entity.Property(e => e.PeriodEndTime).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<RentItemRepairedLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RentItemRepairedLog");

            entity.Property(e => e.AfterEndTime).HasColumnType("smalldatetime");
            entity.Property(e => e.AfterRateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.BeforeEndTime).HasColumnType("smalldatetime");
            entity.Property(e => e.BeforeRateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.EventTime).HasColumnType("smalldatetime");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
        });

        modelBuilder.Entity<ResultOfPackageItemToMappingWithServerSide>(entity =>
        {
            entity.HasKey(e => new { e.CharId, e.Slot, e.RefItemSerial64, e.RefItemDbid });

            entity.ToTable("_ResultOfPackageItemToMappingWithServerSide");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.RefItemDbid).HasColumnName("RefItemDBID");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
        });

        modelBuilder.Entity<RollBookUserEventDatum>(entity =>
        {
            entity.HasKey(e => new { e.UserJid, e.EventId });

            entity.ToTable("_RollBook_UserEventData");

            entity.Property(e => e.UserJid).HasColumnName("UserJID");
            entity.Property(e => e.EventId).HasColumnName("EventID");
        });

        modelBuilder.Entity<RollBookUserRollDatum>(entity =>
        {
            entity.HasKey(e => new { e.UserJid, e.Year });

            entity.ToTable("_RollBook_UserRollData");

            entity.HasIndex(e => new { e.UserJid, e.Year }, "IX__RollBook_UserRollData").HasFillFactor(90);

            entity.Property(e => e.UserJid).HasColumnName("UserJID");
            entity.Property(e => e.RollData)
                .HasMaxLength(48)
                .IsFixedLength();
        });

        modelBuilder.Entity<SCopy>(entity =>
        {
            entity.HasKey(e => e.Ino).HasName("UC_S_Copy_INO");

            entity.ToTable("S_Copy");

            entity.HasIndex(e => e.Cno, "UI_S_Copy_CNO")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Ino).HasColumnName("INO");
            entity.Property(e => e.Cno)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CNO");
        });

        modelBuilder.Entity<SCopy2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("S_Copy2");

            entity.Property(e => e.Ino).HasColumnName("INO");
        });

        modelBuilder.Entity<SKpiSalesRawDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("S_KPI_SalesRawData");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
            entity.Property(e => e.SalesMonth).HasColumnType("datetime");
            entity.Property(e => e.ShardName)
                .HasMaxLength(4000)
                .UseCollation("Latin1_General_CI_AS");
        });

        modelBuilder.Entity<SUnUsedItems0812>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("S_UnUsedItems_0812");

            entity.Property(e => e.Codename128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Objname128)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleIdx).HasName("PK___Schedule__5BB68720");

            entity.ToTable("_Schedule");

            entity.Property(e => e.DateEnd).HasColumnType("datetime");
            entity.Property(e => e.DateStart).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.MainIntervalType).HasColumnName("MainInterval_Type");
            entity.Property(e => e.MainIntervalTypeDate).HasColumnName("MainInterval_TypeDate");
            entity.Property(e => e.Param)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.SubIntervalDayOfWeek).HasColumnName("SubInterval_DayOfWeek");
            entity.Property(e => e.SubIntervalDays).HasColumnName("SubInterval_Days");
            entity.Property(e => e.SubIntervalDurationSecond).HasColumnName("SubInterval_DurationSecond");
            entity.Property(e => e.SubIntervalMaintainTime).HasColumnName("SubInterval_MaintainTime");
            entity.Property(e => e.SubIntervalMonths).HasColumnName("SubInterval_Months");
            entity.Property(e => e.SubIntervalRepititionTerm).HasColumnName("SubInterval_RepititionTerm");
            entity.Property(e => e.SubIntervalStartTimeHour).HasColumnName("SubInterval_StartTimeHour");
            entity.Property(e => e.SubIntervalStartTimeMinute).HasColumnName("SubInterval_StartTimeMinute");
            entity.Property(e => e.SubIntervalStartTimeSecond).HasColumnName("SubInterval_StartTimeSecond");
            entity.Property(e => e.SubIntervalWeeks).HasColumnName("SubInterval_Weeks");
        });

        modelBuilder.Entity<ScheduleCopy1>(entity =>
        {
            entity.HasKey(e => e.ScheduleIdx).HasName("PK___Schedule__5BB68720_copy1");

            entity.ToTable("_Schedule_copy1");

            entity.Property(e => e.DateEnd).HasColumnType("datetime");
            entity.Property(e => e.DateStart).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.MainIntervalType).HasColumnName("MainInterval_Type");
            entity.Property(e => e.MainIntervalTypeDate).HasColumnName("MainInterval_TypeDate");
            entity.Property(e => e.Param)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.SubIntervalDayOfWeek).HasColumnName("SubInterval_DayOfWeek");
            entity.Property(e => e.SubIntervalDays).HasColumnName("SubInterval_Days");
            entity.Property(e => e.SubIntervalDurationSecond).HasColumnName("SubInterval_DurationSecond");
            entity.Property(e => e.SubIntervalMaintainTime).HasColumnName("SubInterval_MaintainTime");
            entity.Property(e => e.SubIntervalMonths).HasColumnName("SubInterval_Months");
            entity.Property(e => e.SubIntervalRepititionTerm).HasColumnName("SubInterval_RepititionTerm");
            entity.Property(e => e.SubIntervalStartTimeHour).HasColumnName("SubInterval_StartTimeHour");
            entity.Property(e => e.SubIntervalStartTimeMinute).HasColumnName("SubInterval_StartTimeMinute");
            entity.Property(e => e.SubIntervalStartTimeSecond).HasColumnName("SubInterval_StartTimeSecond");
            entity.Property(e => e.SubIntervalWeeks).HasColumnName("SubInterval_Weeks");
        });

        modelBuilder.Entity<ServerEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_ServerEvent");

            entity.HasIndex(e => e.Id, "IX_ServerEvent").IsClustered();

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<ServerEventReward>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_ServerEventReward");

            entity.HasIndex(e => e.RewardId, "IX_ServerEventReward_RewardID");

            entity.HasIndex(e => e.ServerEventId, "IX_ServerEventReward_ServerEventID").IsClustered();

            entity.Property(e => e.RewardId).HasColumnName("RewardID");
            entity.Property(e => e.ServerEventId).HasColumnName("ServerEventID");
        });

        modelBuilder.Entity<ServerGoldStatistic>(entity =>
        {
            entity.HasKey(e => e.SgIdx).HasName("PK__ServerGoldStatistics_SG_IDX");

            entity.ToTable("_ServerGoldStatistics");

            entity.HasIndex(e => e.SgEventTime, "IE__ServerGoldStatistics_SG_EventTime").HasFillFactor(90);

            entity.Property(e => e.SgIdx).HasColumnName("SG_IDX");
            entity.Property(e => e.SgAccountCount).HasColumnName("SG_AccountCount");
            entity.Property(e => e.SgChar).HasColumnName("SG_Char");
            entity.Property(e => e.SgCharCount).HasColumnName("SG_CharCount");
            entity.Property(e => e.SgChest).HasColumnName("SG_Chest");
            entity.Property(e => e.SgEventTime)
                .HasColumnType("datetime")
                .HasColumnName("SG_EventTime");
            entity.Property(e => e.SgFortressBijeokdanTax).HasColumnName("SG_FortressBijeokdanTax");
            entity.Property(e => e.SgFortressConstantiopleTax).HasColumnName("SG_FortressConstantiopleTax");
            entity.Property(e => e.SgFortressDonwhangTax).HasColumnName("SG_FortressDonwhangTax");
            entity.Property(e => e.SgFortressEvilorderTax).HasColumnName("SG_FortressEvilorderTax");
            entity.Property(e => e.SgFortressHeukmakdanTax).HasColumnName("SG_FortressHeukmakdanTax");
            entity.Property(e => e.SgFortressHotanTax).HasColumnName("SG_FortressHotanTax");
            entity.Property(e => e.SgFortressJanganTax).HasColumnName("SG_FortressJanganTax");
            entity.Property(e => e.SgFortressSamarkandTax).HasColumnName("SG_FortressSamarkandTax");
            entity.Property(e => e.SgGuildChest).HasColumnName("SG_GuildChest");
            entity.Property(e => e.SgGuildCount).HasColumnName("SG_GuildCount");
            entity.Property(e => e.SgGuildWarBooty).HasColumnName("SG_GuildWarBooty");
            entity.Property(e => e.SgGuildWarLodgedGold).HasColumnName("SG_GuildWarLodgedGold");
            entity.Property(e => e.SgHunterCount).HasColumnName("SG_HunterCount");
            entity.Property(e => e.SgHunterReward).HasColumnName("SG_HunterReward");
            entity.Property(e => e.SgOpenMarketReceipt).HasColumnName("SG_OpenMarketReceipt");
            entity.Property(e => e.SgRobberCount).HasColumnName("SG_RobberCount");
            entity.Property(e => e.SgRobberReward).HasColumnName("SG_RobberReward");
        });

        modelBuilder.Entity<ShardDbinfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_ShardDBInfo");

            entity.Property(e => e.ShardId).HasColumnName("ShardID");
            entity.Property(e => e.ShardName).HasMaxLength(30);
        });

        modelBuilder.Entity<ShopItemStockQuantity>(entity =>
        {
            entity.HasKey(e => new { e.Country, e.RefShopGroupCodeName, e.RefPackageItemCodeName });

            entity.ToTable("_ShopItemStockQuantity");

            entity.Property(e => e.RefShopGroupCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.RefPackageItemCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ShuffleExploiter>(entity =>
        {
            entity.HasKey(e => e.Jid).HasName("PK_Shuffle_Exploiters");

            entity.ToTable("_Shuffle_Exploiters");

            entity.Property(e => e.Jid)
                .ValueGeneratedNever()
                .HasColumnName("JID");
            entity.Property(e => e.LatestAttempt).HasColumnType("datetime");
        });

        modelBuilder.Entity<ShuffleExploitersBackup>(entity =>
        {
            entity.HasKey(e => e.Jid).HasName("PK_Shuffle_Exploiters_BACKUP");

            entity.ToTable("_Shuffle_Exploiters_BACKUP");

            entity.Property(e => e.Jid)
                .ValueGeneratedNever()
                .HasColumnName("JID");
            entity.Property(e => e.LatestAttempt).HasColumnType("datetime");
        });

        modelBuilder.Entity<ShuffleExploitersBak090804>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_Shuffle_Exploiters_BAK_090804");

            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.LatestAttempt).HasColumnType("datetime");
        });

        modelBuilder.Entity<ShuffleExploitersByIp>(entity =>
        {
            entity.HasKey(e => e.Ip).HasName("PK_Shuffle_ExploitersByIP");

            entity.ToTable("_Shuffle_ExploitersByIP");

            entity.Property(e => e.Ip)
                .ValueGeneratedNever()
                .HasColumnName("IP");
            entity.Property(e => e.LatestAttempt).HasColumnType("datetime");
        });

        modelBuilder.Entity<ShuffleExploitersByIpBak090804>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_Shuffle_ExploitersByIP_BAK_090804");

            entity.Property(e => e.Ip).HasColumnName("IP");
            entity.Property(e => e.LatestAttempt).HasColumnType("datetime");
        });

        modelBuilder.Entity<SiegeFortress>(entity =>
        {
            entity.HasKey(e => e.FortressId);

            entity.ToTable("_SiegeFortress", tb => tb.HasTrigger("_SiegeFortress_TR_U"));

            entity.HasIndex(e => e.GuildId, "IX__SiegeFortress").HasFillFactor(90);

            entity.Property(e => e.FortressId)
                .ValueGeneratedNever()
                .HasColumnName("FortressID");
            entity.Property(e => e.CreatedDungeonCount).HasDefaultValue((byte)0);
            entity.Property(e => e.CreatedDungeonTime).HasColumnType("datetime");
            entity.Property(e => e.GuildId).HasColumnName("GuildID");
            entity.Property(e => e.Introduction)
                .HasMaxLength(121)
                .IsUnicode(false);
            entity.Property(e => e.IntroductionModificationPermission).HasDefaultValue((byte)1);
            entity.Property(e => e.Npchired).HasColumnName("NPCHired");
            entity.Property(e => e.TempGuildId).HasColumnName("TempGuildID");

            entity.HasOne(d => d.Guild).WithMany(p => p.SiegeFortresses)
                .HasForeignKey(d => d.GuildId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SiegeFortress__Guild");
        });

        modelBuilder.Entity<SiegeFortressBattleRecord>(entity =>
        {
            entity.HasKey(e => new { e.FortressId, e.CharId });

            entity.ToTable("_SiegeFortressBattleRecord");

            entity.Property(e => e.FortressId).HasColumnName("FortressID");
            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.RankUpDate).HasColumnType("datetime");

            entity.HasOne(d => d.Fortress).WithMany(p => p.SiegeFortressBattleRecords)
                .HasForeignKey(d => d.FortressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SiegeFortressBattleRecord__SiegeFortress");
        });

        modelBuilder.Entity<SiegeFortressItemForge>(entity =>
        {
            entity.HasKey(e => new { e.FortressId, e.ItemRefId });

            entity.ToTable("_SiegeFortressItemForge");

            entity.Property(e => e.FortressId).HasColumnName("FortressID");
            entity.Property(e => e.ItemRefId).HasColumnName("ItemRefID");
            entity.Property(e => e.Amount).HasDefaultValue((short)1);
            entity.Property(e => e.FinishDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.Fortress).WithMany(p => p.SiegeFortressItemForges)
                .HasForeignKey(d => d.FortressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SiegeFortressItemForge__SiegeFortress");
        });

        modelBuilder.Entity<SiegeFortressObject>(entity =>
        {
            entity.ToTable("_SiegeFortressObject");

            entity.HasIndex(e => e.FortressId, "IX__SiegeFortressObject");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FortressId).HasColumnName("FortressID");
            entity.Property(e => e.Hp).HasColumnName("HP");
            entity.Property(e => e.OwnerGuildId).HasColumnName("OwnerGuildID");
            entity.Property(e => e.RefObjId).HasColumnName("RefObjID");

            entity.HasOne(d => d.Fortress).WithMany(p => p.SiegeFortressObjects)
                .HasForeignKey(d => d.FortressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SiegeFortressObject__SiegeFortress");
        });

        modelBuilder.Entity<SiegeFortressOccupyReward>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_SiegeFortressOccupyReward");

            entity.HasIndex(e => e.FortressId, "IX__SiegeFortressOccupyReward")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.FortressId).HasColumnName("FortressID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
        });

        modelBuilder.Entity<SiegeFortressRequest>(entity =>
        {
            entity.HasKey(e => new { e.FortressId, e.GuildId });

            entity.ToTable("_SiegeFortressRequest");

            entity.Property(e => e.FortressId).HasColumnName("FortressID");
            entity.Property(e => e.GuildId).HasColumnName("GuildID");

            entity.HasOne(d => d.Fortress).WithMany(p => p.SiegeFortressRequests)
                .HasForeignKey(d => d.FortressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SiegeFortressRequest__SiegeFortress");

            entity.HasOne(d => d.Guild).WithMany(p => p.SiegeFortressRequests)
                .HasForeignKey(d => d.GuildId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SiegeFortressRequest__Guild");
        });

        modelBuilder.Entity<SiegeFortressStoneState>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_SiegeFortressStoneState");

            entity.HasIndex(e => e.FortressId, "IX__SiegeFortressStoneState").HasFillFactor(90);

            entity.Property(e => e.FortressId).HasColumnName("FortressID");
            entity.Property(e => e.GuildId).HasColumnName("GuildID");

            entity.HasOne(d => d.Fortress).WithMany()
                .HasForeignKey(d => d.FortressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SiegeFortressStoneState__SiegeFortress");
        });

        modelBuilder.Entity<SiegeFortressStruct>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_SiegeFortressStruct");

            entity.HasIndex(e => e.FortressId, "IX__SiegeFortressStruct");

            entity.Property(e => e.FortressId).HasColumnName("FortressID");
            entity.Property(e => e.Hp).HasColumnName("HP");
            entity.Property(e => e.MakeDate).HasColumnType("datetime");
            entity.Property(e => e.OwnerGuildId).HasColumnName("OwnerGuildID");
            entity.Property(e => e.RefEventStructId).HasColumnName("RefEventStructID");
            entity.Property(e => e.RefObjId).HasColumnName("RefObjID");

            entity.HasOne(d => d.Fortress).WithMany()
                .HasForeignKey(d => d.FortressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SiegeFortressStruct__SiegeFortress");
        });

        modelBuilder.Entity<SilkItemRepairedLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_SilkItemRepairedLog");

            entity.Property(e => e.AccountId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("AccountID");
            entity.Property(e => e.Charname16)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.Type)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SkSilk>(entity =>
        {
            entity.HasKey(e => e.Jid).HasName("PK__SK_Silk__C4DD21B579F422D9");

            entity.ToTable("SK_Silk", tb => tb.HasTrigger("_SK_SILK_TR_U"));

            entity.Property(e => e.Jid)
                .ValueGeneratedNever()
                .HasColumnName("JID");
            entity.Property(e => e.SilkGift).HasColumnName("silk_gift");
            entity.Property(e => e.SilkGiftPremium).HasColumnName("silk_gift_premium");
            entity.Property(e => e.SilkOwn).HasColumnName("silk_own");
            entity.Property(e => e.SilkOwnPremium).HasColumnName("silk_own_premium");
            entity.Property(e => e.SilkPoint).HasColumnName("silk_point");
        });

        modelBuilder.Entity<SroMacroConfigHunting>(entity =>
        {
            entity.HasKey(e => e.CharId)
                .HasName("PK___SroMacr__AA7BC2550CE752C3")
                .IsClustered(false);

            entity.ToTable("_SroMacroConfigHunting");

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");
            entity.Property(e => e.Binary)
                .HasMaxLength(16)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.BinarySize).HasDefaultValue((short)0);
            entity.Property(e => e.MannerMode).HasDefaultValue((byte)0);
            entity.Property(e => e.Service).HasDefaultValue((byte)0);
            entity.Property(e => e.StartHuntingPosX).HasDefaultValue(0f);
            entity.Property(e => e.StartHuntingPosY).HasDefaultValue(0f);
            entity.Property(e => e.StartHuntingPosZ).HasDefaultValue(0f);
            entity.Property(e => e.StartHuntingRegionId)
                .HasDefaultValue((short)0)
                .HasColumnName("StartHuntingRegionID");
            entity.Property(e => e.StartHuntingWorldId)
                .HasDefaultValue((short)0)
                .HasColumnName("StartHuntingWorldID");
            entity.Property(e => e.Version).HasDefaultValue((short)0);
        });

        modelBuilder.Entity<SroMacroConfigHuntingCopy1>(entity =>
        {
            entity.HasKey(e => e.CharId)
                .HasName("PK___SroMacr__AA7BC2550CE752C3_copy1")
                .IsClustered(false);

            entity.ToTable("_SroMacroConfigHunting_copy1");

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");
            entity.Property(e => e.Binary)
                .HasMaxLength(16)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.BinarySize).HasDefaultValue((short)0);
            entity.Property(e => e.MannerMode).HasDefaultValue((byte)0);
            entity.Property(e => e.Service).HasDefaultValue((byte)0);
            entity.Property(e => e.StartHuntingPosX).HasDefaultValue(0f);
            entity.Property(e => e.StartHuntingPosY).HasDefaultValue(0f);
            entity.Property(e => e.StartHuntingPosZ).HasDefaultValue(0f);
            entity.Property(e => e.StartHuntingRegionId)
                .HasDefaultValue((short)0)
                .HasColumnName("StartHuntingRegionID");
            entity.Property(e => e.StartHuntingWorldId)
                .HasDefaultValue((short)0)
                .HasColumnName("StartHuntingWorldID");
            entity.Property(e => e.Version).HasDefaultValue((short)0);
        });

        modelBuilder.Entity<SroMacroConfigPotion>(entity =>
        {
            entity.HasKey(e => e.CharId)
                .HasName("PK___SroMacr__AA7BC25504520CC2")
                .IsClustered(false);

            entity.ToTable("_SroMacroConfigPotion");

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");
            entity.Property(e => e.AutoSummonCos).HasDefaultValue((byte)0);
            entity.Property(e => e.Binary)
                .HasMaxLength(150)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.BinarySize).HasDefaultValue((short)0);
            entity.Property(e => e.Service).HasDefaultValue((byte)0);
            entity.Property(e => e.Version).HasDefaultValue((short)0);
        });

        modelBuilder.Entity<SroMacroConfigPotionCopy1>(entity =>
        {
            entity.HasKey(e => e.CharId)
                .HasName("PK___SroMacr__AA7BC25504520CC2_copy1")
                .IsClustered(false);

            entity.ToTable("_SroMacroConfigPotion_copy1");

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");
            entity.Property(e => e.AutoSummonCos).HasDefaultValue((byte)0);
            entity.Property(e => e.Binary)
                .HasMaxLength(150)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.BinarySize).HasDefaultValue((short)0);
            entity.Property(e => e.Service).HasDefaultValue((byte)0);
            entity.Property(e => e.Version).HasDefaultValue((short)0);
        });

        modelBuilder.Entity<SroMacroConfigSkill>(entity =>
        {
            entity.HasKey(e => e.CharId)
                .HasName("PK___SroMacr__AA7BC25576F811A4")
                .IsClustered(false);

            entity.ToTable("_SroMacroConfigSkill");

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");
            entity.Property(e => e.AttackBinary)
                .HasMaxLength(240)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.AttackBinarySize).HasDefaultValue((short)0);
            entity.Property(e => e.AttackShieldSlotNum).HasDefaultValue((byte)0);
            entity.Property(e => e.AttackWeaponSlotNum).HasDefaultValue((byte)0);
            entity.Property(e => e.BuffBinary)
                .HasMaxLength(240)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.BuffBinarySize).HasDefaultValue((short)0);
            entity.Property(e => e.BuffShieldSlotNum).HasDefaultValue((byte)0);
            entity.Property(e => e.BuffWeaponSlotNum).HasDefaultValue((byte)0);
            entity.Property(e => e.Service).HasDefaultValue((byte)0);
            entity.Property(e => e.Version).HasDefaultValue((short)0);
        });

        modelBuilder.Entity<SroMacroConfigSkillCopy1>(entity =>
        {
            entity.HasKey(e => e.CharId)
                .HasName("PK___SroMacr__AA7BC25576F811A4_copy1")
                .IsClustered(false);

            entity.ToTable("_SroMacroConfigSkill_copy1");

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");
            entity.Property(e => e.AttackBinary)
                .HasMaxLength(240)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.AttackBinarySize).HasDefaultValue((short)0);
            entity.Property(e => e.AttackShieldSlotNum).HasDefaultValue((byte)0);
            entity.Property(e => e.AttackWeaponSlotNum).HasDefaultValue((byte)0);
            entity.Property(e => e.BuffBinary)
                .HasMaxLength(240)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.BuffBinarySize).HasDefaultValue((short)0);
            entity.Property(e => e.BuffShieldSlotNum).HasDefaultValue((byte)0);
            entity.Property(e => e.BuffWeaponSlotNum).HasDefaultValue((byte)0);
            entity.Property(e => e.Service).HasDefaultValue((byte)0);
            entity.Property(e => e.Version).HasDefaultValue((short)0);
        });

        modelBuilder.Entity<StaticAvatar>(entity =>
        {
            entity.HasKey(e => e.CharId);

            entity.ToTable("_StaticAvatar");

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");

            entity.HasOne(d => d.Char).WithOne(p => p.StaticAvatar)
                .HasForeignKey<StaticAvatar>(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StaticAvatar__Char");
        });

        modelBuilder.Entity<StatisticsAbnormalChar>(entity =>
        {
            entity.HasKey(e => e.NIdx).HasName("PK____Statistics_Abn__71A5C83F");

            entity.ToTable("__Statistics_AbnormalChar");

            entity.HasIndex(e => e.DEventTime, "IX___Statistics_AbnormalChar_dEventTime").HasFillFactor(70);

            entity.Property(e => e.NIdx).HasColumnName("nIdx");
            entity.Property(e => e.DEventTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("dEventTime");
            entity.Property(e => e.NCurLevel).HasColumnName("nCurLevel");
            entity.Property(e => e.NDifference).HasColumnName("nDifference");
            entity.Property(e => e.NIntellect).HasColumnName("nIntellect");
            entity.Property(e => e.NMaxLevel).HasColumnName("nMaxLevel");
            entity.Property(e => e.NRemainStat).HasColumnName("nRemainStat");
            entity.Property(e => e.NStrength).HasColumnName("nStrength");
            entity.Property(e => e.SzCharname16)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("szCharname16");
        });

        modelBuilder.Entity<StatisticsCharLastLogout>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("__Statistics_CharLastLogout");

            entity.Property(e => e.LevelBegin).HasColumnName("levelBegin");
            entity.Property(e => e.LevelEnd).HasColumnName("levelEnd");
            entity.Property(e => e.TimeBegin)
                .HasColumnType("datetime")
                .HasColumnName("timeBegin");
            entity.Property(e => e.TimeEnd)
                .HasColumnType("datetime")
                .HasColumnName("timeEnd");
        });

        modelBuilder.Entity<StatisticsGacha>(entity =>
        {
            entity.HasKey(e => e.NIdx).HasName("PK____Statistics_Gac__7299EC78");

            entity.ToTable("__Statistics_Gacha");

            entity.Property(e => e.NIdx).HasColumnName("nIdx");
            entity.Property(e => e.DEventTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("dEventTime");
            entity.Property(e => e.NCount).HasColumnName("nCount");
            entity.Property(e => e.SzCodeName128)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("szCodeName128");
            entity.Property(e => e.SzObjName128)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("szObjName128");
        });

        modelBuilder.Entity<StatisticsGachaByChanneling>(entity =>
        {
            entity.HasKey(e => e.NIdx).HasName("PK____Statis__2EF602B23988B5F9");

            entity.ToTable("__StatisticsGachaByChanneling");

            entity.Property(e => e.NIdx).HasColumnName("nIdx");
            entity.Property(e => e.DEventTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("dEventTime");
            entity.Property(e => e.NCount).HasColumnName("nCount");
            entity.Property(e => e.SzCodeName128)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("szCodeName128");
            entity.Property(e => e.SzObjName128)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("szObjName128");
        });

        modelBuilder.Entity<StatisticsItemsAboveOpt8>(entity =>
        {
            entity.HasKey(e => e.NIdx).HasName("PK____Statistics_Ite__738E10B1");

            entity.ToTable("__Statistics_ItemsAboveOpt8");

            entity.HasIndex(e => e.DEventTime, "IX___Statistics_ItemsAboveOpt8_dEventTime");

            entity.Property(e => e.NIdx).HasColumnName("nIdx");
            entity.Property(e => e.DEventTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("dEventTime");
            entity.Property(e => e.NOptLevel).HasColumnName("nOptLevel");
            entity.Property(e => e.SzCharname16)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("szCharname16");
            entity.Property(e => e.SzCodename128)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("szCodename128");
            entity.Property(e => e.SzType)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("szType");
        });

        modelBuilder.Entity<StatisticsItemsCountInMall>(entity =>
        {
            entity.HasKey(e => e.NIdx).HasName("PK____Statistics_Ite__748234EA");

            entity.ToTable("__Statistics_ItemsCountInMall");

            entity.HasIndex(e => e.DEventTime, "IX___Statistics_ItemsCountInMall_dEventTime");

            entity.Property(e => e.NIdx).HasColumnName("nIdx");
            entity.Property(e => e.DEventTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("dEventTime");
            entity.Property(e => e.NCount).HasColumnName("nCount");
            entity.Property(e => e.SzCodename128)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("szCodename128");
        });

        modelBuilder.Entity<StatisticsItemsGradeOptLevelRare>(entity =>
        {
            entity.HasKey(e => e.NIdx).HasName("PK____Statistics_Ite__75765923");

            entity.ToTable("__Statistics_ItemsGradeOptLevelRare");

            entity.HasIndex(e => e.DEventTime, "IX___Statistics_ItemsGradeOptLevelRare_dEventTime");

            entity.Property(e => e.NIdx).HasColumnName("nIdx");
            entity.Property(e => e.DEventTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("dEventTime");
            entity.Property(e => e.NCount).HasColumnName("nCount");
            entity.Property(e => e.NGrade).HasColumnName("nGrade");
            entity.Property(e => e.NOptLevel).HasColumnName("nOptLevel");
        });

        modelBuilder.Entity<StatisticsItemsGradeOptLvRareMagOpt>(entity =>
        {
            entity.HasKey(e => e.NIdx).HasName("pk_nidx");

            entity.ToTable("__Statistics_ItemsGradeOptLvRareMagOpt");

            entity.HasIndex(e => e.DEventTime, "IX__Statistics_ItemsGradeOptLvRareMagOpt_dEventITime").HasFillFactor(70);

            entity.Property(e => e.NIdx).HasColumnName("nIdx");
            entity.Property(e => e.DEventTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("dEventTime");
            entity.Property(e => e.NAppliedCount).HasColumnName("nAppliedCount");
            entity.Property(e => e.NGrade).HasColumnName("nGrade");
            entity.Property(e => e.NMagOptId).HasColumnName("nMagOptID");
            entity.Property(e => e.NNotAppliedCount).HasColumnName("nNotAppliedCount");
            entity.Property(e => e.NOptLevel).HasColumnName("nOptLevel");
        });

        modelBuilder.Entity<StatisticsItemsOptLevel>(entity =>
        {
            entity.HasKey(e => e.NIdx).HasName("PK____Statistics_Ite__775EA195");

            entity.ToTable("__Statistics_ItemsOptLevel");

            entity.HasIndex(e => e.DEventTime, "IX___Statistics_ItemsOptLevel_dEventTime");

            entity.Property(e => e.NIdx).HasColumnName("nIdx");
            entity.Property(e => e.DEventTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("dEventTime");
            entity.Property(e => e.NCount).HasColumnName("nCount");
            entity.Property(e => e.NOptLevel).HasColumnName("nOptLevel");
            entity.Property(e => e.SzType)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("szType");
        });

        modelBuilder.Entity<StatisticsPerformanceLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("__Statistics_PerformanceLog");

            entity.Property(e => e.LogIssued).HasColumnType("datetime");
            entity.Property(e => e.StepName)
                .HasMaxLength(1024)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StatisticsPetCount>(entity =>
        {
            entity.HasKey(e => e.NIdx).HasName("PK____Statistics_Pet__7852C5CE");

            entity.ToTable("__Statistics_PetCount");

            entity.HasIndex(e => e.DEventTime, "IX___Statistics_PetCount_dEventTime");

            entity.Property(e => e.NIdx).HasColumnName("nIdx");
            entity.Property(e => e.DEventTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("dEventTime");
            entity.Property(e => e.NCount).HasColumnName("nCount");
            entity.Property(e => e.SzCodename128)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("szCodename128");
        });

        modelBuilder.Entity<StatisticsRentItem>(entity =>
        {
            entity.HasKey(e => e.NIdx).HasName("PK____Statistics_Ren__7946EA07");

            entity.ToTable("__Statistics_RentItem");

            entity.Property(e => e.NIdx).HasColumnName("nIdx");
            entity.Property(e => e.DEventTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("dEventTime");
            entity.Property(e => e.NCount).HasColumnName("nCount");
            entity.Property(e => e.NRentType).HasColumnName("nRentType");
            entity.Property(e => e.SzCodename128)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("szCodename128");
        });

        modelBuilder.Entity<StatisticsSystemExchageCoupon>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("__Statistics_SystemExchageCoupon");

            entity.Property(e => e.EventTime).HasColumnType("smalldatetime");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
        });

        modelBuilder.Entity<SupportGoldConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_SupportGoldConfig");

            entity.Property(e => e.ChargeX1).HasColumnName("Charge_x1");
            entity.Property(e => e.ChargeX10).HasColumnName("Charge_x10");
            entity.Property(e => e.ChargeX100).HasColumnName("Charge_x100");
            entity.Property(e => e.ChargeX1000).HasColumnName("Charge_x1000");
            entity.Property(e => e.ChargeX2).HasColumnName("Charge_x2");
            entity.Property(e => e.ChargeX20).HasColumnName("Charge_x20");
            entity.Property(e => e.ChargeX3).HasColumnName("Charge_x3");
            entity.Property(e => e.ChargeX30).HasColumnName("Charge_x30");
            entity.Property(e => e.ChargeX5).HasColumnName("Charge_x5");
            entity.Property(e => e.ChargeX50).HasColumnName("Charge_x50");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<SurvivalPvphallOfFameLastSurviving>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_SurvivalPVPHallOfFame_LastSurviving");

            entity.HasIndex(e => new { e.CharId, e.SeasonIndex, e.MatchingType }, "IX_HallOfFame_LastSurviving")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.ShardId).HasColumnName("ShardID");
        });

        modelBuilder.Entity<SurvivalPvphallOfFamePartyMatching>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_SurvivalPVPHallOfFame_PartyMatching");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.ShardId).HasColumnName("ShardID");
        });

        modelBuilder.Entity<SurvivalPvprecordLastSurviving>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_SurvivalPVPRecord_LastSurviving");

            entity.HasIndex(e => new { e.CharId, e.SeasonIndex, e.MatchingType }, "IX_Record_LastSurviving")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.ShardId).HasColumnName("ShardID");
        });

        modelBuilder.Entity<SurvivalPvprecordLastSurvivingForReward>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_SurvivalPVPRecord_LastSurvivingForReward");

            entity.HasIndex(e => new { e.CharId, e.SeasonIndex }, "IX_Record_LastSurvivingForReward")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CharId).HasColumnName("CharID");
        });

        modelBuilder.Entity<SurvivalPvprecordPartyMatching>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_SurvivalPVPRecord_PartyMatching");

            entity.HasIndex(e => new { e.CharId, e.SeasonIndex, e.MatchingType }, "IX_Record_PartyMatching")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.ShardId).HasColumnName("ShardID");
        });

        modelBuilder.Entity<SurvivalPvprecordPartyMatchingForReward>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_SurvivalPVPRecord_PartyMatchingForReward");

            entity.HasIndex(e => new { e.CharId, e.SeasonIndex }, "IX_Record_PartyMatchingForReward")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CharId).HasColumnName("CharID");
        });

        modelBuilder.Entity<SurvivalPvpseason>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_SurvivalPVPSeasons");

            entity.HasIndex(e => new { e.SeasonIndex, e.SurvivalType }, "IX_SurvivalPVP_Season")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TabDbsafeCheckState>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tab_DBSafe_CheckState");

            entity.Property(e => e.BtCheckIn).HasColumnName("btCheckIn");
        });

        modelBuilder.Entity<TabRefAiskill>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tab_RefAISkill");

            entity.Property(e => e.ConditionMax).HasColumnName("Condition_max");
            entity.Property(e => e.ConditionMin).HasColumnName("Condition_min");
            entity.Property(e => e.SkillCodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.TacticsId).HasColumnName("TacticsID");
        });

        modelBuilder.Entity<TabRefHive>(entity =>
        {
            entity.HasKey(e => e.DwHiveId);

            entity.ToTable("Tab_RefHive");

            entity.Property(e => e.DwHiveId).HasColumnName("dwHiveID");
            entity.Property(e => e.BtFlag).HasColumnName("btFlag");
            entity.Property(e => e.BtKeepMonsterCountType).HasColumnName("btKeepMonsterCountType");
            entity.Property(e => e.DwMaxIncreaseRate).HasColumnName("dwMaxIncreaseRate");
            entity.Property(e => e.DwOverwriteMaxTotalCount).HasColumnName("dwOverwriteMaxTotalCount");
            entity.Property(e => e.DwSpawnSpeedIncreaseRate).HasColumnName("dwSpawnSpeedIncreaseRate");
            entity.Property(e => e.FMonsterCountPerPc).HasColumnName("fMonsterCountPerPC");
            entity.Property(e => e.GameWorldId)
                .HasDefaultValue((short)1)
                .HasColumnName("GameWorldID");
            entity.Property(e => e.HatchObjType).HasDefaultValue((short)1);
            entity.Property(e => e.SzDescString128)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("szDescString128");
        });

        modelBuilder.Entity<TabRefNest>(entity =>
        {
            entity.HasKey(e => e.DwNestId);

            entity.ToTable("Tab_RefNest");

            entity.Property(e => e.DwNestId).HasColumnName("dwNestID");
            entity.Property(e => e.BtFlag).HasColumnName("btFlag");
            entity.Property(e => e.BtRespawn)
                .HasDefaultValue((byte)1)
                .HasColumnName("btRespawn");
            entity.Property(e => e.BtType).HasColumnName("btType");
            entity.Property(e => e.DwDelayTimeMax).HasColumnName("dwDelayTimeMax");
            entity.Property(e => e.DwDelayTimeMin).HasColumnName("dwDelayTimeMin");
            entity.Property(e => e.DwHiveId).HasColumnName("dwHiveID");
            entity.Property(e => e.DwMaxTotalCount).HasColumnName("dwMaxTotalCount");
            entity.Property(e => e.DwTacticsId).HasColumnName("dwTacticsID");
            entity.Property(e => e.FLocalPosX).HasColumnName("fLocalPosX");
            entity.Property(e => e.FLocalPosY).HasColumnName("fLocalPosY");
            entity.Property(e => e.FLocalPosZ).HasColumnName("fLocalPosZ");
            entity.Property(e => e.NChampionGenPercentage).HasColumnName("nChampionGenPercentage");
            entity.Property(e => e.NGenerateRadius).HasColumnName("nGenerateRadius");
            entity.Property(e => e.NRadius).HasColumnName("nRadius");
            entity.Property(e => e.NRegionDbid).HasColumnName("nRegionDBID");
            entity.Property(e => e.WInitialDir).HasColumnName("wInitialDir");
        });

        modelBuilder.Entity<TabRefRankingHunterActivity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tab_RefRanking_HunterActivity");

            entity.Property(e => e.NickName)
                .HasMaxLength(64)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TabRefRankingHunterContribution>(entity =>
        {
            entity.HasKey(e => e.Rank);

            entity.ToTable("Tab_RefRanking_HunterContribution");

            entity.Property(e => e.NickName)
                .HasMaxLength(17)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TabRefRankingRobberActivity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tab_RefRanking_RobberActivity");

            entity.Property(e => e.NickName)
                .HasMaxLength(64)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TabRefRankingRobberContribution>(entity =>
        {
            entity.HasKey(e => e.Rank);

            entity.ToTable("Tab_RefRanking_RobberContribution");

            entity.Property(e => e.NickName)
                .HasMaxLength(17)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TabRefRankingTraderActivity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tab_RefRanking_TraderActivity");

            entity.Property(e => e.NickName)
                .HasMaxLength(17)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
        });

        modelBuilder.Entity<TabRefRankingTraderContribution>(entity =>
        {
            entity.HasKey(e => e.Rank);

            entity.ToTable("Tab_RefRanking_TraderContribution");

            entity.Property(e => e.NickName)
                .HasMaxLength(17)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TabRefSpawnToolVersion>(entity =>
        {
            entity.HasKey(e => e.DwRefDataVersion).HasName("PK__Tab_RefSpawnTool__5DD3D9BC");

            entity.ToTable("Tab_RefSpawnToolVersion");

            entity.Property(e => e.DwRefDataVersion).HasColumnName("dwRefDataVersion");
            entity.Property(e => e.SzVersionDescString)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("szVersionDescString");
        });

        modelBuilder.Entity<TabRefTactic>(entity =>
        {
            entity.HasKey(e => e.DwTacticsId).HasName("PK__Tab_RefTactics2");

            entity.ToTable("Tab_RefTactics");

            entity.Property(e => e.DwTacticsId).HasColumnName("dwTacticsID");
            entity.Property(e => e.BtAggressType).HasColumnName("btAggressType");
            entity.Property(e => e.BtAggressTypeOnHoming).HasColumnName("btAggressTypeOnHoming");
            entity.Property(e => e.BtAggroType).HasColumnName("btAggroType");
            entity.Property(e => e.BtAiqoS).HasColumnName("btAIQoS");
            entity.Property(e => e.BtBattleStyle).HasColumnName("btBattleStyle");
            entity.Property(e => e.BtChangeTarget).HasColumnName("btChangeTarget");
            entity.Property(e => e.BtDiversionBasis).HasColumnName("btDiversionBasis");
            entity.Property(e => e.BtDiversionKeepBasis).HasColumnName("btDiversionKeepBasis");
            entity.Property(e => e.BtFleeType).HasColumnName("btFleeType");
            entity.Property(e => e.BtHelpRequestTo).HasColumnName("btHelpRequestTo");
            entity.Property(e => e.BtHelpResponseTo).HasColumnName("btHelpResponseTo");
            entity.Property(e => e.BtHomingType).HasColumnName("btHomingType");
            entity.Property(e => e.BtKeepDistance).HasColumnName("btKeepDistance");
            entity.Property(e => e.BtMaxStaminaVariance).HasColumnName("btMaxStaminaVariance");
            entity.Property(e => e.BtTraceBoundary).HasColumnName("btTraceBoundary");
            entity.Property(e => e.BtTraceType).HasColumnName("btTraceType");
            entity.Property(e => e.DwChampionTacticsId).HasColumnName("dwChampionTacticsID");
            entity.Property(e => e.DwObjId).HasColumnName("dwObjID");
            entity.Property(e => e.NMaxStamina).HasColumnName("nMaxStamina");
            entity.Property(e => e.NSightRange).HasColumnName("nSightRange");
            entity.Property(e => e.SzDescString128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("szDescString128");
        });

        modelBuilder.Entity<TabRefTacticsOld>(entity =>
        {
            entity.HasKey(e => e.DwTacticsId).HasName("PK__Tab_RefTactics__62065FF3");

            entity.ToTable("Tab_RefTactics_old");

            entity.Property(e => e.DwTacticsId)
                .ValueGeneratedNever()
                .HasColumnName("dwTacticsID");
            entity.Property(e => e.BtAggressType).HasColumnName("btAggressType");
            entity.Property(e => e.BtAggressTypeOnHoming).HasColumnName("btAggressTypeOnHoming");
            entity.Property(e => e.BtAggroType).HasColumnName("btAggroType");
            entity.Property(e => e.BtAiqoS).HasColumnName("btAIQoS");
            entity.Property(e => e.BtBattleStyle).HasColumnName("btBattleStyle");
            entity.Property(e => e.BtChangeTarget).HasColumnName("btChangeTarget");
            entity.Property(e => e.BtDiversionBasis).HasColumnName("btDiversionBasis");
            entity.Property(e => e.BtDiversionKeepBasis).HasColumnName("btDiversionKeepBasis");
            entity.Property(e => e.BtFleeType).HasColumnName("btFleeType");
            entity.Property(e => e.BtHelpRequestTo).HasColumnName("btHelpRequestTo");
            entity.Property(e => e.BtHelpResponseTo).HasColumnName("btHelpResponseTo");
            entity.Property(e => e.BtHomingType).HasColumnName("btHomingType");
            entity.Property(e => e.BtKeepDistance).HasColumnName("btKeepDistance");
            entity.Property(e => e.BtMaxStaminaVariance).HasColumnName("btMaxStaminaVariance");
            entity.Property(e => e.BtTraceBoundary).HasColumnName("btTraceBoundary");
            entity.Property(e => e.BtTraceType).HasColumnName("btTraceType");
            entity.Property(e => e.DwChampionTacticsId).HasColumnName("dwChampionTacticsID");
            entity.Property(e => e.DwObjId).HasColumnName("dwObjID");
            entity.Property(e => e.NMaxStamina).HasColumnName("nMaxStamina");
            entity.Property(e => e.NSightRange).HasColumnName("nSightRange");
            entity.Property(e => e.SzDescString128)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("szDescString128");
        });

        modelBuilder.Entity<TargetInventoryItem>(entity =>
        {
            entity.HasKey(e => new { e.Type, e.OwnerId, e.Slot });

            entity.ToTable("_Target_Inventory_Item");

            entity.HasIndex(e => e.Id64, "IX__Target_Inventory_Item_1").HasFillFactor(80);

            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.Id64).HasColumnName("ID64");
            entity.Property(e => e.OwnerName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Temp100lvChar0309>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Temp_100lvChar0309");

            entity.Property(e => e.Charid).HasColumnName("charid");
            entity.Property(e => e.Charname16)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("charname16");
            entity.Property(e => e.Curlevel).HasColumnName("curlevel");
        });

        modelBuilder.Entity<Temp13thEquipOptlevel8Over>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_13th_equip_optlevel_8_over");

            entity.Property(e => e.AccountId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Chinese_Taiwan_Stroke_CI_AS")
                .HasColumnName("AccountID");
            entity.Property(e => e.Id64).HasColumnName("ID64");
            entity.Property(e => e.ObjName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<Temp13thEquipOptlevel8OverLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_13th_equip_optlevel_8_over_log");

            entity.Property(e => e.Account)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.ObjName)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Temp13thEquipOptlevel8OverTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_13th_equip_optlevel_8_over_temp");

            entity.Property(e => e.AccountId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Chinese_Taiwan_Stroke_CI_AS")
                .HasColumnName("AccountID");
            entity.Property(e => e.Id64).HasColumnName("ID64");
            entity.Property(e => e.ObjName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<Temp13thEquipUpgradeList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_13th_equip_upgrade_list");

            entity.Property(e => e.Account)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Chinese_Taiwan_Stroke_CI_AS");
            entity.Property(e => e.CharacterName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.DbServerName)
                .HasMaxLength(128)
                .HasColumnName("DB(Server)Name");
            entity.Property(e => e.Jid).HasColumnName("JID");
        });

        modelBuilder.Entity<TempAdditemexternChestLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_TEMP_ADDITEMEXTERN_CHEST_LOG");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LogDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LogString)
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempAdditemexternChestLogTmp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_TEMP_ADDITEMEXTERN_CHEST_LOG_TMP");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LogDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LogString)
                .HasMaxLength(256)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
        });

        modelBuilder.Entity<TempAdditemexternLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_TEMP_ADDITEMEXTERN_LOG");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LogDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LogString)
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempAlliedClan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_TempAlliedClans");

            entity.Property(e => e.FoundationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<TempCanRewardList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Temp_CanRewardList");

            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<TempCannotRewardList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Temp_CannotRewardList");

            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<TempChar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_TempChar");

            entity.Property(e => e.CharId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CharID");
            entity.Property(e => e.CharName16)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.DailyPk).HasColumnName("DailyPK");
            entity.Property(e => e.GuildId).HasColumnName("GuildID");
            entity.Property(e => e.Hp).HasColumnName("HP");
            entity.Property(e => e.HunterExp).HasColumnName("Hunter_Exp");
            entity.Property(e => e.JobLvlHunter).HasColumnName("JobLvl_Hunter");
            entity.Property(e => e.JobLvlRobber).HasColumnName("JobLvl_Robber");
            entity.Property(e => e.JobLvlTrader).HasColumnName("JobLvl_Trader");
            entity.Property(e => e.LastLogout).HasColumnType("smalldatetime");
            entity.Property(e => e.Mp).HasColumnName("MP");
            entity.Property(e => e.NickName16)
                .HasMaxLength(17)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.PkpenaltyPoint).HasColumnName("PKPenaltyPoint");
            entity.Property(e => e.RefObjId).HasColumnName("RefObjID");
            entity.Property(e => e.RobberExp).HasColumnName("Robber_Exp");
            entity.Property(e => e.SexpOffset).HasColumnName("SExpOffset");
            entity.Property(e => e.TotalPk).HasColumnName("TotalPK");
            entity.Property(e => e.Tpp).HasColumnName("TPP");
            entity.Property(e => e.TraderExp).HasColumnName("Trader_Exp");
        });

        modelBuilder.Entity<TempChest>(entity =>
        {
            entity.HasKey(e => new { e.UserJid, e.ShardId, e.Slot }).HasName("PK__TEMPCHEST");

            entity.ToTable("_TempChest");

            entity.Property(e => e.UserJid).HasColumnName("UserJID");
            entity.Property(e => e.ShardId).HasColumnName("ShardID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
        });

        modelBuilder.Entity<TempDeathCharSf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_temp_DeathChar_sf");

            entity.HasIndex(e => e.Charid, "IX__temp_DeathChar_sf").HasFillFactor(90);

            entity.Property(e => e.Accountid)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("accountid");
            entity.Property(e => e.Charid).HasColumnName("charid");
            entity.Property(e => e.Charip)
                .HasMaxLength(16)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("charip");
            entity.Property(e => e.Charname)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("charname");
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("country");
            entity.Property(e => e.Ip).HasColumnName("IP");
            entity.Property(e => e.Jid).HasColumnName("jid");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Shard)
                .HasMaxLength(32)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("shard");
        });

        modelBuilder.Entity<TempDropitem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_temp_dropitem");

            entity.Property(e => e.Itemrefid)
                .ValueGeneratedOnAdd()
                .HasColumnName("itemrefid");
        });

        modelBuilder.Entity<TempGachaitem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_temp_gachaitem");

            entity.Property(e => e.Itemrefid)
                .ValueGeneratedOnAdd()
                .HasColumnName("itemrefid");
        });

        modelBuilder.Entity<TempGuild>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_TempGuild");

            entity.Property(e => e.FoundationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.GatheredSp).HasColumnName("GatheredSP");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.MasterComment)
                .HasMaxLength(2049)
                .IsUnicode(false);
            entity.Property(e => e.MasterCommentTitle)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
        });

        modelBuilder.Entity<TempGuildChest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_GUILD_CHEST");

            entity.HasIndex(e => e.GuildId, "IX_GuildID")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.CreaterName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.GuildId).HasColumnName("GuildID");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
        });

        modelBuilder.Entity<TempInvalidEquipSlotItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_InvalidEquipSlotItem");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.Charname16)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("charname16");
            entity.Property(e => e.CodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
            entity.Property(e => e.Serial64).HasColumnName("serial64");
            entity.Property(e => e.Shard)
                .HasMaxLength(128)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("shard");
        });

        modelBuilder.Entity<TempItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_TempItems");

            entity.Property(e => e.CreaterName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Id64)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID64");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
        });

        modelBuilder.Entity<TempItem1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_item");

            entity.Property(e => e.Cnt).HasColumnName("cnt");
            entity.Property(e => e.Optlevel).HasColumnName("optlevel");
            entity.Property(e => e.Refitemid).HasColumnName("refitemid");
        });

        modelBuilder.Entity<TempItemPay>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_TempItemPay");

            entity.Property(e => e.ItemCodeName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.TypeId4).HasColumnName("TypeID4");
        });

        modelBuilder.Entity<TempItemlistTimedjobRelated>(entity =>
        {
            entity.HasKey(e => e.RefItemId).HasName("PK__TEMP_ITEMLIST_TI__581B0066");

            entity.ToTable("TEMP_ITEMLIST_TIMEDJOB_RELATED");

            entity.Property(e => e.RefItemId)
                .ValueGeneratedNever()
                .HasColumnName("RefItemID");
            entity.Property(e => e.Codename)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("codename");
        });

        modelBuilder.Entity<TempJobLevelOverCharacter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_TEMP_JOB_LEVEL_OVER_CHARACTER");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.UserAccountName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<TempOpt15overItem100320>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_opt15overItem_100320");

            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ObjName)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempRemovedStaleChar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_TempRemovedStaleChar");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.CharName)
                .HasMaxLength(17)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.StrDesc)
                .HasMaxLength(256)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("strDesc");
            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<TempRewardItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TEMP_Rew__3214EC2715606C7A");

            entity.ToTable("TEMP_Reward_Item");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempUserList>(entity =>
        {
            entity.HasKey(e => e.Seq).HasName("PK__TEMP_Use__CA1938C07C94BEB0");

            entity.ToTable("TEMP_User_List");

            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.AccountId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("AccountID");
            entity.Property(e => e.MaxLastLogout).HasColumnType("smalldatetime");
            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<TempUserMaxLevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_Temp_UserMaxLevel");

            entity.Property(e => e.Maxlevel).HasColumnName("maxlevel");
            entity.Property(e => e.Time)
                .HasColumnType("datetime")
                .HasColumnName("time");
            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<TempUserRewardLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_User_Reward_LOG");

            entity.Property(e => e.Account)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.RewardItem)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TestTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TestTable");

            entity.Property(e => e.Idx).HasColumnName("IDX");
            entity.Property(e => e.Ratio).HasColumnName("ratio");
        });

        modelBuilder.Entity<TimeService>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TimeService");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<TimedJob>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("_TimedJob");

            entity.HasIndex(e => e.CharId, "IX_TimedJob").IsClustered();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.Data3).HasDefaultValue(0);
            entity.Property(e => e.Data4).HasDefaultValue(0);
            entity.Property(e => e.Data5).HasDefaultValue(0);
            entity.Property(e => e.Data6).HasDefaultValue(0);
            entity.Property(e => e.Data7).HasDefaultValue(0);
            entity.Property(e => e.Data8).HasDefaultValue(0);
            entity.Property(e => e.JobId).HasColumnName("JobID");

            entity.HasOne(d => d.Char).WithMany(p => p.TimedJobs)
                .HasForeignKey(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TimedJob__Char");
        });

        modelBuilder.Entity<TimedJobCopy>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK___TimedJo__3214EC261A414DE1")
                .IsClustered(false);

            entity.ToTable("_TimedJob_copy");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.Data3).HasDefaultValue(0);
            entity.Property(e => e.Data4).HasDefaultValue(0);
            entity.Property(e => e.Data5).HasDefaultValue(0);
            entity.Property(e => e.Data6).HasDefaultValue(0);
            entity.Property(e => e.Data7).HasDefaultValue(0);
            entity.Property(e => e.Data8).HasDefaultValue(0);
            entity.Property(e => e.Jid)
                .HasDefaultValue(0)
                .HasColumnName("JID");
            entity.Property(e => e.JobId).HasColumnName("JobID");

            entity.HasOne(d => d.Char).WithMany(p => p.TimedJobCopies)
                .HasForeignKey(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK___TimedJob__CharI__23CAB81B");
        });

        modelBuilder.Entity<TimedJobForPet>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("_TimedJobForPet");

            entity.HasIndex(e => e.CharId, "IX_TimedJobForPet").IsClustered();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.Data3).HasDefaultValue(0);
            entity.Property(e => e.Data4).HasDefaultValue(0);
            entity.Property(e => e.Data5).HasDefaultValue(0);
            entity.Property(e => e.Data6).HasDefaultValue(0);
            entity.Property(e => e.Data7).HasDefaultValue(0);
            entity.Property(e => e.Data8).HasDefaultValue(0);
            entity.Property(e => e.JobId).HasColumnName("JobID");
        });

        modelBuilder.Entity<TimedJobForPetCopy>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK___TimedJo__3214EC2626A724C6")
                .IsClustered(false);

            entity.ToTable("_TimedJobForPet_copy");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.Data3).HasDefaultValue(0);
            entity.Property(e => e.Data4).HasDefaultValue(0);
            entity.Property(e => e.Data5).HasDefaultValue(0);
            entity.Property(e => e.Data6).HasDefaultValue(0);
            entity.Property(e => e.Data7).HasDefaultValue(0);
            entity.Property(e => e.Data8).HasDefaultValue(0);
            entity.Property(e => e.Jid)
                .HasDefaultValue(0)
                .HasColumnName("JID");
            entity.Property(e => e.JobId).HasColumnName("JobID");
        });

        modelBuilder.Entity<TraceItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("__TRACE_ITEM");

            entity.Property(e => e.CodeName128)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ReportedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TradeBagInventory>(entity =>
        {
            entity.HasKey(e => new { e.CharId, e.Slot });

            entity.ToTable("_TradeBagInventory");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");

            entity.HasOne(d => d.Char).WithMany(p => p.TradeBagInventories)
                .HasForeignKey(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TradeBagInventory__Char");

            entity.HasOne(d => d.Item).WithMany(p => p.TradeBagInventories)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TradeBagInventory__Items");
        });

        modelBuilder.Entity<TradeEquipInventory>(entity =>
        {
            entity.HasKey(e => new { e.CharId, e.Slot });

            entity.ToTable("_TradeEquipInventory");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");

            entity.HasOne(d => d.Char).WithMany(p => p.TradeEquipInventories)
                .HasForeignKey(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TradeEquipInventory__Char");

            entity.HasOne(d => d.Item).WithMany(p => p.TradeEquipInventories)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TradeEquipInventory__Items");
        });

        modelBuilder.Entity<TrainingCamp>(entity =>
        {
            entity.ToTable("_TrainingCamp");

            entity.HasIndex(e => e.EvaluationPoint, "IX_TrainingCamp_EvaluationPoint");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comment)
                .HasMaxLength(2048)
                .IsUnicode(false);
            entity.Property(e => e.CommentTitle)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.LatestEvaluationDate).HasColumnType("datetime");
            entity.Property(e => e.Rank).HasDefaultValue((byte)5);
        });

        modelBuilder.Entity<TrainingCampBuffStatus>(entity =>
        {
            entity.HasKey(e => new { e.CampId, e.RecipientCharId, e.BuffSlotIdx });

            entity.ToTable("_TrainingCampBuffStatus");

            entity.Property(e => e.CampId).HasColumnName("CampID");
            entity.Property(e => e.RecipientCharId).HasColumnName("RecipientCharID");
            entity.Property(e => e.DonorCharId).HasColumnName("DonorCharID");
            entity.Property(e => e.StartingTime)
                .HasDefaultValue(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<TrainingCampHonorRank>(entity =>
        {
            entity.HasKey(e => e.Ranking);

            entity.ToTable("_TrainingCampHonorRank");

            entity.Property(e => e.Ranking).ValueGeneratedNever();
            entity.Property(e => e.CampId).HasColumnName("CampID");
        });

        modelBuilder.Entity<TrainingCampHonorRankUpdateDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_TrainingCampHonorRankUpdateDate");

            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TrainingCampMember>(entity =>
        {
            entity.HasKey(e => new { e.CampId, e.CharId });

            entity.ToTable("_TrainingCampMember");

            entity.HasIndex(e => e.CharId, "IX__TrainingCampMember_CharID");

            entity.Property(e => e.CampId).HasColumnName("CampID");
            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.CharName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.JoinDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RefObjId).HasColumnName("RefObjID");

            entity.HasOne(d => d.Camp).WithMany(p => p.TrainingCampMembers)
                .HasForeignKey(d => d.CampId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TrainingCampMember__TrainingCamp");

            entity.HasOne(d => d.Char).WithMany(p => p.TrainingCampMembers)
                .HasForeignKey(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TrainingCampMember__Char");
        });

        modelBuilder.Entity<TrainingCampSubMentorHonorPoint>(entity =>
        {
            entity.HasKey(e => e.CharId);

            entity.ToTable("_TrainingCampSubMentorHonorPoint");

            entity.Property(e => e.CharId)
                .ValueGeneratedNever()
                .HasColumnName("CharID");

            entity.HasOne(d => d.Char).WithOne(p => p.TrainingCampSubMentorHonorPoint)
                .HasForeignKey<TrainingCampSubMentorHonorPoint>(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TrainingCampSubMentorHonorPoint__Char");
        });

        modelBuilder.Entity<TrijobRanking4Web>(entity =>
        {
            entity.HasKey(e => new { e.TrijobType, e.RankType, e.Rank });

            entity.ToTable("_TrijobRanking4WEB");

            entity.HasIndex(e => e.NickName, "IX__TrijobRanking4WEB").HasFillFactor(90);

            entity.Property(e => e.NickName)
                .HasMaxLength(64)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrijobReward>(entity =>
        {
            entity.HasKey(e => e.JobType);

            entity.ToTable("_TrijobRewards");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_User");

            entity.HasIndex(e => e.CharId, "IX__CharID").IsUnique();

            entity.HasIndex(e => e.UserJid, "IX__User").IsClustered();

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.UserJid).HasColumnName("UserJID");

            entity.HasOne(d => d.Char).WithOne()
                .HasForeignKey<User>(d => d.CharId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__User__Char");

            entity.HasOne(d => d.UserJ).WithMany()
                .HasPrincipalKey(p => p.Jid)
                .HasForeignKey(d => d.UserJid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__User__AccountJID");
        });

        modelBuilder.Entity<UserFestivalScore>(entity =>
        {
            entity.HasKey(e => e.UserJid);

            entity.ToTable("_UserFestivalScore");

            entity.Property(e => e.UserJid)
                .ValueGeneratedNever()
                .HasColumnName("UserJID");
            entity.Property(e => e.AccountId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("AccountID");

            entity.HasOne(d => d.UserJ).WithOne(p => p.UserFestivalScore)
                .HasPrincipalKey<AccountJid>(p => p.Jid)
                .HasForeignKey<UserFestivalScore>(d => d.UserJid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserFestivalScore__UserJID");
        });

        modelBuilder.Entity<UserOld>(entity =>
        {
            entity.HasKey(e => e.UserJid).HasName("PK__UserCharList");

            entity.ToTable("_UserOld");

            entity.Property(e => e.UserJid)
                .ValueGeneratedNever()
                .HasColumnName("UserJID");
            entity.Property(e => e.CharId1).HasColumnName("CharID1");
            entity.Property(e => e.CharId2).HasColumnName("CharID2");
            entity.Property(e => e.CharId3).HasColumnName("CharID3");
        });

        modelBuilder.Entity<UserTradeConflictJob>(entity =>
        {
            entity.HasKey(e => e.UserJid);

            entity.ToTable("_UserTradeConflictJob");

            entity.Property(e => e.UserJid)
                .ValueGeneratedNever()
                .HasColumnName("UserJID");
            entity.Property(e => e.RegDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<_20100329Buybuguser2E12g>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("20100329_BUYBUGUSER2_E12G");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.Item)
                .HasMaxLength(129)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("item");
        });

        modelBuilder.Entity<_20100329BuybuguserLogE12g>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("20100329_BUYBUGUSER_LOG_E12G");

            entity.Property(e => e.Addgold).HasColumnName("ADDGOLD");
            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Item)
                .HasMaxLength(129)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("ITEM");
            entity.Property(e => e.Time)
                .HasColumnType("datetime")
                .HasColumnName("time");
        });

        modelBuilder.Entity<_GameServerRefMonsterDropData>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.ToTable("_GameServerRefMonsterDropData");
        });
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
