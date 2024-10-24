using BimBot.Database.SILKROAD_R_ACCOUNT;
using Microsoft.EntityFrameworkCore;

namespace BimBot.Database.Context;

public partial class SILKROAD_R_ACCOUNT : DbContext
{
    public SILKROAD_R_ACCOUNT()
    {
    }

    public virtual DbSet<AspsessionState> AspsessionStates { get; set; }

    public virtual DbSet<BlockedUser> BlockedUsers { get; set; }

    public virtual DbSet<BrutalBlockedIp> BrutalBlockedIps { get; set; }

    public virtual DbSet<CasDatum> CasData { get; set; }

    public virtual DbSet<CasGmchatLog> CasGmchatLogs { get; set; }

    public virtual DbSet<CmProxyServerIp> CmProxyServerIps { get; set; }

    public virtual DbSet<CraftedMacroLazyBlockingList> CraftedMacroLazyBlockingLists { get; set; }

    public virtual DbSet<CraftedMacroPunishmentHistory> CraftedMacroPunishmentHistories { get; set; }

    public virtual DbSet<EventGiveItemInfo> EventGiveItemInfos { get; set; }

    public virtual DbSet<EventGiveItemList> EventGiveItemLists { get; set; }

    public virtual DbSet<EventTicket20130611> EventTicket20130611s { get; set; }

    public virtual DbSet<FatigueSystemResetPlayTime> FatigueSystemResetPlayTimes { get; set; }

    public virtual DbSet<FreeAccess> FreeAccesses { get; set; }

    public virtual DbSet<GameInstantTicket> GameInstantTickets { get; set; }

    public virtual DbSet<GmConnectionNumForNation> GmConnectionNumForNations { get; set; }

    public virtual DbSet<JcCrmRLoginGathering> JcCrmRLoginGatherings { get; set; }

    public virtual DbSet<JcCrmRLoginGathering1> JcCrmRLoginGathering1s { get; set; }

    public virtual DbSet<JcCrmRLoginGathering2> JcCrmRLoginGathering2s { get; set; }

    public virtual DbSet<JcCrmRLoginGathering3> JcCrmRLoginGathering3s { get; set; }

    public virtual DbSet<JcCrmRLoginGathering4> JcCrmRLoginGathering4s { get; set; }

    public virtual DbSet<JcCrmRLoginGathering5> JcCrmRLoginGathering5s { get; set; }

    public virtual DbSet<JcCrmRLoginGathering6> JcCrmRLoginGathering6s { get; set; }

    public virtual DbSet<JcCrmRLoginGathering7> JcCrmRLoginGathering7s { get; set; }

    public virtual DbSet<JcCrmRLogoutGathering> JcCrmRLogoutGatherings { get; set; }

    public virtual DbSet<JcCrmRLogoutGathering1> JcCrmRLogoutGathering1s { get; set; }

    public virtual DbSet<JcCrmRLogoutGathering2> JcCrmRLogoutGathering2s { get; set; }

    public virtual DbSet<JcCrmRLogoutGathering3> JcCrmRLogoutGathering3s { get; set; }

    public virtual DbSet<JcCrmRLogoutGathering4> JcCrmRLogoutGathering4s { get; set; }

    public virtual DbSet<JcCrmRLogoutGathering5> JcCrmRLogoutGathering5s { get; set; }

    public virtual DbSet<JcCrmRLogoutGathering6> JcCrmRLogoutGathering6s { get; set; }

    public virtual DbSet<JcCrmRLogoutGathering7> JcCrmRLogoutGathering7s { get; set; }

    public virtual DbSet<JcCrmRServerGathering> JcCrmRServerGatherings { get; set; }

    public virtual DbSet<JcCrmRServerGathering1> JcCrmRServerGathering1s { get; set; }

    public virtual DbSet<JcCrmRServerGathering2> JcCrmRServerGathering2s { get; set; }

    public virtual DbSet<JcCrmRServerGathering3> JcCrmRServerGathering3s { get; set; }

    public virtual DbSet<JcCrmRServerGathering4> JcCrmRServerGathering4s { get; set; }

    public virtual DbSet<JcCrmRServerGathering5> JcCrmRServerGathering5s { get; set; }

    public virtual DbSet<JcCrmRServerGathering6> JcCrmRServerGathering6s { get; set; }

    public virtual DbSet<JcCrmRServerGathering7> JcCrmRServerGathering7s { get; set; }

    public virtual DbSet<LogEventSilk> LogEventSilks { get; set; }

    public virtual DbSet<LoginEventCalendar> LoginEventCalendars { get; set; }

    public virtual DbSet<LoginEventReward> LoginEventRewards { get; set; }

    public virtual DbSet<LoginEventRewardLog> LoginEventRewardLogs { get; set; }

    public virtual DbSet<LoginLogoutIntegration> LoginLogoutIntegrations { get; set; }

    public virtual DbSet<LoginLogoutStatistic> LoginLogoutStatistics { get; set; }

    public virtual DbSet<LoginLogoutStatistics2> LoginLogoutStatistics2s { get; set; }

    public virtual DbSet<LoginLogoutStatistics2BackUp> LoginLogoutStatistics2BackUps { get; set; }

    public virtual DbSet<LoginLogoutStatisticsBackUp> LoginLogoutStatisticsBackUps { get; set; }

    public virtual DbSet<MagicLampCleaner> MagicLampCleaners { get; set; }

    public virtual DbSet<MagicLampCleanerHistory> MagicLampCleanerHistories { get; set; }

    public virtual DbSet<MagicLampDetail> MagicLampDetails { get; set; }

    public virtual DbSet<MagicLampErrorLog> MagicLampErrorLogs { get; set; }

    public virtual DbSet<MagicLampHistory> MagicLampHistories { get; set; }

    public virtual DbSet<MagicLampList> MagicLampLists { get; set; }

    public virtual DbSet<MagicLampMain> MagicLampMains { get; set; }

    public virtual DbSet<ModuleVersion> ModuleVersions { get; set; }

    public virtual DbSet<ModuleVersionFile> ModuleVersionFiles { get; set; }

    public virtual DbSet<Notice> Notices { get; set; }

    public virtual DbSet<OldBlockedUser> OldBlockedUsers { get; set; }

    public virtual DbSet<OldUser> OldUsers { get; set; }

    public virtual DbSet<PrivilegedIp> PrivilegedIps { get; set; }

    public virtual DbSet<PrivilegedIp2> PrivilegedIp2s { get; set; }

    public virtual DbSet<PrivilegedSmcip> PrivilegedSmcips { get; set; }

    public virtual DbSet<Punishment> Punishments { get; set; }

    public virtual DbSet<RecvWebCashItemHistory> RecvWebCashItemHistories { get; set; }

    public virtual DbSet<RefCountryNameAndCode> RefCountryNameAndCodes { get; set; }

    public virtual DbSet<RefObjCommon> RefObjCommons { get; set; }

    public virtual DbSet<ResultBuyCashItemList> ResultBuyCashItemLists { get; set; }

    public virtual DbSet<RigidDonationLog2018> RigidDonationLog2018s { get; set; }

    public virtual DbSet<RigidItemNameDesc> RigidItemNameDescs { get; set; }

    public virtual DbSet<RigidLoginEvent> RigidLoginEvents { get; set; }

    public virtual DbSet<RigidLoginEventCalendar> RigidLoginEventCalendars { get; set; }

    public virtual DbSet<RigidLoginEventCalendarPlaytime> RigidLoginEventCalendarPlaytimes { get; set; }

    public virtual DbSet<RigidLoginEventReward> RigidLoginEventRewards { get; set; }

    public virtual DbSet<RigidLoginEventRewardLog> RigidLoginEventRewardLogs { get; set; }

    public virtual DbSet<SLoginAttempt> SLoginAttempts { get; set; }

    public virtual DbSet<SManualBlockedUserH> SManualBlockedUserHs { get; set; }

    public virtual DbSet<SSilkChangingLog> SSilkChangingLogs { get; set; }

    public virtual DbSet<SSilkItemBuyLog> SSilkItemBuyLogs { get; set; }

    public virtual DbSet<SecondaryPassword> SecondaryPasswords { get; set; }

    public virtual DbSet<SecurityDescription> SecurityDescriptions { get; set; }

    public virtual DbSet<SecurityDescriptionGroup> SecurityDescriptionGroups { get; set; }

    public virtual DbSet<SecurityDescriptionGroupAssign> SecurityDescriptionGroupAssigns { get; set; }

    public virtual DbSet<ServiceManagerLog> ServiceManagerLogs { get; set; }

    public virtual DbSet<Shard> Shards { get; set; }

    public virtual DbSet<ShardCurrentUser> ShardCurrentUsers { get; set; }

    public virtual DbSet<ShardCurrentUserByChanneling> ShardCurrentUserByChannelings { get; set; }

    public virtual DbSet<ShardFlatRateService> ShardFlatRateServices { get; set; }

    public virtual DbSet<ShardService> ShardServices { get; set; }

    public virtual DbSet<SiegeFortressStatus> SiegeFortressStatuses { get; set; }

    public virtual DbSet<SiegeFortressStatus8> SiegeFortressStatus8s { get; set; }

    public virtual DbSet<SkEmailCertifyKey> SkEmailCertifyKeys { get; set; }

    public virtual DbSet<SkGamebangIp> SkGamebangIps { get; set; }

    public virtual DbSet<SkShl> SkShls { get; set; }

    public virtual DbSet<SkSilk> SkSilks { get; set; }

    public virtual DbSet<SkSilkChangeByWeb> SkSilkChangeByWebs { get; set; }

    public virtual DbSet<SkSilkGood> SkSilkGoods { get; set; }

    public virtual DbSet<Smclog> Smclogs { get; set; }

    public virtual DbSet<SrCharName> SrCharNames { get; set; }

    public virtual DbSet<SrMaxLevelPerAccount> SrMaxLevelPerAccounts { get; set; }

    public virtual DbSet<SrShardCharName> SrShardCharNames { get; set; }

    public virtual DbSet<StCrmGatheringResultLog> StCrmGatheringResultLogs { get; set; }

    public virtual DbSet<StRCharPtime> StRCharPtimes { get; set; }

    public virtual DbSet<SupAdmin> SupAdmins { get; set; }

    public virtual DbSet<SupAdminLog> SupAdminLogs { get; set; }

    public virtual DbSet<SupMenuCate> SupMenuCates { get; set; }

    public virtual DbSet<SupMenuCateUse> SupMenuCateUses { get; set; }

    public virtual DbSet<TbUser> TbUsers { get; set; }

    public virtual DbSet<TbUserBackup> TbUserBackups { get; set; }

    public virtual DbSet<TbUserChannel> TbUserChannels { get; set; }

    public virtual DbSet<TempRewardItem> TempRewardItems { get; set; }

    public virtual DbSet<TempTable> TempTables { get; set; }

    public virtual DbSet<TempUserList> TempUserLists { get; set; }

    public virtual DbSet<TempUserRewardLog> TempUserRewardLogs { get; set; }

    public virtual DbSet<TemporalyBlockedIphistory> TemporalyBlockedIphistories { get; set; }

    public virtual DbSet<TestStatistic> TestStatistics { get; set; }

    public virtual DbSet<TrijobRanking> TrijobRankings { get; set; }

    public virtual DbSet<TrijobRankingStatus> TrijobRankingStatuses { get; set; }

    public virtual DbSet<VoteAnswer> VoteAnswers { get; set; }

    public virtual DbSet<VoteMain> VoteMains { get; set; }

    public virtual DbSet<VoteQuestion> VoteQuestions { get; set; }

    public virtual DbSet<VoteUser> VoteUsers { get; set; }

    public virtual DbSet<VoteUserDetail> VoteUserDetails { get; set; }

    public virtual DbSet<VwJcCrmRLoginGathering> VwJcCrmRLoginGatherings { get; set; }

    public virtual DbSet<VwJcCrmRLogoutGathering> VwJcCrmRLogoutGatherings { get; set; }

    public virtual DbSet<VwJcCrmRServerGathering> VwJcCrmRServerGatherings { get; set; }

    public virtual DbSet<VwWebMallList> VwWebMallLists { get; set; }

    public virtual DbSet<VwWebPackageItemList> VwWebPackageItemLists { get; set; }

    public virtual DbSet<WebAboutSilkErrorLog> WebAboutSilkErrorLogs { get; set; }

    public virtual DbSet<WebAboutSilkErrorLog1> WebAboutSilkErrorLogs1 { get; set; }

    public virtual DbSet<WebActionLog> WebActionLogs { get; set; }

    public virtual DbSet<WebEvtItemBuy> WebEvtItemBuys { get; set; }

    public virtual DbSet<WebItemBuyErrorLog> WebItemBuyErrorLogs { get; set; }

    public virtual DbSet<WebItemCertifykey> WebItemCertifykeys { get; set; }

    public virtual DbSet<WebItemGiveList> WebItemGiveLists { get; set; }

    public virtual DbSet<WebItemGiveListDetail> WebItemGiveListDetails { get; set; }

    public virtual DbSet<WebItemGiveNotice> WebItemGiveNotices { get; set; }

    public virtual DbSet<WebItemPopular> WebItemPopulars { get; set; }

    public virtual DbSet<WebItemRentInfo> WebItemRentInfos { get; set; }

    public virtual DbSet<WebItemReserved> WebItemReserveds { get; set; }

    public virtual DbSet<WebMallCategory> WebMallCategories { get; set; }

    public virtual DbSet<WebMallCategorySub> WebMallCategorySubs { get; set; }

    public virtual DbSet<WebMessageBox> WebMessageBoxes { get; set; }

    public virtual DbSet<WebMessageBoxR> WebMessageBoxRs { get; set; }

    public virtual DbSet<WebPackageItem> WebPackageItems { get; set; }

