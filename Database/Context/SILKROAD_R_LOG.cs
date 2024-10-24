
using BimBot.Database.SILKROAD_R_LOG;
using Microsoft.EntityFrameworkCore;

namespace BimBot.Database.Context;

public partial class SILKROAD_R_LOG : DbContext
{
    public SILKROAD_R_LOG()
    {
    }

    public virtual DbSet<AddLogInstanceWorldInfo> AddLogInstanceWorldInfos { get; set; }

    public virtual DbSet<CompeltedConsignmentTradeLog> CompeltedConsignmentTradeLogs { get; set; }

    public virtual DbSet<ConsignmentTradePrevInvestCharLog> ConsignmentTradePrevInvestCharLogs { get; set; }

    public virtual DbSet<ConsignmentTradeProgressRuntimeLog> ConsignmentTradeProgressRuntimeLogs { get; set; }

    public virtual DbSet<ConsignmentTradeReward> ConsignmentTradeRewards { get; set; }

    public virtual DbSet<EntryTicketLog> EntryTicketLogs { get; set; }

    public virtual DbSet<LogBot> LogBots { get; set; }

    public virtual DbSet<LogCashItem> LogCashItems { get; set; }

    public virtual DbSet<LogChatMessage> LogChatMessages { get; set; }

    public virtual DbSet<LogEventBot> LogEventBots { get; set; }

    public virtual DbSet<LogEventChar> LogEventChars { get; set; }

    public virtual DbSet<LogEventItem> LogEventItems { get; set; }

    public virtual DbSet<LogEventItem1> LogEventItem1s { get; set; }

    public virtual DbSet<LogEventSiegeFortress> LogEventSiegeFortresses { get; set; }

    public virtual DbSet<LogInitializeCharSkill> LogInitializeCharSkills { get; set; }

    public virtual DbSet<LogInitializeCharSkillMastery> LogInitializeCharSkillMasteries { get; set; }

    public virtual DbSet<LogInstanceWorldInfo> LogInstanceWorldInfos { get; set; }

    public virtual DbSet<LogRollBookItemPay> LogRollBookItemPays { get; set; }

    public virtual DbSet<LogSchedule> LogSchedules { get; set; }

    public virtual DbSet<LogServerEvent> LogServerEvents { get; set; }

    public virtual DbSet<LogUseInitializeSkillItem> LogUseInitializeSkillItems { get; set; }

    public virtual DbSet<LogWebCashItem> LogWebCashItems { get; set; }