    public virtual DbSet<WebPackageItemDetail> WebPackageItemDetails { get; set; }

    public virtual DbSet<WebPackageItemLang> WebPackageItemLangs { get; set; }

    public virtual DbSet<WebPackageItemMall> WebPackageItemMalls { get; set; }

    public virtual DbSet<WebPackageItemPreview> WebPackageItemPreviews { get; set; }

    public virtual DbSet<WebVoteAnswer> WebVoteAnswers { get; set; }

    public virtual DbSet<WebVoteItem> WebVoteItems { get; set; }

    public virtual DbSet<WebVoteMain> WebVoteMains { get; set; }

    public virtual DbSet<WebVoteQuestion> WebVoteQuestions { get; set; }

    public virtual DbSet<WebVoteUser> WebVoteUsers { get; set; }

    public virtual DbSet<WebVoteUserDetail> WebVoteUserDetails { get; set; }

    public virtual DbSet<WorldIp> WorldIps { get; set; }

    public virtual DbSet<WorldIptemp> WorldIptemps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(DatabaseManager.SroVtAccountConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Korean_Wansung_CI_AS");

        modelBuilder.Entity<AspsessionState>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ASPSessionState");

            entity.HasIndex(e => e.Guid, "idxSessionStateGUID");

            entity.Property(e => e.Guid)
                .HasMaxLength(38)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GUID");
            entity.Property(e => e.SessionKey)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.SessionValue)
                .HasMaxLength(254)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BlockedUser>(entity =>
        {
            entity.HasKey(e => new { e.UserJid, e.Type }).HasName("PK__BlockedUser__1");

            entity.ToTable("_BlockedUser");

            entity.Property(e => e.UserJid).HasColumnName("UserJID");
            entity.Property(e => e.TimeBegin)
                .HasColumnType("datetime")
                .HasColumnName("timeBegin");
            entity.Property(e => e.TimeEnd)
                .HasColumnType("datetime")
                .HasColumnName("timeEnd");
            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<BrutalBlockedIp>(entity =>
        {
            entity.HasKey(e => e.NIdx);

            entity.ToTable("_BrutalBlockedIP");

            entity.Property(e => e.NIdx).HasColumnName("nIdx");
            entity.Property(e => e.DIssueDate)
                .HasColumnType("datetime")
                .HasColumnName("dIssueDate");
            entity.Property(e => e.SzDesc)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("szDesc");
            entity.Property(e => e.SzGm)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("szGM");
            entity.Property(e => e.SzIpbegin)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("szIPBegin");
            entity.Property(e => e.SzIpend)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("szIPEnd");
            entity.Property(e => e.SzIsp)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("szISP");
        });

        modelBuilder.Entity<CasDatum>(entity =>
        {
            entity.HasKey(e => e.NSerial).HasName("PK___CasData__0F382DC6");

            entity.ToTable("_CasData");

            entity.Property(e => e.NSerial).HasColumnName("nSerial");
            entity.Property(e => e.BtUserChecked).HasColumnName("btUserChecked");
            entity.Property(e => e.DProcessDate)
                .HasColumnType("datetime")
                .HasColumnName("dProcessDate");
            entity.Property(e => e.DReportDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dReportDate");
            entity.Property(e => e.DwUserJid).HasColumnName("dwUserJID");
            entity.Property(e => e.NCategory).HasColumnName("nCategory");
            entity.Property(e => e.NStatus).HasColumnName("nStatus");
            entity.Property(e => e.SzAnswer)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("szAnswer");
            entity.Property(e => e.SzCharName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("szCharName");
            entity.Property(e => e.SzChatLog)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("szChatLog");
            entity.Property(e => e.SzMailAddress)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("szMailAddress");
            entity.Property(e => e.SzMemo)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("szMemo");
            entity.Property(e => e.SzProcessedGm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("szProcessedGM");
            entity.Property(e => e.SzStatement)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("szStatement");
            entity.Property(e => e.SzTgtCharName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("szTgtCharName");
            entity.Property(e => e.WShardId).HasColumnName("wShardID");
        });

        modelBuilder.Entity<CasGmchatLog>(entity =>
        {
            entity.HasKey(e => e.NSerial).HasName("PK___CasGMChatLog__14F1071C");

            entity.ToTable("_CasGMChatLog");

            entity.Property(e => e.NSerial).HasColumnName("nSerial");
            entity.Property(e => e.DWritten)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dWritten");
            entity.Property(e => e.NCasSerial).HasColumnName("nCasSerial");
            entity.Property(e => e.SzCharName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("szCharName");
            entity.Property(e => e.SzGm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("szGM");
            entity.Property(e => e.SzGmchatLog)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("szGMChatLog");
            entity.Property(e => e.WShardId).HasColumnName("wShardID");
        });

        modelBuilder.Entity<CmProxyServerIp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CM_ProxyServerIP");

            entity.HasIndex(e => e.Ip, "CM_ProxyServerIP_IDX1")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Ip).HasColumnName("IP");
        });

        modelBuilder.Entity<CraftedMacroLazyBlockingList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_CraftedMacroLazyBlockingList");

            entity.Property(e => e.CharName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.SharId).HasColumnName("SharID");
            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<CraftedMacroPunishmentHistory>(entity =>
        {
            entity.HasKey(e => e.Jid).HasName("PK___CraftedMacroPunishmentHistory__JID");

            entity.ToTable("_CraftedMacroPunishmentHistory");

            entity.Property(e => e.Jid)
                .ValueGeneratedNever()
                .HasColumnName("JID");
            entity.Property(e => e.LastDetected).HasColumnType("datetime");
        });

        modelBuilder.Entity<EventGiveItemInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_EventGiveItemInfo");

            entity.Property(e => e.Area)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("area");
            entity.Property(e => e.Itemcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("itemcode");
            entity.Property(e => e.ItemnameEn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("itemname_en");
            entity.Property(e => e.ItemnameKr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("itemname_kr");
            entity.Property(e => e.Regdate)
                .HasColumnType("smalldatetime")
                .HasColumnName("regdate");
            entity.Property(e => e.Sncode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sncode");
        });

        modelBuilder.Entity<EventGiveItemList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_EventGiveItemList");

            entity.Property(e => e.Itemcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("itemcode");
            entity.Property(e => e.Jid).HasColumnName("jid");
            entity.Property(e => e.Shardid).HasColumnName("shardid");
        });

        modelBuilder.Entity<EventTicket20130611>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_EventTicket_20130611");

            entity.Property(e => e.AccountId)
                .HasMaxLength(128)
                .HasColumnName("AccountID");
            entity.Property(e => e.CharName).HasMaxLength(64);
            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.LastLogout).HasColumnType("smalldatetime");
            entity.Property(e => e.ShardName).HasMaxLength(30);
        });

        modelBuilder.Entity<FatigueSystemResetPlayTime>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_FatigueSystemResetPlayTime");

            entity.Property(e => e.LatestResetTime).HasDefaultValue(1);
        });

        modelBuilder.Entity<FreeAccess>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_FreeAccess");

            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.ShardId).HasColumnName("ShardID");
        });

        modelBuilder.Entity<GameInstantTicket>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationDate, e.Jid }).HasName("UC_GameInstantTicket_JID");

            entity.ToTable("_GameInstantTicket");

            entity.Property(e => e.RegistrationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Jid).HasColumnName("JID");
        });

        modelBuilder.Entity<GmConnectionNumForNation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_GM_ConnectionNumForNation");

            entity.Property(e => e.Capacity).HasDefaultValue((short)-1);
            entity.Property(e => e.Nation)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.RegDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<JcCrmRLoginGathering>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("JC_CRM_R_LoginGathering");

            entity.HasIndex(e => e.RegDate, "UI_JC_CRM_R_LoginGathering_RegDate")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
        });

        modelBuilder.Entity<JcCrmRLoginGathering1>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D10DDF8FC1C");

            entity.ToTable("JC_CRM_R_LoginGathering_1");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.PromotionId).HasColumnName("PromotionID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
        });

        modelBuilder.Entity<JcCrmRLoginGathering2>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D10AD42AC66");

            entity.ToTable("JC_CRM_R_LoginGathering_2");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.PromotionId).HasColumnName("PromotionID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
        });

        modelBuilder.Entity<JcCrmRLoginGathering3>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D1028365950");

            entity.ToTable("JC_CRM_R_LoginGathering_3");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.PromotionId).HasColumnName("PromotionID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
        });

        modelBuilder.Entity<JcCrmRLoginGathering4>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D109A0A51C3");

            entity.ToTable("JC_CRM_R_LoginGathering_4");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.PromotionId).HasColumnName("PromotionID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
        });

        modelBuilder.Entity<JcCrmRLoginGathering5>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D10A4A7082C");

            entity.ToTable("JC_CRM_R_LoginGathering_5");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.PromotionId).HasColumnName("PromotionID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
        });

        modelBuilder.Entity<JcCrmRLoginGathering6>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D10B7E6CFBB");

            entity.ToTable("JC_CRM_R_LoginGathering_6");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.PromotionId).HasColumnName("PromotionID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
        });

        modelBuilder.Entity<JcCrmRLoginGathering7>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D1009398734");

            entity.ToTable("JC_CRM_R_LoginGathering_7");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.PromotionId).HasColumnName("PromotionID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
        });

        modelBuilder.Entity<JcCrmRLogoutGathering>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("JC_CRM_R_LogoutGathering");

            entity.HasIndex(e => e.RegDate, "UI_JC_CRM_R_LogoutGathering_RegDate")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<JcCrmRLogoutGathering1>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D1041954FAF");

            entity.ToTable("JC_CRM_R_LogoutGathering_1");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<JcCrmRLogoutGathering2>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D100E173B3E");

            entity.ToTable("JC_CRM_R_LogoutGathering_2");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<JcCrmRLogoutGathering3>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D1082773B56");

            entity.ToTable("JC_CRM_R_LogoutGathering_3");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<JcCrmRLogoutGathering4>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D10BA751FC5");

            entity.ToTable("JC_CRM_R_LogoutGathering_4");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<JcCrmRLogoutGathering5>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D10D82B96D6");

            entity.ToTable("JC_CRM_R_LogoutGathering_5");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<JcCrmRLogoutGathering6>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D108EA37C8B");

            entity.ToTable("JC_CRM_R_LogoutGathering_6");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<JcCrmRLogoutGathering7>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D10239C65EC");

            entity.ToTable("JC_CRM_R_LogoutGathering_7");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<JcCrmRServerGathering>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("JC_CRM_R_ServerGathering");

            entity.HasIndex(e => e.RegDate, "UI_JC_CRM_R_ServerGathering_RegDate")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.Cname)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("CName");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
            entity.Property(e => e.Wname)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("WName");
        });

        modelBuilder.Entity<JcCrmRServerGathering1>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D101BB61700");

            entity.ToTable("JC_CRM_R_ServerGathering_1");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cname)
                .HasMaxLength(32)
                .HasColumnName("CName");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
            entity.Property(e => e.Wname)
                .HasMaxLength(32)
                .HasColumnName("WName");
        });

        modelBuilder.Entity<JcCrmRServerGathering2>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D10E6544971");

            entity.ToTable("JC_CRM_R_ServerGathering_2");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cname)
                .HasMaxLength(32)
                .HasColumnName("CName");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
            entity.Property(e => e.Wname)
                .HasMaxLength(32)
                .HasColumnName("WName");
        });

        modelBuilder.Entity<JcCrmRServerGathering3>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D1098DE196A");

            entity.ToTable("JC_CRM_R_ServerGathering_3");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cname)
                .HasMaxLength(32)
                .HasColumnName("CName");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
            entity.Property(e => e.Wname)
                .HasMaxLength(32)
                .HasColumnName("WName");
        });

        modelBuilder.Entity<JcCrmRServerGathering4>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D108AF288E0");

            entity.ToTable("JC_CRM_R_ServerGathering_4");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cname)
                .HasMaxLength(32)
                .HasColumnName("CName");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
            entity.Property(e => e.Wname)
                .HasMaxLength(32)
                .HasColumnName("WName");
        });

        modelBuilder.Entity<JcCrmRServerGathering5>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D10EECDFD51");

            entity.ToTable("JC_CRM_R_ServerGathering_5");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cname)
                .HasMaxLength(32)
                .HasColumnName("CName");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
            entity.Property(e => e.Wname)
                .HasMaxLength(32)
                .HasColumnName("WName");
        });

        modelBuilder.Entity<JcCrmRServerGathering6>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D10D6FCAE90");

            entity.ToTable("JC_CRM_R_ServerGathering_6");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cname)
                .HasMaxLength(32)
                .HasColumnName("CName");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
            entity.Property(e => e.Wname)
                .HasMaxLength(32)
                .HasColumnName("WName");
        });

        modelBuilder.Entity<JcCrmRServerGathering7>(entity =>
        {
            entity.HasKey(e => e.LogUid).HasName("PK__JC_CRM_R__CD347D10736BF10C");

            entity.ToTable("JC_CRM_R_ServerGathering_7");

            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.Cname)
                .HasMaxLength(32)
                .HasColumnName("CName");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
            entity.Property(e => e.Wname)
                .HasMaxLength(32)
                .HasColumnName("WName");
        });

        modelBuilder.Entity<LogEventSilk>(entity =>
        {
            entity.HasKey(e => new { e.EventTime, e.Jid }).HasName("_LogEventSilk_PK");

            entity.ToTable("_LogEventSilk");

            entity.Property(e => e.EventTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Jid).HasColumnName("JID");
        });

        modelBuilder.Entity<LoginEventCalendar>(entity =>
        {
            entity.HasKey(e => e.Jid).HasName("PK_Login_Event_Calendar");

            entity.ToTable("_Login_Event_Calendar");

            entity.Property(e => e.Jid)
                .ValueGeneratedNever()
                .HasColumnName("JID");
            entity.Property(e => e._1).HasColumnName("1");
            entity.Property(e => e._10).HasColumnName("10");
            entity.Property(e => e._11).HasColumnName("11");
            entity.Property(e => e._12).HasColumnName("12");
            entity.Property(e => e._13).HasColumnName("13");
            entity.Property(e => e._14).HasColumnName("14");
            entity.Property(e => e._15).HasColumnName("15");
            entity.Property(e => e._16).HasColumnName("16");
            entity.Property(e => e._17).HasColumnName("17");
            entity.Property(e => e._18).HasColumnName("18");
            entity.Property(e => e._19).HasColumnName("19");
            entity.Property(e => e._2).HasColumnName("2");
            entity.Property(e => e._20).HasColumnName("20");
            entity.Property(e => e._21).HasColumnName("21");
            entity.Property(e => e._22).HasColumnName("22");
            entity.Property(e => e._23).HasColumnName("23");
            entity.Property(e => e._24).HasColumnName("24");
            entity.Property(e => e._25).HasColumnName("25");
            entity.Property(e => e._26).HasColumnName("26");
            entity.Property(e => e._27).HasColumnName("27");
            entity.Property(e => e._28).HasColumnName("28");
            entity.Property(e => e._3).HasColumnName("3");
            entity.Property(e => e._4).HasColumnName("4");
            entity.Property(e => e._5).HasColumnName("5");
            entity.Property(e => e._6).HasColumnName("6");
            entity.Property(e => e._7).HasColumnName("7");
            entity.Property(e => e._8).HasColumnName("8");
            entity.Property(e => e._9).HasColumnName("9");
        });

        modelBuilder.Entity<LoginEventReward>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Day });

            entity.ToTable("_Login_Event_Reward");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RefAssocFileIcon128)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RefCodeName128)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
            entity.Property(e => e.RefNameStr)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LoginEventRewardLog>(entity =>
        {
            entity.HasKey(e => new { e.Jid, e.Month });

            entity.ToTable("_Login_Event_Reward_Log");

            entity.Property(e => e.Jid).HasColumnName("JID");
        });

        modelBuilder.Entity<LoginLogoutIntegration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LoginLogoutIntegration");

            entity.Property(e => e.ByReserved).HasColumnName("byReserved");
            entity.Property(e => e.DLogin)
                .HasColumnType("smalldatetime")
                .HasColumnName("dLogin");
            entity.Property(e => e.DLogout)
                .HasColumnType("smalldatetime")
                .HasColumnName("dLogout");
            entity.Property(e => e.NIdx).HasColumnName("nIdx");
            entity.Property(e => e.NIp).HasColumnName("nIP");
            entity.Property(e => e.NJid).HasColumnName("nJID");
        });

        modelBuilder.Entity<LoginLogoutStatistic>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LoginLogoutStatistics");

            entity.HasIndex(e => e.DLogin, "CIX___Login_Logout_Statistics_dLogin")
                .IsClustered()
                .HasFillFactor(90);

            entity.HasIndex(e => e.NIdx, "IX___Login_Logout_Statistics_nIdx")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.BtCompany).HasColumnName("btCompany");
            entity.Property(e => e.ByReserved).HasColumnName("byReserved");
            entity.Property(e => e.DLogin)
                .HasColumnType("smalldatetime")
                .HasColumnName("dLogin");
            entity.Property(e => e.DLogout)
                .HasColumnType("smalldatetime")
                .HasColumnName("dLogout");
            entity.Property(e => e.NIdx)
                .ValueGeneratedOnAdd()
                .HasColumnName("nIdx");
            entity.Property(e => e.NIp).HasColumnName("nIP");
            entity.Property(e => e.NJid).HasColumnName("nJID");
        });

        modelBuilder.Entity<LoginLogoutStatistics2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LoginLogoutStatistics2");

            entity.HasIndex(e => e.NIdx, "CX__LoginLogoutStatistics2__nIdx")
                .IsUnique()
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.NIdx)
                .ValueGeneratedOnAdd()
                .HasColumnName("nIdx");
            entity.Property(e => e.SzCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("szCode");
        });

        modelBuilder.Entity<LoginLogoutStatistics2BackUp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LoginLogoutStatistics2_BackUp");

            entity.Property(e => e.NIdx)
                .ValueGeneratedOnAdd()
                .HasColumnName("nIdx");
            entity.Property(e => e.SzCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("szCode");
        });

        modelBuilder.Entity<LoginLogoutStatisticsBackUp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LoginLogoutStatistics_BackUp");

            entity.Property(e => e.ByReserved).HasColumnName("byReserved");
            entity.Property(e => e.DLogin)
                .HasColumnType("smalldatetime")
                .HasColumnName("dLogin");
            entity.Property(e => e.DLogout)
                .HasColumnType("smalldatetime")
                .HasColumnName("dLogout");
            entity.Property(e => e.NIdx)
                .ValueGeneratedOnAdd()
                .HasColumnName("nIdx");
            entity.Property(e => e.NIp).HasColumnName("nIP");
            entity.Property(e => e.NJid).HasColumnName("nJID");
        });

        modelBuilder.Entity<MagicLampCleaner>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MagicLamp_Cleaner");

            entity.Property(e => e.ChargeCleaner).HasColumnName("Charge_Cleaner");
            entity.Property(e => e.GiftCleaner).HasColumnName("Gift_Cleaner");
            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<MagicLampCleanerHistory>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__MagicLam__DC501A78F82C4695");

            entity.ToTable("MagicLamp_Cleaner_history");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.AdminId)
                .HasMaxLength(50)
                .HasColumnName("admin_id");
            entity.Property(e => e.ChargeCleaner).HasColumnName("charge_cleaner");
            entity.Property(e => e.CpInvoiceId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("cp_invoiceID");
            entity.Property(e => e.ErrorNo).HasColumnName("error_no");
            entity.Property(e => e.GiftCleaner).HasColumnName("gift_cleaner");
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.Message)
                .HasMaxLength(200)
                .HasColumnName("message");
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("reg_date");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<MagicLampDetail>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__MagicLam__DC501A782B2B2C55");

            entity.ToTable("MagicLamp_Detail");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.ItemQty).HasColumnName("item_qty");
            entity.Property(e => e.ItemWin).HasColumnName("item_win");
            entity.Property(e => e.LampNum).HasColumnName("lamp_num");
            entity.Property(e => e.PackageId).HasColumnName("package_id");
        });

        modelBuilder.Entity<MagicLampErrorLog>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__MagicLam__DC501A780F2E0C25");

            entity.ToTable("MagicLamp_Error_Log");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.ErrorNum).HasColumnName("error_num");
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.ItemWin).HasColumnName("item_win");
            entity.Property(e => e.LampNum).HasColumnName("lamp_num");
            entity.Property(e => e.ListNum).HasColumnName("list_num");
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("reg_date");
            entity.Property(e => e.Userjid).HasColumnName("userjid");
        });

        modelBuilder.Entity<MagicLampHistory>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__MagicLam__DC501A78275A9B71");

            entity.ToTable("MagicLamp_History");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.ItemName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("item_name");
            entity.Property(e => e.ItemWin).HasColumnName("item_win");
            entity.Property(e => e.LampNum).HasColumnName("Lamp_num");
            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.RecieveDate)
                .HasColumnType("datetime")
                .HasColumnName("recieve_date");
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("reg_date");
            entity.Property(e => e.RoundNo).HasColumnName("round_no");
            entity.Property(e => e.ShardId).HasColumnName("shard_ID");
            entity.Property(e => e.ShardName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("shard_name");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<MagicLampList>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__MagicLam__DC501A7814E6E57B");

            entity.ToTable("MagicLamp_List");

            entity.HasIndex(e => e.LampNum, "IX_MagicLamp_List");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.LampNum).HasColumnName("lamp_num");
            entity.Property(e => e.LampStatus).HasColumnName("lamp_status");
            entity.Property(e => e.RemainAmount).HasColumnName("remain_amount");
            entity.Property(e => e.RoundNo).HasColumnName("round_no");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.Winners).HasColumnName("winners");
        });

        modelBuilder.Entity<MagicLampMain>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__MagicLam__DC501A7817C35226");

            entity.ToTable("MagicLamp_Main");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.LampNameDe)
                .HasMaxLength(100)
                .HasColumnName("LampName_de");
            entity.Property(e => e.LampNameEg)
                .HasMaxLength(100)
                .HasColumnName("LampName_eg");
            entity.Property(e => e.LampNameEs)
                .HasMaxLength(100)
                .HasColumnName("LampName_es");
            entity.Property(e => e.LampNameTr)
                .HasMaxLength(100)
                .HasColumnName("LampName_tr");
            entity.Property(e => e.LampNameUs)
                .HasMaxLength(100)
                .HasColumnName("LampName_us");
            entity.Property(e => e.LampQty).HasColumnName("Lamp_qty");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.UseStatus).HasColumnName("use_status");
            entity.Property(e => e.WinQty).HasColumnName("win_qty");
        });

        modelBuilder.Entity<ModuleVersion>(entity =>
        {
            entity.HasKey(e => e.NId)
                .HasName("PK___ModuleV__DF98CDFC6FB560CC")
                .IsClustered(false);

            entity.ToTable("_ModuleVersion");

            entity.HasIndex(e => e.NModuleId, "IX__ModuleVersion")
                .IsClustered()
                .HasFillFactor(70);

            entity.Property(e => e.NId).HasColumnName("nID");
            entity.Property(e => e.NContentId).HasColumnName("nContentID");
            entity.Property(e => e.NDivisionId).HasColumnName("nDivisionID");
            entity.Property(e => e.NModuleId).HasColumnName("nModuleID");
            entity.Property(e => e.NValid).HasColumnName("nValid");
            entity.Property(e => e.NVersion).HasColumnName("nVersion");
            entity.Property(e => e.SzDesc)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("szDesc");
            entity.Property(e => e.SzVersion)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("szVersion");
        });

        modelBuilder.Entity<ModuleVersionFile>(entity =>
        {
            entity.HasKey(e => e.NId)
                .HasName("PK___ModuleV__DF98CDFC7291CD77")
                .IsClustered(false);

            entity.ToTable("_ModuleVersionFile");

            entity.HasIndex(e => e.NModuleId, "IX__ModuleVersionFile")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.NId).HasColumnName("nID");
            entity.Property(e => e.NContentId).HasColumnName("nContentID");
            entity.Property(e => e.NDivisionId).HasColumnName("nDivisionID");
            entity.Property(e => e.NFileSize).HasColumnName("nFileSize");
            entity.Property(e => e.NFileType).HasColumnName("nFileType");
            entity.Property(e => e.NFileTypeVersion).HasColumnName("nFileTypeVersion");
            entity.Property(e => e.NModuleId).HasColumnName("nModuleID");
            entity.Property(e => e.NToBePacked).HasColumnName("nToBePacked");
            entity.Property(e => e.NValid).HasColumnName("nValid");
            entity.Property(e => e.NVersion).HasColumnName("nVersion");
            entity.Property(e => e.SzFilename)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("szFilename");
            entity.Property(e => e.SzPath)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("szPath");
            entity.Property(e => e.TimeModified)
                .HasColumnType("datetime")
                .HasColumnName("timeModified");
        });

        modelBuilder.Entity<Notice>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK___Notice__3214EC26756E3A22")
                .IsClustered(false);

            entity.ToTable("_Notice");

            entity.HasIndex(e => e.ContentId, "IX__Notice")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Article)
                .HasMaxLength(1024)
                .IsUnicode(false);
            entity.Property(e => e.ContentId).HasColumnName("ContentID");
            entity.Property(e => e.EditDate).HasColumnType("datetime");
            entity.Property(e => e.Subject)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OldBlockedUser>(entity =>
        {
            entity.HasKey(e => e.UserJid).HasName("PK__BlockedUser");

            entity.ToTable("_OldBlockedUser");

            entity.HasIndex(e => e.UserJid, "IX__BlockedUser").HasFillFactor(90);

            entity.Property(e => e.UserJid)
                .ValueGeneratedNever()
                .HasColumnName("UserJID");
            entity.Property(e => e.TimeBegin)
                .HasColumnType("datetime")
                .HasColumnName("timeBegin");
            entity.Property(e => e.TimeEnd)
                .HasColumnType("datetime")
                .HasColumnName("timeEnd");
        });

        modelBuilder.Entity<OldUser>(entity =>
        {
            entity.HasKey(e => e.PortalJid);

            entity.ToTable("__OldUsers__");

            entity.Property(e => e.PortalJid)
                .ValueGeneratedNever()
                .HasColumnName("PortalJID");
            entity.Property(e => e.UserName)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PrivilegedIp>(entity =>
        {
            entity.HasKey(e => e.NIdx).HasName("PK___Privile__2EF602B2784AA6CD");

            entity.ToTable("_PrivilegedIP");

            entity.Property(e => e.NIdx).HasColumnName("nIdx");
            entity.Property(e => e.DIssueDate)
                .HasColumnType("datetime")
                .HasColumnName("dIssueDate");
            entity.Property(e => e.SzDesc)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("szDesc");
            entity.Property(e => e.SzGm)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("szGM");
            entity.Property(e => e.SzIpbegin)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("szIPBegin");
            entity.Property(e => e.SzIpend)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("szIPEnd");
            entity.Property(e => e.SzIsp)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("szISP");
        });

        modelBuilder.Entity<PrivilegedIp2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_PrivilegedIP_2");

            entity.Property(e => e.DIssueDate)
                .HasColumnType("datetime")
                .HasColumnName("dIssueDate");
            entity.Property(e => e.NIdx)
                .ValueGeneratedOnAdd()
                .HasColumnName("nIdx");
            entity.Property(e => e.SzDesc)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("szDesc");
            entity.Property(e => e.SzGm)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("szGM");
            entity.Property(e => e.SzIpbegin)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("szIPBegin");
            entity.Property(e => e.SzIpend)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("szIPEnd");
            entity.Property(e => e.SzIsp)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("szISP");
        });

        modelBuilder.Entity<PrivilegedSmcip>(entity =>
        {
            entity.HasKey(e => e.NIdx).HasName("PK___Privile__2EF602B27B271378");

            entity.ToTable("_PrivilegedSMCIP");

            entity.Property(e => e.NIdx).HasColumnName("nIdx");
            entity.Property(e => e.DIssueDate)
                .HasColumnType("datetime")
                .HasColumnName("dIssueDate");
            entity.Property(e => e.SzDesc)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("szDesc");
            entity.Property(e => e.SzGm)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("szGM");
            entity.Property(e => e.SzIpbegin)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("szIPBegin");
            entity.Property(e => e.SzIpend)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("szIPEnd");
            entity.Property(e => e.SzIsp)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("szISP");
        });

        modelBuilder.Entity<Punishment>(entity =>
        {
            entity.HasKey(e => e.SerialNo).IsClustered(false);

            entity.ToTable("_Punishment");

            entity.HasIndex(e => e.UserJid, "IX__Punishment")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.BlockEndTime).HasColumnType("datetime");
            entity.Property(e => e.BlockStartTime).HasColumnType("datetime");
            entity.Property(e => e.CharInfo)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.CharName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(1024)
                .IsUnicode(false);
            entity.Property(e => e.Executor)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Guide)
                .HasMaxLength(512)
                .IsUnicode(false);
            entity.Property(e => e.PosInfo)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.PunishTime).HasColumnType("datetime");
            entity.Property(e => e.RaiseTime).HasColumnType("datetime");
            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<RecvWebCashItemHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_RecvWebCashItemHistory");

            entity.Property(e => e.CharacterId).HasColumnName("character_id");
            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.NameCodePackage)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("name_code_package");
            entity.Property(e => e.RecieveDate)
                .HasColumnType("datetime")
                .HasColumnName("recieve_date");
            entity.Property(e => e.Section).HasColumnName("section");
            entity.Property(e => e.ShardId).HasColumnName("ShardID");
        });

        modelBuilder.Entity<RefCountryNameAndCode>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("_RefCountryNameAndCode");

            entity.Property(e => e.Code)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("code");
            entity.Property(e => e.SzCountryName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("szCountryName");
        });

        modelBuilder.Entity<RefObjCommon>(entity =>
        {
            entity.ToTable("_RefObjCommon");

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

        modelBuilder.Entity<ResultBuyCashItemList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_Result_BuyCashItemList");

            entity.Property(e => e.CanDelete).HasColumnName("can_delete");
            entity.Property(e => e.CanRecharge).HasColumnName("can_recharge");
            entity.Property(e => e.CpJid).HasColumnName("cp_jid");
            entity.Property(e => e.DateBegin)
                .HasColumnType("smalldatetime")
                .HasColumnName("date_begin");
            entity.Property(e => e.DateEnd)
                .HasColumnType("smalldatetime")
                .HasColumnName("date_end");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.ItemQuantity).HasColumnName("item_quantity");
            entity.Property(e => e.NameCodePackage)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("name_code_package");
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("reg_date");
            entity.Property(e => e.RentType).HasColumnName("rent_type");
            entity.Property(e => e.Section).HasColumnName("section");
            entity.Property(e => e.ShardId).HasColumnName("ShardID");
            entity.Property(e => e.SubIdx).HasColumnName("SubIDx");
            entity.Property(e => e.TimeCount).HasColumnName("time_count");
        });

        modelBuilder.Entity<RigidDonationLog2018>(entity =>
        {
            entity.HasKey(e => new { e.PortalJid, e.ChargeDate, e.Serial });

            entity.ToTable("_Rigid_Donation_Log_2018");

            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.ChargeDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Serial).ValueGeneratedOnAdd();
            entity.Property(e => e.PaymentService)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<RigidItemNameDesc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_Rigid_ItemNameDesc");

            entity.Property(e => e.Ara)
                .IsUnicode(false)
                .HasColumnName("ARA");
            entity.Property(e => e.Eng)
                .IsUnicode(false)
                .HasColumnName("ENG");
            entity.Property(e => e.Esp)
                .IsUnicode(false)
                .HasColumnName("ESP");
            entity.Property(e => e.Ger)
                .IsUnicode(false)
                .HasColumnName("GER");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Kor)
                .IsUnicode(false)
                .HasColumnName("KOR");
            entity.Property(e => e.StrId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("StrID");
            entity.Property(e => e.Tur)
                .IsUnicode(false)
                .HasColumnName("TUR");
            entity.Property(e => e.Unk0)
                .IsUnicode(false)
                .HasColumnName("UNK0");
            entity.Property(e => e.Unk1)
                .IsUnicode(false)
                .HasColumnName("UNK1");
            entity.Property(e => e.Unk2)
                .IsUnicode(false)
                .HasColumnName("UNK2");
            entity.Property(e => e.Unk3)
                .IsUnicode(false)
                .HasColumnName("UNK3");
            entity.Property(e => e.Unk4)
                .IsUnicode(false)
                .HasColumnName("UNK4");
            entity.Property(e => e.Unk5)
                .IsUnicode(false)
                .HasColumnName("UNK5");
            entity.Property(e => e.Unk6)
                .IsUnicode(false)
                .HasColumnName("UNK6");
            entity.Property(e => e.Vnm)
                .IsUnicode(false)
                .HasColumnName("VNM");
        });

        modelBuilder.Entity<RigidLoginEvent>(entity =>
        {
            entity.HasKey(e => e.Jid).HasName("PK_Rigid_Login_Event2");

            entity.ToTable("_Rigid_Login_Event");

            entity.Property(e => e.Jid)
                .ValueGeneratedNever()
                .HasColumnName("JID");
            entity.Property(e => e.LoginTime).HasColumnType("datetime");
            entity.Property(e => e.UpdateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<RigidLoginEventCalendar>(entity =>
        {
            entity.HasKey(e => e.Jid).HasName("PK_Rigid_Login_Event_Calendar");

            entity.ToTable("_Rigid_Login_Event_Calendar");

            entity.Property(e => e.Jid)
                .ValueGeneratedNever()
                .HasColumnName("JID");
            entity.Property(e => e._1).HasColumnName("1");
            entity.Property(e => e._10).HasColumnName("10");
            entity.Property(e => e._11).HasColumnName("11");
            entity.Property(e => e._12).HasColumnName("12");
            entity.Property(e => e._13).HasColumnName("13");
            entity.Property(e => e._14).HasColumnName("14");
            entity.Property(e => e._15).HasColumnName("15");
            entity.Property(e => e._16).HasColumnName("16");
            entity.Property(e => e._17).HasColumnName("17");
            entity.Property(e => e._18).HasColumnName("18");
            entity.Property(e => e._19).HasColumnName("19");
            entity.Property(e => e._2).HasColumnName("2");
            entity.Property(e => e._20).HasColumnName("20");
            entity.Property(e => e._21).HasColumnName("21");
            entity.Property(e => e._22).HasColumnName("22");
            entity.Property(e => e._23).HasColumnName("23");
            entity.Property(e => e._24).HasColumnName("24");
            entity.Property(e => e._25).HasColumnName("25");
            entity.Property(e => e._26).HasColumnName("26");
            entity.Property(e => e._27).HasColumnName("27");
            entity.Property(e => e._28).HasColumnName("28");
            entity.Property(e => e._3).HasColumnName("3");
            entity.Property(e => e._4).HasColumnName("4");
            entity.Property(e => e._5).HasColumnName("5");
            entity.Property(e => e._6).HasColumnName("6");
            entity.Property(e => e._7).HasColumnName("7");
            entity.Property(e => e._8).HasColumnName("8");
            entity.Property(e => e._9).HasColumnName("9");
        });

        modelBuilder.Entity<RigidLoginEventCalendarPlaytime>(entity =>
        {
            entity.HasKey(e => e.Jid).HasName("PK_Rigid_Login_Event_Calendar_Playtime");

            entity.ToTable("_Rigid_Login_Event_Calendar_Playtime");

            entity.Property(e => e.Jid)
                .ValueGeneratedNever()
                .HasColumnName("JID");
            entity.Property(e => e._1).HasColumnName("1");
            entity.Property(e => e._10).HasColumnName("10");
            entity.Property(e => e._11).HasColumnName("11");
            entity.Property(e => e._12).HasColumnName("12");
            entity.Property(e => e._13).HasColumnName("13");
            entity.Property(e => e._14).HasColumnName("14");
            entity.Property(e => e._15).HasColumnName("15");
            entity.Property(e => e._16).HasColumnName("16");
            entity.Property(e => e._17).HasColumnName("17");
            entity.Property(e => e._18).HasColumnName("18");
            entity.Property(e => e._19).HasColumnName("19");
            entity.Property(e => e._2).HasColumnName("2");
            entity.Property(e => e._20).HasColumnName("20");
            entity.Property(e => e._21).HasColumnName("21");
            entity.Property(e => e._22).HasColumnName("22");
            entity.Property(e => e._23).HasColumnName("23");
            entity.Property(e => e._24).HasColumnName("24");
            entity.Property(e => e._25).HasColumnName("25");
            entity.Property(e => e._26).HasColumnName("26");
            entity.Property(e => e._27).HasColumnName("27");
            entity.Property(e => e._28).HasColumnName("28");
            entity.Property(e => e._3).HasColumnName("3");
            entity.Property(e => e._4).HasColumnName("4");
            entity.Property(e => e._5).HasColumnName("5");
            entity.Property(e => e._6).HasColumnName("6");
            entity.Property(e => e._7).HasColumnName("7");
            entity.Property(e => e._8).HasColumnName("8");
            entity.Property(e => e._9).HasColumnName("9");
        });

        modelBuilder.Entity<RigidLoginEventReward>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Day });

            entity.ToTable("_Rigid_Login_Event_Reward");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Duration).HasDefaultValue(0);
            entity.Property(e => e.RefAssocFileIcon128)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RefCodeName128)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
            entity.Property(e => e.RefNameStrId128)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("RefNameStrID128");
        });

        modelBuilder.Entity<RigidLoginEventRewardLog>(entity =>
        {
            entity.HasKey(e => new { e.Jid, e.Month });

            entity.ToTable("_Rigid_Login_Event_Reward_Log");

            entity.Property(e => e.Jid).HasColumnName("JID");
        });

        modelBuilder.Entity<SLoginAttempt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("S_LoginAttempt");

            entity.Property(e => e.AttemptDate).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SManualBlockedUserH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__S_Manual__3214EC2705C49D7C");

            entity.ToTable("S_ManualBlockedUserHS");

            entity.HasIndex(e => e.Num, "IX_ManualBlockedUserHS_num");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BlockedDate).HasColumnType("datetime");
            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.Num).HasColumnName("num");
            entity.Property(e => e.StrUserId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("StrUserID");
        });

        modelBuilder.Entity<SSilkChangingLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("S_SilkChangingLog");

            entity.HasIndex(e => e.ChangingDate, "I_S_SilkChangingLog_CD").HasFillFactor(90);

            entity.HasIndex(e => e.ChangingNumber, "I_S_SilkChangingLog_CN").HasFillFactor(90);

            entity.HasIndex(e => new { e.Jid, e.ChangingNumber }, "I_S_SilkChangingLog_JID_CN").HasFillFactor(90);

            entity.Property(e => e.ChangingDate).HasColumnType("datetime");
            entity.Property(e => e.ChangingNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.ChangingSilkGiftPremium).HasColumnName("ChangingSilkGift_Premium");
            entity.Property(e => e.ChangingSilkGiftPremiumRemain).HasColumnName("ChangingSilkGift_PremiumRemain");
            entity.Property(e => e.ChangingSilkOwnPremium).HasColumnName("ChangingSilkOwn_Premium");
            entity.Property(e => e.ChangingSilkOwnPremiumRemain).HasColumnName("ChangingSilkOwn_PremiumRemain");
            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.SalesStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ShardName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SSilkItemBuyLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("S_SilkItemBuyLog");

            entity.HasIndex(e => new { e.ShardName, e.Serial64 }, "UI_S_SilkItemBuyLog_SN_S64")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.CodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.ShardName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SecondaryPassword>(entity =>
        {
            entity.HasKey(e => e.UserJid).HasName("PK___Seconda__2929F26E1A00A053");

            entity.ToTable("_SecondaryPassword");

            entity.Property(e => e.UserJid)
                .ValueGeneratedNever()
                .HasColumnName("UserJID");
            entity.Property(e => e.BlockedStartTime).HasColumnType("smalldatetime");
            entity.Property(e => e.SecondPassword)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SecurityDescription>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_SecurityDescription");

            entity.Property(e => e.NId)
                .ValueGeneratedOnAdd()
                .HasColumnName("nID");
            entity.Property(e => e.SzDesc)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("szDesc");
            entity.Property(e => e.SzName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("szName");
        });

        modelBuilder.Entity<SecurityDescriptionGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_SecurityDescriptionGroup");

            entity.Property(e => e.NId)
                .ValueGeneratedOnAdd()
                .HasColumnName("nID");
            entity.Property(e => e.SzDesc)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("szDesc");
            entity.Property(e => e.SzName)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("szName");
        });

        modelBuilder.Entity<SecurityDescriptionGroupAssign>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_SecurityDescriptionGroupAssign");

            entity.Property(e => e.NDescriptionId).HasColumnName("nDescriptionID");
            entity.Property(e => e.NGroupId).HasColumnName("nGroupID");
        });

        modelBuilder.Entity<ServiceManagerLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_ServiceManagerLog");

            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.NUserId).HasColumnName("nUserID");
            entity.Property(e => e.SzLog)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("szLog");
        });

        modelBuilder.Entity<Shard>(entity =>
        {
            entity.HasKey(e => e.NId).HasName("PK___Shard__DF98CDFD3D05A2FB");

            entity.ToTable("_Shard");

            entity.Property(e => e.NId).HasColumnName("nID");
            entity.Property(e => e.NContentId).HasColumnName("nContentID");
            entity.Property(e => e.NCurrentUserRatio).HasColumnName("nCurrentUserRatio");
            entity.Property(e => e.NFarmId).HasColumnName("nFarmID");
            entity.Property(e => e.NMaxUser)
                .HasDefaultValue((short)1000)
                .HasColumnName("nMaxUser");
            entity.Property(e => e.NStartupServerId).HasColumnName("nStartupServerID");
            entity.Property(e => e.NStatus).HasColumnName("nStatus");
            entity.Property(e => e.SzDbconfig)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("szDBConfig");
            entity.Property(e => e.SzDesc)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("szDesc");
            entity.Property(e => e.SzName)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("szName");
        });

        modelBuilder.Entity<ShardCurrentUser>(entity =>
        {
            entity.HasKey(e => e.NId)
                .HasName("PK___ShardCu__DF98CDFCC8C134DD")
                .IsClustered(false);

            entity.ToTable("_ShardCurrentUser");

            entity.Property(e => e.NId).HasColumnName("nID");
            entity.Property(e => e.DLogDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("dLogDate");
            entity.Property(e => e.NShardId).HasColumnName("nShardID");
            entity.Property(e => e.NUserCount).HasColumnName("nUserCount");
        });

        modelBuilder.Entity<ShardCurrentUserByChanneling>(entity =>
        {
            entity.HasKey(e => new { e.NId, e.NServiceCompany })
                .HasName("PK____ShardCurrentUserByChannel_nID")
                .IsClustered(false);

            entity.ToTable("_ShardCurrentUserByChanneling");

            entity.Property(e => e.NId).HasColumnName("nID");
            entity.Property(e => e.NServiceCompany).HasColumnName("nServiceCompany");
            entity.Property(e => e.NUserCount).HasColumnName("nUserCount");
        });

        modelBuilder.Entity<ShardFlatRateService>(entity =>
        {
            entity.HasKey(e => e.ShardId).HasName("PK___ShardFl__D2F631670698C624");

            entity.ToTable("_ShardFlatRateService");

            entity.Property(e => e.ShardId)
                .ValueGeneratedNever()
                .HasColumnName("ShardID");
        });

        modelBuilder.Entity<ShardService>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_ShardService");

            entity.Property(e => e.ShardId).HasColumnName("ShardID");
        });

        modelBuilder.Entity<SiegeFortressStatus>(entity =>
        {
            entity.HasKey(e => new { e.ShardId, e.FortressName });

            entity.ToTable("__SiegeFortressStatus__");

            entity.Property(e => e.ShardId).HasColumnName("ShardID");
            entity.Property(e => e.FortressName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OwnerAllianceGuildName1)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OwnerAllianceGuildName2)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OwnerAllianceGuildName3)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OwnerAllianceGuildName4)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OwnerGuildMaster)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OwnerGuildName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OwnerUpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SiegeFortressStatus8>(entity =>
        {
            entity.HasKey(e => new { e.ShardId, e.FortressName }).HasName("PK____SiegeF__E3DBCB4540E5634A");

            entity.ToTable("__SiegeFortressStatus___8");

            entity.Property(e => e.ShardId).HasColumnName("ShardID");
            entity.Property(e => e.FortressName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OwnerAllianceGuildName1)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OwnerAllianceGuildName2)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OwnerAllianceGuildName3)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OwnerAllianceGuildName4)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OwnerAllianceGuildName5)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OwnerAllianceGuildName6)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OwnerAllianceGuildName7)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OwnerAllianceGuildName8)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OwnerGuildMaster)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OwnerGuildName)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.OwnerUpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SkEmailCertifyKey>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SK_EmailCertifyKey");

            entity.Property(e => e.RegDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("reg_date");
            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<SkGamebangIp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SK_Gamebang_IP");

            entity.Property(e => e.Ip).HasColumnName("IP");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SkShl>(entity =>
        {
            entity.HasKey(e => e.Idx).IsClustered(false);

            entity.ToTable("SK_SHL");

            entity.HasIndex(e => e.Jid, "IX_SK_SHL")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.Cgs).HasColumnName("CGS");
            entity.Property(e => e.Cos).HasColumnName("COS");
            entity.Property(e => e.EventTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("event_time");
            entity.Property(e => e.Hgs).HasColumnName("HGS");
            entity.Property(e => e.Hos).HasColumnName("HOS");
            entity.Property(e => e.Jid).HasColumnName("JID");
        });

        modelBuilder.Entity<SkSilk>(entity =>
        {
            entity.HasKey(e => e.Jid).HasName("PK__SK_Silk__029D4CB7");

            entity.ToTable("SK_Silk", tb => tb.HasTrigger("_SK_SILK_TR_U"));

            entity.Property(e => e.Jid)
                .ValueGeneratedNever()
                .HasColumnName("JID");
            entity.Property(e => e.SilkGift).HasColumnName("silk_gift");
            entity.Property(e => e.SilkGiftPremium).HasColumnName("silk_gift_premium");
            entity.Property(e => e.SilkOwn).HasColumnName("silk_own");
            entity.Property(e => e.SilkOwnPremium).HasColumnName("silk_own_premium");
            entity.Property(e => e.SilkPoint).HasColumnName("silk_point");

            entity.HasOne(d => d.JidNavigation).WithOne(p => p.SkSilk)
                .HasForeignKey<SkSilk>(d => d.Jid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SK_Silk_TB_User");
        });

        modelBuilder.Entity<SkSilkChangeByWeb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SK_SilkChange_BY__5812160E");

            entity.ToTable("SK_SilkChange_BY_Web");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.Reason).HasColumnName("reason");
            entity.Property(e => e.SilkOffset).HasColumnName("silk_offset");
            entity.Property(e => e.SilkRemain).HasColumnName("silk_remain");
            entity.Property(e => e.SilkType).HasColumnName("silk_type");
        });

        modelBuilder.Entity<SkSilkGood>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SK_SilkGoods__233F2673");

            entity.ToTable("SK_SilkGoods");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cpname)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("CPName");
            entity.Property(e => e.GoodsCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.GoodsName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Smclog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_SMCLog");

            entity.Property(e => e.DLogDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dLogDate");
            entity.Property(e => e.SzLog)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("szLog");
            entity.Property(e => e.SzUserId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("szUserID");
        });

        modelBuilder.Entity<SrCharName>(entity =>
        {
            entity.HasKey(e => new { e.UserJid, e.ShardId });

            entity.ToTable("SR_CharNames");

            entity.Property(e => e.UserJid).HasColumnName("UserJID");
            entity.Property(e => e.ShardId).HasColumnName("ShardID");
            entity.Property(e => e.CharId1)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("CharID_1");
            entity.Property(e => e.CharId2)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("CharID_2");
            entity.Property(e => e.CharId3)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("CharID_3");
        });

        modelBuilder.Entity<SrMaxLevelPerAccount>(entity =>
        {
            entity.HasKey(e => new { e.Jid, e.MaxLevel })
                .HasName("SR_MaxLevelPerAccount_PK")
                .IsClustered(false);

            entity.ToTable("SR_MaxLevelPerAccount");

            entity.Property(e => e.Jid).HasColumnName("JID");
        });

        modelBuilder.Entity<SrShardCharName>(entity =>
        {
            entity.HasKey(e => new { e.UserJid, e.ShardId, e.CharName }).HasName("PK__SR_Shard__D7AE09542EFBBD39");

            entity.ToTable("SR_ShardCharNames");

            entity.Property(e => e.UserJid).HasColumnName("UserJID");
            entity.Property(e => e.ShardId).HasColumnName("ShardID");
            entity.Property(e => e.CharName)
                .HasMaxLength(64)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StCrmGatheringResultLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ST_CRM_Gathering_ResultLog");

            entity.Property(e => e.Edate)
                .HasColumnType("datetime")
                .HasColumnName("edate");
            entity.Property(e => e.ErrMsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("err_msg");
            entity.Property(e => e.Error).HasColumnName("error");
            entity.Property(e => e.Result)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("result");
            entity.Property(e => e.Sdate)
                .HasColumnType("datetime")
                .HasColumnName("sdate");
            entity.Property(e => e.WorkDate)
                .HasColumnType("datetime")
                .HasColumnName("work_date");
        });

        modelBuilder.Entity<StRCharPtime>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_ST_R_CharPTime");

            entity.Property(e => e.ChannelName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.CharName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.LogInTime).HasColumnType("smalldatetime");
            entity.Property(e => e.LogOutTime).HasColumnType("smalldatetime");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegTime).HasColumnType("smalldatetime");
            entity.Property(e => e.WorldName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SupAdmin>(entity =>
        {
            entity.HasKey(e => new { e.NId, e.AId }).HasName("PK__SupAdmin__A27DD543749A117A");

            entity.ToTable("SupAdmin");

            entity.Property(e => e.NId)
                .ValueGeneratedOnAdd()
                .HasColumnName("nID");
            entity.Property(e => e.AId)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("aID");
            entity.Property(e => e.AExplain)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("aExplain");
            entity.Property(e => e.AGrade).HasColumnName("aGrade");
            entity.Property(e => e.AName)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("aName");
            entity.Property(e => e.APassWord)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("aPassWord");
            entity.Property(e => e.GmNickName).HasMaxLength(50);
            entity.Property(e => e.Ip)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.SignDate).HasColumnType("datetime");
            entity.Property(e => e.VisitDate).HasColumnType("datetime");
            entity.Property(e => e.WriteDiv)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SupAdminLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SupAdminLog");

            entity.Property(e => e.AId)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("aID");
            entity.Property(e => e.ActContent)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.MngActName)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.MngMenu)
                .HasMaxLength(48)
                .IsUnicode(false);
            entity.Property(e => e.RegDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SupMenuCate>(entity =>
        {
            entity.HasKey(e => e.MenuCateNo).HasName("PK__SupMenuC__1AE8297E77767E25");

            entity.ToTable("SupMenuCate");

            entity.Property(e => e.MenuLink)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.MenuName)
                .HasMaxLength(48)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SupMenuCateUse>(entity =>
        {
            entity.HasKey(e => e.UseCateNo)
                .HasName("PK__SupMenuC__3A6577287A52EAD0")
                .IsClustered(false);

            entity.ToTable("SupMenuCateUse");

            entity.HasIndex(e => new { e.NId, e.MenuCateNo, e.MenuSort }, "SupMenuCateUse_IDX1")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.NId).HasColumnName("nID");

            entity.HasOne(d => d.MenuCateNoNavigation).WithMany(p => p.SupMenuCateUses)
                .HasForeignKey(d => d.MenuCateNo)
                .HasConstraintName("FK__SupMenuCa__MenuC__7C3B3342");
        });

        modelBuilder.Entity<TbUser>(entity =>
        {
            entity.HasKey(e => e.Jid).HasName("PK__TB_User__C4DD21B532CC4E1D");

            entity.ToTable("TB_User");

            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LatestUpdateTimeToPlayTime).HasColumnName("LatestUpdateTime_ToPlayTime");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.SecContent).HasColumnName("sec_content");
            entity.Property(e => e.SecGrade).HasColumnName("sec_grade");
            entity.Property(e => e.SecPrimary).HasColumnName("sec_primary");
            entity.Property(e => e.StrUserId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("StrUserID");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
            entity.Property(e => e.VisitDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbUserBackup>(entity =>
        {
            entity.HasKey(e => e.Jid).HasName("PK__TB_User__267ABA7A");

            entity.ToTable("TB_User_backup");

            entity.HasIndex(e => e.StrUserId, "TB_User_IDX1")
                .IsUnique()
                .HasFillFactor(70);

            entity.Property(e => e.Jid)
                .ValueGeneratedNever()
                .HasColumnName("JID");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LatestUpdateTimeToPlayTime).HasColumnName("LatestUpdateTime_ToPlayTime");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.SecContent).HasColumnName("sec_content");
            entity.Property(e => e.SecGrade).HasColumnName("sec_grade");
            entity.Property(e => e.SecPrimary).HasColumnName("sec_primary");
            entity.Property(e => e.StrUserId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("StrUserID");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
            entity.Property(e => e.VisitDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbUserChannel>(entity =>
        {
            entity.HasKey(e => new { e.PortalJid, e.Channel, e.ChannelId }).HasName("UC_TB_User_Channel_PortalJID");

            entity.ToTable("TB_User_Channel");

            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
        });

        modelBuilder.Entity<TempRewardItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TEMP_Reward_Item__2200E977");

            entity.ToTable("TEMP_Reward_Item");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CodeName)
                .HasMaxLength(129)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempTable");

            entity.Property(e => e.CountryCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.LatestUpdateTimeToPlayTime).HasColumnName("LatestUpdateTime_ToPlayTime");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.SecContent).HasColumnName("sec_content");
            entity.Property(e => e.SecGrade).HasColumnName("sec_grade");
            entity.Property(e => e.SecPrimary).HasColumnName("sec_primary");
            entity.Property(e => e.StrUserId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("StrUserID");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
            entity.Property(e => e.VisitDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TempUserList>(entity =>
        {
            entity.HasKey(e => e.Seq).HasName("PK__TEMP_User_List__2018A105");

            entity.ToTable("TEMP_User_List");

            entity.Property(e => e.Seq)
                .ValueGeneratedNever()
                .HasColumnName("SEQ");
            entity.Property(e => e.AccountId)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("AccountID");
            entity.Property(e => e.MaxLastLogout).HasColumnType("smalldatetime");
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

        modelBuilder.Entity<TemporalyBlockedIphistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_TemporalyBlockedIPHistory");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Ip)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("IP");
        });

        modelBuilder.Entity<TestStatistic>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_test_statistics");

            entity.Property(e => e.ByReserved).HasColumnName("byReserved");
            entity.Property(e => e.DLogin)
                .HasColumnType("smalldatetime")
                .HasColumnName("dLogin");
            entity.Property(e => e.DLogout)
                .HasColumnType("smalldatetime")
                .HasColumnName("dLogout");
            entity.Property(e => e.NIdx)
                .ValueGeneratedOnAdd()
                .HasColumnName("nIdx");
            entity.Property(e => e.NIp).HasColumnName("nIP");
            entity.Property(e => e.NJid).HasColumnName("nJID");
        });

        modelBuilder.Entity<TrijobRanking>(entity =>
        {
            entity.HasKey(e => new { e.ShardId, e.TrijobType, e.RankType, e.Rank });

            entity.ToTable("__TrijobRanking__");

            entity.HasIndex(e => e.NickName, "IX___TrijobRanking__").HasFillFactor(90);

            entity.Property(e => e.ShardId).HasColumnName("ShardID");
            entity.Property(e => e.NickName)
                .HasMaxLength(64)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrijobRankingStatus>(entity =>
        {
            entity.HasKey(e => e.ShardId);

            entity.ToTable("__TrijobRankingStatus__");

            entity.Property(e => e.ShardId)
                .ValueGeneratedNever()
                .HasColumnName("ShardID");
            entity.Property(e => e.UpdateTime).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<VoteAnswer>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__VOTE_ANS__DC501A7856158A5A");

            entity.ToTable("VOTE_ANSWER");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.AnswerDe)
                .HasMaxLength(300)
                .HasColumnName("answer_de");
            entity.Property(e => e.AnswerEg)
                .HasMaxLength(300)
                .HasColumnName("answer_eg");
            entity.Property(e => e.AnswerEs)
                .HasMaxLength(300)
                .HasColumnName("answer_es");
            entity.Property(e => e.AnswerTr)
                .HasMaxLength(300)
                .HasColumnName("answer_tr");
            entity.Property(e => e.AnswerUs)
                .HasMaxLength(300)
                .HasColumnName("answer_us");
            entity.Property(e => e.QueNum).HasColumnName("que_num");
        });

        modelBuilder.Entity<VoteMain>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__VOTE_MAI__DC501A7858F1F705");

            entity.ToTable("VOTE_MAIN");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.GiveitemCode)
                .HasMaxLength(50)
                .HasColumnName("giveitem_code");
            entity.Property(e => e.GiveitemQty).HasColumnName("giveitem_qty");
            entity.Property(e => e.GroupNum).HasColumnName("group_num");
            entity.Property(e => e.MessageDe)
                .HasMaxLength(500)
                .HasColumnName("message_de");
            entity.Property(e => e.MessageEg)
                .HasMaxLength(500)
                .HasColumnName("message_eg");
            entity.Property(e => e.MessageEs)
                .HasMaxLength(500)
                .HasColumnName("message_es");
            entity.Property(e => e.MessageTr)
                .HasMaxLength(500)
                .HasColumnName("message_tr");
            entity.Property(e => e.MessageUs)
                .HasMaxLength(500)
                .HasColumnName("message_us");
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("reg_date");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.SubjectDe)
                .HasMaxLength(100)
                .HasColumnName("subject_de");
            entity.Property(e => e.SubjectEg)
                .HasMaxLength(100)
                .HasColumnName("subject_eg");
            entity.Property(e => e.SubjectEs)
                .HasMaxLength(100)
                .HasColumnName("subject_es");
            entity.Property(e => e.SubjectTr)
                .HasMaxLength(100)
                .HasColumnName("subject_tr");
            entity.Property(e => e.SubjectUs)
                .HasMaxLength(100)
                .HasColumnName("subject_us");
            entity.Property(e => e.SynopsisDe)
                .HasMaxLength(500)
                .HasColumnName("synopsis_de");
            entity.Property(e => e.SynopsisEg)
                .HasMaxLength(500)
                .HasColumnName("synopsis_eg");
            entity.Property(e => e.SynopsisEs)
                .HasMaxLength(500)
                .HasColumnName("synopsis_es");
            entity.Property(e => e.SynopsisTr)
                .HasMaxLength(500)
                .HasColumnName("synopsis_tr");
            entity.Property(e => e.SynopsisUs)
                .HasMaxLength(500)
                .HasColumnName("synopsis_us");
        });

        modelBuilder.Entity<VoteQuestion>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__VOTE_QUE__DC501A785BCE63B0");

            entity.ToTable("VOTE_QUESTION");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.PollNum).HasColumnName("poll_num");
            entity.Property(e => e.QuestionDe)
                .HasMaxLength(300)
                .HasColumnName("question_de");
            entity.Property(e => e.QuestionEg)
                .HasMaxLength(300)
                .HasColumnName("question_eg");
            entity.Property(e => e.QuestionEs)
                .HasMaxLength(300)
                .HasColumnName("question_es");
            entity.Property(e => e.QuestionTr)
                .HasMaxLength(300)
                .HasColumnName("question_tr");
            entity.Property(e => e.QuestionUs)
                .HasMaxLength(300)
                .HasColumnName("question_us");
        });

        modelBuilder.Entity<VoteUser>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__VOTE_USE__DC501A785EAAD05B");

            entity.ToTable("VOTE_USER");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.Charlevel).HasColumnName("charlevel");
            entity.Property(e => e.Charname)
                .HasMaxLength(30)
                .HasColumnName("charname");
            entity.Property(e => e.Class)
                .HasMaxLength(20)
                .HasColumnName("class");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(10)
                .HasColumnName("country_code");
            entity.Property(e => e.CpJid).HasColumnName("cp_jid");
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.Job)
                .HasMaxLength(20)
                .HasColumnName("job");
            entity.Property(e => e.PollNum).HasColumnName("poll_num");
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("reg_date");
            entity.Property(e => e.ShardId).HasColumnName("shard_id");
        });

        modelBuilder.Entity<VoteUserDetail>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__VOTE_USE__DC501A7861873D06");

            entity.ToTable("VOTE_USER_DETAIL");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.AnsNum).HasColumnName("ans_num");
            entity.Property(e => e.QueNum).HasColumnName("que_num");
            entity.Property(e => e.RefIdx).HasColumnName("ref_idx");
        });

        modelBuilder.Entity<VwJcCrmRLoginGathering>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_JC_CRM_R_LoginGathering");

            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.PromotionId).HasColumnName("PromotionID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
        });

        modelBuilder.Entity<VwJcCrmRLogoutGathering>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_JC_CRM_R_LogoutGathering");

            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VwJcCrmRServerGathering>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_JC_CRM_R_ServerGathering");

            entity.Property(e => e.Cname)
                .HasMaxLength(32)
                .HasColumnName("CName");
            entity.Property(e => e.Cpjid).HasColumnName("CPJID");
            entity.Property(e => e.LogUid).HasColumnName("Log_Uid");
            entity.Property(e => e.PortalJid).HasColumnName("PortalJID");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.UserIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UserIP");
            entity.Property(e => e.Wname)
                .HasMaxLength(32)
                .HasColumnName("WName");
        });

        modelBuilder.Entity<VwWebMallList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_WEB_MALL_LIST");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.DeExplain)
                .HasMaxLength(2048)
                .HasColumnName("de_explain");
            entity.Property(e => e.DeUseMethod)
                .HasMaxLength(255)
                .HasColumnName("de_use_method");
            entity.Property(e => e.DeUseRestriction)
                .HasMaxLength(255)
                .HasColumnName("de_use_restriction");
            entity.Property(e => e.DiscountRate).HasColumnName("discount_rate");
            entity.Property(e => e.DiscountRateGrow).HasColumnName("discount_rate_grow");
            entity.Property(e => e.DiscountRateItem).HasColumnName("discount_rate_item");
            entity.Property(e => e.EgExplain)
                .HasMaxLength(2048)
                .HasColumnName("eg_explain");
            entity.Property(e => e.EgUseMethod)
                .HasMaxLength(255)
                .HasColumnName("eg_use_method");
            entity.Property(e => e.EgUseRestriction)
                .HasMaxLength(255)
                .HasColumnName("eg_use_restriction");
            entity.Property(e => e.EsExplain)
                .HasMaxLength(2048)
                .HasColumnName("es_explain");
            entity.Property(e => e.EsUseMethod)
                .HasMaxLength(255)
                .HasColumnName("es_use_method");
            entity.Property(e => e.EsUseRestriction)
                .HasMaxLength(255)
                .HasColumnName("es_use_restriction");
            entity.Property(e => e.GrowServer).HasColumnName("grow_server");
            entity.Property(e => e.IsBest).HasColumnName("is_best");
            entity.Property(e => e.IsList).HasColumnName("is_list");
            entity.Property(e => e.IsNew).HasColumnName("is_new");
            entity.Property(e => e.ItemOrder).HasColumnName("item_order");
            entity.Property(e => e.ItemServer).HasColumnName("item_server");
            entity.Property(e => e.MonthLimit).HasColumnName("month_limit");
            entity.Property(e => e.NameCode)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("name_code");
            entity.Property(e => e.OriginServer).HasColumnName("origin_server");
            entity.Property(e => e.PackageCode)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("package_code");
            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.PackageName)
                .HasMaxLength(64)
                .HasColumnName("package_name");
            entity.Property(e => e.RefNo).HasColumnName("ref_no");
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("reg_date");
            entity.Property(e => e.Service).HasColumnName("service");
            entity.Property(e => e.ShopNameDe)
                .HasMaxLength(50)
                .HasColumnName("shop_name_de");
            entity.Property(e => e.ShopNameEg)
                .HasMaxLength(50)
                .HasColumnName("shop_name_eg");
            entity.Property(e => e.ShopNameEs)
                .HasMaxLength(50)
                .HasColumnName("shop_name_es");
            entity.Property(e => e.ShopNameTr)
                .HasMaxLength(50)
                .HasColumnName("shop_name_tr");
            entity.Property(e => e.ShopNameUs)
                .HasMaxLength(50)
                .HasColumnName("shop_name_us");
            entity.Property(e => e.ShopOrder).HasColumnName("shop_order");
            entity.Property(e => e.SilkPrice).HasColumnName("silk_price");
            entity.Property(e => e.SilkPriceGrow).HasColumnName("silk_price_grow");
            entity.Property(e => e.SilkPriceItem).HasColumnName("silk_price_item");
            entity.Property(e => e.SilkType).HasColumnName("silk_type");
            entity.Property(e => e.SubNameDe)
                .HasMaxLength(50)
                .HasColumnName("sub_name_de");
            entity.Property(e => e.SubNameEg)
                .HasMaxLength(50)
                .HasColumnName("sub_name_eg");
            entity.Property(e => e.SubNameEs)
                .HasMaxLength(50)
                .HasColumnName("sub_name_es");
            entity.Property(e => e.SubNameTr)
                .HasMaxLength(50)
                .HasColumnName("sub_name_tr");
            entity.Property(e => e.SubNameUs)
                .HasMaxLength(50)
                .HasColumnName("sub_name_us");
            entity.Property(e => e.SubNo).HasColumnName("sub_no");
            entity.Property(e => e.SubOrder).HasColumnName("sub_order");
            entity.Property(e => e.TrExplain)
                .HasMaxLength(2048)
                .HasColumnName("tr_explain");
            entity.Property(e => e.TrUseMethod)
                .HasMaxLength(255)
                .HasColumnName("tr_use_method");
            entity.Property(e => e.TrUseRestriction)
                .HasMaxLength(255)
                .HasColumnName("tr_use_restriction");
            entity.Property(e => e.UsExplain)
                .HasMaxLength(2048)
                .HasColumnName("us_explain");
            entity.Property(e => e.UsUseMethod)
                .HasMaxLength(255)
                .HasColumnName("us_use_method");
            entity.Property(e => e.UsUseRestriction)
                .HasMaxLength(255)
                .HasColumnName("us_use_restriction");
            entity.Property(e => e.VipLevel).HasColumnName("vip_level");
        });

        modelBuilder.Entity<VwWebPackageItemList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_WEB_PACKAGE_ITEM_LIST");

            entity.Property(e => e.AddMall).HasColumnName("add_mall");
            entity.Property(e => e.DeExplain)
                .HasMaxLength(2048)
                .HasColumnName("de_explain");
            entity.Property(e => e.DeUseMethod)
                .HasMaxLength(255)
                .HasColumnName("de_use_method");
            entity.Property(e => e.DeUseRestriction)
                .HasMaxLength(255)
                .HasColumnName("de_use_restriction");
            entity.Property(e => e.DiscountRate).HasColumnName("discount_rate");
            entity.Property(e => e.DiscountRateGrow).HasColumnName("discount_rate_grow");
            entity.Property(e => e.DiscountRateItem).HasColumnName("discount_rate_item");
            entity.Property(e => e.EgExplain)
                .HasMaxLength(2048)
                .HasColumnName("eg_explain");
            entity.Property(e => e.EgUseMethod)
                .HasMaxLength(255)
                .HasColumnName("eg_use_method");
            entity.Property(e => e.EgUseRestriction)
                .HasMaxLength(255)
                .HasColumnName("eg_use_restriction");
            entity.Property(e => e.EsExplain)
                .HasMaxLength(2048)
                .HasColumnName("es_explain");
            entity.Property(e => e.EsUseMethod)
                .HasMaxLength(255)
                .HasColumnName("es_use_method");
            entity.Property(e => e.EsUseRestriction)
                .HasMaxLength(255)
                .HasColumnName("es_use_restriction");
            entity.Property(e => e.EventNo).HasColumnName("event_no");
            entity.Property(e => e.EventNoSub).HasColumnName("event_no_sub");
            entity.Property(e => e.GrowServer).HasColumnName("grow_server");
            entity.Property(e => e.ItemServer).HasColumnName("item_server");
            entity.Property(e => e.MonthLimit).HasColumnName("month_limit");
            entity.Property(e => e.NameCode)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("name_code");
            entity.Property(e => e.OriginServer).HasColumnName("origin_server");
            entity.Property(e => e.PackageCode)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("package_code");
            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.PackageName)
                .HasMaxLength(64)
                .HasColumnName("package_name");
            entity.Property(e => e.RefNo).HasColumnName("ref_no");
            entity.Property(e => e.Service).HasColumnName("service");
            entity.Property(e => e.ShopName)
                .HasMaxLength(50)
                .HasColumnName("shop_name");
            entity.Property(e => e.SilkPrice).HasColumnName("silk_price");
            entity.Property(e => e.SilkPriceGrow).HasColumnName("silk_price_grow");
            entity.Property(e => e.SilkPriceItem).HasColumnName("silk_price_item");
            entity.Property(e => e.SilkType).HasColumnName("silk_type");
            entity.Property(e => e.SubName)
                .HasMaxLength(50)
                .HasColumnName("sub_name");
            entity.Property(e => e.SubNo).HasColumnName("sub_no");
            entity.Property(e => e.TrExplain)
                .HasMaxLength(2048)
                .HasColumnName("tr_explain");
            entity.Property(e => e.TrUseMethod)
                .HasMaxLength(255)
                .HasColumnName("tr_use_method");
            entity.Property(e => e.TrUseRestriction)
                .HasMaxLength(255)
                .HasColumnName("tr_use_restriction");
            entity.Property(e => e.UsExplain)
                .HasMaxLength(2048)
                .HasColumnName("us_explain");
            entity.Property(e => e.UsUseMethod)
                .HasMaxLength(255)
                .HasColumnName("us_use_method");
            entity.Property(e => e.UsUseRestriction)
                .HasMaxLength(255)
                .HasColumnName("us_use_restriction");
            entity.Property(e => e.VipLevel).HasColumnName("vip_level");
        });

        modelBuilder.Entity<WebAboutSilkErrorLog>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__WEB_ABOU__DC501A782BCA4AD3");

            entity.ToTable("WEB_ABOUT_SILK_ERROR_LOG");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.CpJid).HasColumnName("cp_jid");
            entity.Property(e => e.ErrorNo).HasColumnName("error_no");
            entity.Property(e => e.Location).HasColumnName("location");
            entity.Property(e => e.Param1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param1");
            entity.Property(e => e.Param10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param10");
            entity.Property(e => e.Param2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param2");
            entity.Property(e => e.Param3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param3");
            entity.Property(e => e.Param4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param4");
            entity.Property(e => e.Param5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param5");
            entity.Property(e => e.Param6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param6");
            entity.Property(e => e.Param7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param7");
            entity.Property(e => e.Param8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param8");
            entity.Property(e => e.Param9)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param9");
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("reg_date");
            entity.Property(e => e.RegIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("reg_ip");
            entity.Property(e => e.SilkReason).HasColumnName("silk_reason");
            entity.Property(e => e.SilkType).HasColumnName("silk_type");
        });

        modelBuilder.Entity<WebAboutSilkErrorLog1>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK_WEB_ABOUT_SILK_ERROR_LOG_1");

            entity.ToTable("--WEB_ABOUT_SILK_ERROR_LOG");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.CpJid).HasColumnName("cp_jid");
            entity.Property(e => e.ErrorNo).HasColumnName("error_no");
            entity.Property(e => e.Location).HasColumnName("location");
            entity.Property(e => e.Param1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param1");
            entity.Property(e => e.Param10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param10");
            entity.Property(e => e.Param2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param2");
            entity.Property(e => e.Param3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param3");
            entity.Property(e => e.Param4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param4");
            entity.Property(e => e.Param5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param5");
            entity.Property(e => e.Param6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param6");
            entity.Property(e => e.Param7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param7");
            entity.Property(e => e.Param8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param8");
            entity.Property(e => e.Param9)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param9");
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("reg_date");
            entity.Property(e => e.RegIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("reg_ip");
            entity.Property(e => e.SilkReason).HasColumnName("silk_reason");
            entity.Property(e => e.SilkType).HasColumnName("silk_type");
        });

        modelBuilder.Entity<WebActionLog>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__WEB_ACTI__DC501A7848BB8F3C");

            entity.ToTable("WEB_ACTION_LOG");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.CpJid).HasColumnName("cp_jid");
            entity.Property(e => e.Location).HasColumnName("location");
            entity.Property(e => e.Param1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param1");
            entity.Property(e => e.Param10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param10");
            entity.Property(e => e.Param2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param2");
            entity.Property(e => e.Param3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param3");
            entity.Property(e => e.Param4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param4");
            entity.Property(e => e.Param5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param5");
            entity.Property(e => e.Param6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param6");
            entity.Property(e => e.Param7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param7");
            entity.Property(e => e.Param8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param8");
            entity.Property(e => e.Param9)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("param9");
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("reg_date");
            entity.Property(e => e.RegIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("reg_ip");
        });

        modelBuilder.Entity<WebEvtItemBuy>(entity =>
        {
            entity.HasKey(e => new { e.CpJid, e.SilkAmount }).HasName("PK__WEB_EVT___59A82D3B31832429");

            entity.ToTable("WEB_EVT_ITEM_BUY");

            entity.Property(e => e.CpJid).HasColumnName("cp_jid");
            entity.Property(e => e.SilkAmount).HasColumnName("silk_amount");
            entity.Property(e => e.Idx)
                .ValueGeneratedOnAdd()
                .HasColumnName("idx");
            entity.Property(e => e.RefIdx).HasColumnName("ref_idx");
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("reg_date");
        });

        modelBuilder.Entity<WebItemBuyErrorLog>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__WEB_ITEM__DC501A78345F90D4");

            entity.ToTable("WEB_ITEM_BUY_ERROR_LOG");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.CpJid).HasColumnName("cp_jid");
            entity.Property(e => e.ErrorCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("error_code");
            entity.Property(e => e.ErrorLoc).HasColumnName("error_loc");
            entity.Property(e => e.ErrorValue)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("error_value");
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("invoice_id");
            entity.Property(e => e.InvoiceIdPortal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("invoice_id_portal");
            entity.Property(e => e.IpAddr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ip_addr");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("item_code");
            entity.Property(e => e.ItemName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("item_name");
            entity.Property(e => e.ItemNamePortal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("item_name_portal");
            entity.Property(e => e.ItemNo).HasColumnName("item_no");
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("order_id");
            entity.Property(e => e.PortalJid).HasColumnName("portal_jid");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.PriceNo).HasColumnName("price_no");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("reg_date");
        });

        modelBuilder.Entity<WebItemCertifykey>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__WEB_ITEM__DC501A78369CDF01");

            entity.ToTable("WEB_ITEM_CERTIFYKEY");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.Certifykey)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("reg_date");
            entity.Property(e => e.ShardId).HasColumnName("ShardID");
            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<WebItemGiveList>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK_SK_ItemGiveList");

            entity.ToTable("WEB_ITEM_GIVE_LIST");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.CharacterId).HasColumnName("character_id");
            entity.Property(e => e.CharacterLv).HasColumnName("character_lv");
            entity.Property(e => e.CpInvoiceId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("cp_invoice_id");
            entity.Property(e => e.CpJid).HasColumnName("cp_jid");
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("invoice_id");
            entity.Property(e => e.ItemCodePackage)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("item_code_package");
            entity.Property(e => e.ItemNamePackage)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("item_name_package");
            entity.Property(e => e.Message)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("message");
            entity.Property(e => e.NameCodePackage)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("name_code_package");
            entity.Property(e => e.RecieveDate)
                .HasColumnType("datetime")
                .HasColumnName("recieve_date");
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("reg_date");
            entity.Property(e => e.RegIp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("reg_ip");
            entity.Property(e => e.Section).HasColumnName("section");
            entity.Property(e => e.ShardId).HasColumnName("shard_id");
            entity.Property(e => e.SilkGift).HasColumnName("silk_gift");
            entity.Property(e => e.SilkGiftPremium).HasColumnName("silk_gift_premium");
            entity.Property(e => e.SilkOwn).HasColumnName("silk_own");
            entity.Property(e => e.SilkOwnPremium).HasColumnName("silk_own_premium");
            entity.Property(e => e.SilkPoint).HasColumnName("silk_point");
        });

        modelBuilder.Entity<WebItemGiveListDetail>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__WEB_ITEM__DC501A787EBF6A27");

            entity.ToTable("WEB_ITEM_GIVE_LIST_DETAIL");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("item_code");
            entity.Property(e => e.ItemName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("item_name");
            entity.Property(e => e.ItemQuantity).HasColumnName("item_quantity");
            entity.Property(e => e.RefIdx).HasColumnName("ref_idx");
            entity.Property(e => e.RefRent).HasColumnName("ref_rent");
        });

        modelBuilder.Entity<WebItemGiveNotice>(entity =>
        {
            entity.HasKey(e => e.RefIdx).HasName("PK__WEB_ITEM__ACC41FFBCB14C2F5");

            entity.ToTable("WEB_ITEM_GIVE_NOTICE");

            entity.Property(e => e.RefIdx)
                .ValueGeneratedNever()
                .HasColumnName("ref_idx");
            entity.Property(e => e.CpJid).HasColumnName("cp_jid");
            entity.Property(e => e.Idx)
                .ValueGeneratedOnAdd()
                .HasColumnName("idx");
        });

        modelBuilder.Entity<WebItemPopular>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WEB_ITEM_POPULAR");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.PackageName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("package_name");
        });

        modelBuilder.Entity<WebItemRentInfo>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__WEB_ITEM__DC501A7842ADB02B");

            entity.ToTable("WEB_ITEM_RENT_INFO");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.CanDelete).HasColumnName("can_delete");
            entity.Property(e => e.CanRecharge).HasColumnName("can_recharge");
            entity.Property(e => e.DateBegin)
                .HasColumnType("smalldatetime")
                .HasColumnName("date_begin");
            entity.Property(e => e.DateEnd)
                .HasColumnType("smalldatetime")
                .HasColumnName("date_end");
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("reg_date");
            entity.Property(e => e.RentType).HasColumnName("rent_type");
            entity.Property(e => e.Subject)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("subject");
            entity.Property(e => e.TimeCount).HasColumnName("time_count");
        });

        modelBuilder.Entity<WebItemReserved>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__WEB_ITEM__DC501A78D8B7805D");

            entity.ToTable("WEB_ITEM_RESERVED");

            entity.HasIndex(e => new { e.Userjid, e.PackageId }, "UQ__WEB_ITEM__EB98E08CD161EE35").IsUnique();

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.Userjid).HasColumnName("userjid");
        });

        modelBuilder.Entity<WebMallCategory>(entity =>
        {
            entity.HasKey(e => e.ShopNo).HasName("PK__WEB_MALL__AD093CE94B42F62C");

            entity.ToTable("WEB_MALL_CATEGORY");

            entity.Property(e => e.ShopNo)
                .ValueGeneratedNever()
                .HasColumnName("shop_no");
            entity.Property(e => e.ShopNameDe)
                .HasMaxLength(50)
                .HasColumnName("shop_name_de");
            entity.Property(e => e.ShopNameEg)
                .HasMaxLength(50)
                .HasColumnName("shop_name_eg");
            entity.Property(e => e.ShopNameEs)
                .HasMaxLength(50)
                .HasColumnName("shop_name_es");
            entity.Property(e => e.ShopNameTr)
                .HasMaxLength(50)
                .HasColumnName("shop_name_tr");
            entity.Property(e => e.ShopNameUs)
                .HasMaxLength(50)
                .HasColumnName("shop_name_us");
            entity.Property(e => e.ShopOrder).HasColumnName("shop_order");
        });

        modelBuilder.Entity<WebMallCategorySub>(entity =>
        {
            entity.HasKey(e => new { e.RefNo, e.SubNo }).HasName("PK__WEB_MALL__5B30440B4E1F62D7");

            entity.ToTable("WEB_MALL_CATEGORY_SUB");

            entity.Property(e => e.RefNo).HasColumnName("ref_no");
            entity.Property(e => e.SubNo).HasColumnName("sub_no");
            entity.Property(e => e.SubNameDe)
                .HasMaxLength(50)
                .HasColumnName("sub_name_de");
            entity.Property(e => e.SubNameEg)
                .HasMaxLength(50)
                .HasColumnName("sub_name_eg");
            entity.Property(e => e.SubNameEs)
                .HasMaxLength(50)
                .HasColumnName("sub_name_es");
            entity.Property(e => e.SubNameTr)
                .HasMaxLength(50)
                .HasColumnName("sub_name_tr");
            entity.Property(e => e.SubNameUs)
                .HasMaxLength(50)
                .HasColumnName("sub_name_us");
            entity.Property(e => e.SubOrder).HasColumnName("sub_order");
        });

        modelBuilder.Entity<WebMessageBox>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__WEB_MESS__DC501A7850FBCF82");

            entity.ToTable("WEB_MESSAGE_BOX");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.Contents)
                .HasMaxLength(1000)
                .HasColumnName("contents");
            entity.Property(e => e.FromCharacter)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("from_character");
            entity.Property(e => e.FromCpJid).HasColumnName("from_cp_jid");
            entity.Property(e => e.FromShard)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("from_shard");
            entity.Property(e => e.FromUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("from_user_id");
            entity.Property(e => e.IsDel).HasColumnName("is_del");
            entity.Property(e => e.OpenDate)
                .HasColumnType("datetime")
                .HasColumnName("open_date");
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("reg_date");
            entity.Property(e => e.Silk).HasColumnName("silk");
            entity.Property(e => e.Subject)
                .HasMaxLength(50)
                .HasColumnName("subject");
            entity.Property(e => e.ToCharacter)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("to_character");
            entity.Property(e => e.ToCpJid).HasColumnName("to_cp_jid");
            entity.Property(e => e.ToShard)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("to_shard");
        });

        modelBuilder.Entity<WebMessageBoxR>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__WEB_MESS__DC501A7853D83C2D");

            entity.ToTable("WEB_MESSAGE_BOX_R");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.Contents)
                .HasMaxLength(1000)
                .HasColumnName("contents");
            entity.Property(e => e.FromCharacter)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("from_character");
            entity.Property(e => e.FromCpJid).HasColumnName("from_cp_jid");
            entity.Property(e => e.FromShard)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("from_shard");
            entity.Property(e => e.FromUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("from_user_id");
            entity.Property(e => e.IsDel).HasColumnName("is_del");
            entity.Property(e => e.OpenDate)
                .HasColumnType("datetime")
                .HasColumnName("open_date");
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("reg_date");
            entity.Property(e => e.Silk).HasColumnName("silk");
            entity.Property(e => e.Subject)
                .HasMaxLength(50)
                .HasColumnName("subject");
            entity.Property(e => e.ToCpJid).HasColumnName("to_cp_jid");
        });

        modelBuilder.Entity<WebPackageItem>(entity =>
        {
            entity.HasKey(e => e.PackageId).HasName("PK__WEB_PACK__63846AE8664BF223");

            entity.ToTable("WEB_PACKAGE_ITEM");

            entity.HasIndex(e => e.PackageCode, "UQ__WEB_PACK__EB2BA8CB69285ECE").IsUnique();

            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.DiscountRate).HasColumnName("discount_rate");
            entity.Property(e => e.DiscountRateGrow).HasColumnName("discount_rate_grow");
            entity.Property(e => e.DiscountRateItem).HasColumnName("discount_rate_item");
            entity.Property(e => e.EventNo).HasColumnName("event_no");
            entity.Property(e => e.EventNoSub).HasColumnName("event_no_sub");
            entity.Property(e => e.GrowServer).HasColumnName("grow_server");
            entity.Property(e => e.ItemServer).HasColumnName("item_server");
            entity.Property(e => e.MonthLimit).HasColumnName("month_limit");
            entity.Property(e => e.NameCode)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("name_code");
            entity.Property(e => e.OriginServer).HasColumnName("origin_server");
            entity.Property(e => e.PackageCode)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("package_code");
            entity.Property(e => e.Service).HasColumnName("service");
            entity.Property(e => e.ShopNo).HasColumnName("shop_no");
            entity.Property(e => e.ShopNoSub).HasColumnName("shop_no_sub");
            entity.Property(e => e.ShopType)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("shop_type");
            entity.Property(e => e.SilkPrice).HasColumnName("silk_price");
            entity.Property(e => e.SilkPriceGrow).HasColumnName("silk_price_grow");
            entity.Property(e => e.SilkPriceItem).HasColumnName("silk_price_item");
            entity.Property(e => e.SilkType).HasColumnName("silk_type");
            entity.Property(e => e.VipLevel).HasColumnName("vip_level");
        });

        modelBuilder.Entity<WebPackageItemDetail>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__WEB_PACK__DC501A7862265B84");

            entity.ToTable("WEB_PACKAGE_ITEM_DETAIL");

            entity.HasIndex(e => e.PackageId, "IX_WEB_PACKAGE_ITEM_DETAIL_package_id").HasFillFactor(70);

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("item_code");
            entity.Property(e => e.ItemName)
                .HasMaxLength(64)
                .HasColumnName("item_name");
            entity.Property(e => e.ItemNameEng)
                .HasMaxLength(64)
                .HasColumnName("item_name_eng");
            entity.Property(e => e.ItemQuantity).HasColumnName("item_quantity");
            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.RefRent).HasColumnName("ref_rent");
        });

        modelBuilder.Entity<WebPackageItemLang>(entity =>
        {
            entity.HasKey(e => e.PackageId).HasName("PK__WEB_PACK__63846AE86502C82F");

            entity.ToTable("WEB_PACKAGE_ITEM_LANG");

            entity.Property(e => e.PackageId)
                .ValueGeneratedNever()
                .HasColumnName("package_id");
            entity.Property(e => e.DeExplain)
                .HasMaxLength(2048)
                .HasColumnName("de_explain");
            entity.Property(e => e.DeUseMethod)
                .HasMaxLength(255)
                .HasColumnName("de_use_method");
            entity.Property(e => e.DeUseRestriction)
                .HasMaxLength(1024)
                .HasColumnName("de_use_restriction");
            entity.Property(e => e.EgExplain)
                .HasMaxLength(2048)
                .HasColumnName("eg_explain");
            entity.Property(e => e.EgUseMethod)
                .HasMaxLength(255)
                .HasColumnName("eg_use_method");
            entity.Property(e => e.EgUseRestriction)
                .HasMaxLength(1024)
                .HasColumnName("eg_use_restriction");
            entity.Property(e => e.EsExplain)
                .HasMaxLength(2048)
                .HasColumnName("es_explain");
            entity.Property(e => e.EsUseMethod)
                .HasMaxLength(255)
                .HasColumnName("es_use_method");
            entity.Property(e => e.EsUseRestriction)
                .HasMaxLength(1024)
                .HasColumnName("es_use_restriction");
            entity.Property(e => e.PackageName)
                .HasMaxLength(64)
                .HasColumnName("package_name");
            entity.Property(e => e.TrExplain)
                .HasMaxLength(2048)
                .HasColumnName("tr_explain");
            entity.Property(e => e.TrUseMethod)
                .HasMaxLength(255)
                .HasColumnName("tr_use_method");
            entity.Property(e => e.TrUseRestriction)
                .HasMaxLength(1024)
                .HasColumnName("tr_use_restriction");
            entity.Property(e => e.UsExplain)
                .HasMaxLength(2048)
                .HasColumnName("us_explain");
            entity.Property(e => e.UsUseMethod)
                .HasMaxLength(255)
                .HasColumnName("us_use_method");
            entity.Property(e => e.UsUseRestriction)
                .HasMaxLength(1024)
                .HasColumnName("us_use_restriction");
        });

        modelBuilder.Entity<WebPackageItemMall>(entity =>
        {
            entity.HasKey(e => e.PackageId).HasName("PK__WEB_PACK__63846AE867DF34DA");

            entity.ToTable("WEB_PACKAGE_ITEM_MALL");

            entity.Property(e => e.PackageId)
                .ValueGeneratedNever()
                .HasColumnName("package_id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.IsBest).HasColumnName("is_best");
            entity.Property(e => e.IsList).HasColumnName("is_list");
            entity.Property(e => e.IsNew).HasColumnName("is_new");
            entity.Property(e => e.ItemOrder).HasColumnName("item_order");
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("reg_date");
        });

        modelBuilder.Entity<WebPackageItemPreview>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__WEB_PACK__DC501A781F2D3A64");

            entity.ToTable("WEB_PACKAGE_ITEM_PREVIEW");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Display).HasColumnName("display");
            entity.Property(e => e.DisplayNum).HasColumnName("display_num");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("item_code");
            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.RentType).HasColumnName("rent_type");
            entity.Property(e => e.SetGroup).HasColumnName("set_group");
            entity.Property(e => e.SilkPrice).HasColumnName("silk_price");
            entity.Property(e => e.SilkType).HasColumnName("silk_type");
        });

        modelBuilder.Entity<WebVoteAnswer>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__WEB_VOTE__DC501A786ABBA185");

            entity.ToTable("WEB_VOTE_ANSWER");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.AnswerDe)
                .HasMaxLength(300)
                .HasColumnName("answer_de");
            entity.Property(e => e.AnswerEg)
                .HasMaxLength(300)
                .HasColumnName("answer_eg");
            entity.Property(e => e.AnswerEs)
                .HasMaxLength(300)
                .HasColumnName("answer_es");
            entity.Property(e => e.AnswerTr)
                .HasMaxLength(300)
                .HasColumnName("answer_tr");
            entity.Property(e => e.AnswerUs)
                .HasMaxLength(300)
                .HasColumnName("answer_us");
            entity.Property(e => e.QueNum).HasColumnName("que_num");
        });

        modelBuilder.Entity<WebVoteItem>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__WEB_VOTE__DC501A786D980E30");

            entity.ToTable("WEB_VOTE_ITEM");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("item_code");
            entity.Property(e => e.ItemName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("item_name");
            entity.Property(e => e.ItemQuantity).HasColumnName("item_quantity");
            entity.Property(e => e.ItemSnCode)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("item_sn_code");
            entity.Property(e => e.PollNum).HasColumnName("poll_num");
        });

        modelBuilder.Entity<WebVoteMain>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__WEB_VOTE__DC501A7870747ADB");

            entity.ToTable("WEB_VOTE_MAIN");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.GroupNum).HasColumnName("group_num");
            entity.Property(e => e.MessageDe)
                .HasMaxLength(500)
                .HasColumnName("message_de");
            entity.Property(e => e.MessageEg)
                .HasMaxLength(500)
                .HasColumnName("message_eg");
            entity.Property(e => e.MessageEs)
                .HasMaxLength(500)
                .HasColumnName("message_es");
            entity.Property(e => e.MessageTr)
                .HasMaxLength(500)
                .HasColumnName("message_tr");
            entity.Property(e => e.MessageUs)
                .HasMaxLength(500)
                .HasColumnName("message_us");
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("reg_date");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.SubjectDe)
                .HasMaxLength(100)
                .HasColumnName("subject_de");
            entity.Property(e => e.SubjectEg)
                .HasMaxLength(100)
                .HasColumnName("subject_eg");
            entity.Property(e => e.SubjectEs)
                .HasMaxLength(100)
                .HasColumnName("subject_es");
            entity.Property(e => e.SubjectTr)
                .HasMaxLength(100)
                .HasColumnName("subject_tr");
            entity.Property(e => e.SubjectUs)
                .HasMaxLength(100)
                .HasColumnName("subject_us");
            entity.Property(e => e.SynopsisDe)
                .HasMaxLength(500)
                .HasColumnName("synopsis_de");
            entity.Property(e => e.SynopsisEg)
                .HasMaxLength(500)
                .HasColumnName("synopsis_eg");
            entity.Property(e => e.SynopsisEs)
                .HasMaxLength(500)
                .HasColumnName("synopsis_es");
            entity.Property(e => e.SynopsisTr)
                .HasMaxLength(500)
                .HasColumnName("synopsis_tr");
            entity.Property(e => e.SynopsisUs)
                .HasMaxLength(500)
                .HasColumnName("synopsis_us");
        });

        modelBuilder.Entity<WebVoteQuestion>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__WEB_VOTE__DC501A787350E786");

            entity.ToTable("WEB_VOTE_QUESTION");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.PollNum).HasColumnName("poll_num");
            entity.Property(e => e.QuestionDe)
                .HasMaxLength(300)
                .HasColumnName("question_de");
            entity.Property(e => e.QuestionEg)
                .HasMaxLength(300)
                .HasColumnName("question_eg");
            entity.Property(e => e.QuestionEs)
                .HasMaxLength(300)
                .HasColumnName("question_es");
            entity.Property(e => e.QuestionTr)
                .HasMaxLength(300)
                .HasColumnName("question_tr");
            entity.Property(e => e.QuestionUs)
                .HasMaxLength(300)
                .HasColumnName("question_us");
        });

        modelBuilder.Entity<WebVoteUser>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__WEB_VOTE__DC501A78762D5431");

            entity.ToTable("WEB_VOTE_USER");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.Charlevel).HasColumnName("charlevel");
            entity.Property(e => e.Charname)
                .HasMaxLength(30)
                .HasColumnName("charname");
            entity.Property(e => e.Class)
                .HasMaxLength(20)
                .HasColumnName("class");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(10)
                .HasColumnName("country_code");
            entity.Property(e => e.CpJid).HasColumnName("cp_jid");
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.Job)
                .HasMaxLength(20)
                .HasColumnName("job");
            entity.Property(e => e.PollNum).HasColumnName("poll_num");
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("reg_date");
            entity.Property(e => e.ShardId).HasColumnName("shard_id");
        });

        modelBuilder.Entity<WebVoteUserDetail>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PK__WEB_VOTE__DC501A787909C0DC");

            entity.ToTable("WEB_VOTE_USER_DETAIL");

            entity.Property(e => e.Idx).HasColumnName("idx");
            entity.Property(e => e.AnsNum).HasColumnName("ans_num");
            entity.Property(e => e.QueNum).HasColumnName("que_num");
            entity.Property(e => e.RefIdx).HasColumnName("ref_idx");
        });

        modelBuilder.Entity<WorldIp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_WorldIP");

            entity.HasIndex(e => e.DwIp, "CX__WorldIP_nIP")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.DwIp)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("dwIP");
            entity.Property(e => e.NCount).HasColumnName("nCount");
            entity.Property(e => e.SzCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("szCode");
        });

        modelBuilder.Entity<WorldIptemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_WorldIPTemp");

            entity.HasIndex(e => e.DwIp, "CX__WorldIPTemp_nIP")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.DwIp)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("dwIP");
            entity.Property(e => e.NCount).HasColumnName("nCount");
            entity.Property(e => e.SzCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("szCode");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