    public virtual DbSet<StatisticsGoldIncrementDatum> StatisticsGoldIncrementData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(DatabaseManager.SroVtLogConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Chinese_PRC_CI_AS");

        modelBuilder.Entity<AddLogInstanceWorldInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_AddLogInstanceWorldInfo");

            entity.Property(e => e.Idk1).HasColumnName("IDK1");
            entity.Property(e => e.Idk2)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("IDK2");
            entity.Property(e => e.RefTriggerCommonId).HasColumnName("RefTriggerCommonID");
            entity.Property(e => e.WorldCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.WorldId).HasColumnName("WorldID");
        });

        modelBuilder.Entity<CompeltedConsignmentTradeLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CompeltedConsignmentTradeLOG__ID");

            entity.ToTable("_CompeltedConsignmentTradeLOG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.ProgressId).HasColumnName("ProgressID");
        });

        modelBuilder.Entity<ConsignmentTradePrevInvestCharLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK___ConsignmentTrade_PrevInvestCharLog__ID");

            entity.ToTable("_ConsignmentTrade_PrevInvestCharLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.ProgressId).HasColumnName("ProgressID");
            entity.Property(e => e.RefObjId).HasColumnName("RefObjID");
        });

        modelBuilder.Entity<ConsignmentTradeProgressRuntimeLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ConsignmentTrade_Progress_RuntimeLog__ID");

            entity.ToTable("_ConsignmentTrade_Progress_RuntimeLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.StrDesc)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("strDesc");
        });

        modelBuilder.Entity<ConsignmentTradeReward>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_ConsignmentTrade_Reward");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ProgressId).HasColumnName("ProgressID");
            entity.Property(e => e.Ratio)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EntryTicketLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_EntryTicketLog");

            entity.HasIndex(e => e.EventId, "IX__EntryTicketLog_EventID").HasFillFactor(90);

            entity.HasIndex(e => e.Jid, "IX__EntryTicketLog_JID").HasFillFactor(90);

            entity.Property(e => e.CharName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Desc)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("smalldatetime");
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.ItemCodeName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Jid).HasColumnName("JID");
        });

        modelBuilder.Entity<LogBot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LogBot");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.Desc)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LogCashItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LogCashItem");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
        });

        modelBuilder.Entity<LogChatMessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LogChatMessage ");

            entity.Property(e => e.CharName16)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChatType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShardName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<LogEventBot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LogEventBot");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.StrDesc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("strDesc");
            entity.Property(e => e.UserJid).HasColumnName("UserJID");
        });

        modelBuilder.Entity<LogEventChar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LogEventChar");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.EventPos)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.StrDesc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("strDesc");
        });

        modelBuilder.Entity<LogEventItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LogEventItem");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.DwData).HasColumnName("dwData");
            entity.Property(e => e.EventPos)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.Gold).HasDefaultValue(0L);
            entity.Property(e => e.ItemRefId).HasColumnName("ItemRefID");
            entity.Property(e => e.SlotFrom).HasColumnName("Slot_From");
            entity.Property(e => e.SlotTo).HasColumnName("Slot_To");
            entity.Property(e => e.StrDesc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("strDesc");
        });

        modelBuilder.Entity<LogEventItem1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LogEventItem_1");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.DwData).HasColumnName("dwData");
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.ItemRefId).HasColumnName("ItemRefID");
            entity.Property(e => e.SlotFrom).HasColumnName("Slot_From");
            entity.Property(e => e.SlotTo).HasColumnName("Slot_To");
        });

        modelBuilder.Entity<LogEventSiegeFortress>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LogEventSiegeFortress");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.FortressId).HasColumnName("FortressID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.StrDesc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("strDesc");
        });

        modelBuilder.Entity<LogInitializeCharSkill>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LogInitializeCharSkill");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SkillId).HasColumnName("SkillID");
        });

        modelBuilder.Entity<LogInitializeCharSkillMastery>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LogInitializeCharSkillMastery");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MasteryId).HasColumnName("MasteryID");
        });

        modelBuilder.Entity<LogInstanceWorldInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LogInstanceWorldInfo");

            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.GameWorldLayerId).HasColumnName("GameWorldLayerID");
            entity.Property(e => e.Value)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.ValueCodeName128)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.WorldId).HasColumnName("WorldID");
        });

        modelBuilder.Entity<LogRollBookItemPay>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LogRollBookItemPay");

            entity.Property(e => e.CharName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.LogDate).HasColumnType("datetime");
            entity.Property(e => e.PayItemCodeName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LogSchedule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LogSchedule");

            entity.HasIndex(e => e.OccureTime, "CX_LOG_SCHEDULE_OCCURETIME").IsClustered();

            entity.HasIndex(e => e.Id, "IX_LOG_SCHEDULE_IDX");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.OccureTime).HasColumnType("datetime");
            entity.Property(e => e.ScheduleDefine)
                .HasMaxLength(124)
                .IsUnicode(false);
            entity.Property(e => e.ServerBodyId).HasColumnName("ServerBodyID");
            entity.Property(e => e.ServerType)
                .HasMaxLength(124)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LogServerEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LogServerEvent");

            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ServerEventId).HasColumnName("ServerEventID");
            entity.Property(e => e.StrDesc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("strDesc");
        });

        modelBuilder.Entity<LogUseInitializeSkillItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_LogUseInitializeSkillItem");

            entity.Property(e => e.AfterRemainSp).HasColumnName("AfterRemainSP");
            entity.Property(e => e.BeforeRemainSp).HasColumnName("BeforeRemainSP");
            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.InitDate).HasColumnType("datetime");
            entity.Property(e => e.ItemRefId).HasColumnName("ItemRefID");
        });

        modelBuilder.Entity<LogWebCashItem>(entity =>
        {
            entity.HasKey(e => new { e.Idx, e.SubIdx }).HasName("PK__LogWebCashItem_1");

            entity.ToTable("_LogWebCashItem");

            entity.Property(e => e.Idx).HasColumnName("IDX");
            entity.Property(e => e.SubIdx).HasColumnName("SubIDX");
            entity.Property(e => e.CharId).HasColumnName("CharID");
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.RecvDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RefItemId).HasColumnName("RefItemID");
            entity.Property(e => e.StrDesc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("strDesc");
        });

        modelBuilder.Entity<StatisticsGoldIncrementDatum>(entity =>
        {
            entity.HasKey(e => e.BeginDate).HasName("PK____StatisticsGold__7A9C383C");

            entity.ToTable("__StatisticsGoldIncrementData__");

            entity.Property(e => e.BeginDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
