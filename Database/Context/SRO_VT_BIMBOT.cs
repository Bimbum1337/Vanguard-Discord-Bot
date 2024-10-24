using BimBot.Database.SRO_VT_BIMBOT;
using Microsoft.EntityFrameworkCore;

namespace BimBot.Database.Context
{
    public partial class SRO_VT_BIMBOT : DbContext
    {
        public SRO_VT_BIMBOT()
        {

        }

        public SRO_VT_BIMBOT(DbContextOptions<SRO_VT_BIMBOT> options)
            : base(options)
        {
        }

        public virtual DbSet<BlackListWords> BlackListWords { get; set; }
        public virtual DbSet<Help> Help { get; set; }
        public virtual DbSet<DefaultGuildCategories> DefaultGuildCategories { get; set; }
        public virtual DbSet<DefaultGuildCategoriesPermissions> DefaultGuildCategoriesPermissions { get; set; }
        public virtual DbSet<DefaultGuildChannels> DefaultGuildChannels { get; set; }
        public virtual DbSet<DefaultGuildRoles> DefaultGuildRoles { get; set; }
        public virtual DbSet<DefaultGuildRolesPermissions> DefaultGuildRolesPermissions { get; set; }
        public virtual DbSet<DatabaseCommands> DatabaseCommands { get; set; }
        public virtual DbSet<UniqueInformation> UniqueInformation { get; set; }
        public virtual DbSet<UniqueInformationRecords> UniqueInformationRecords { get; set; }
        public virtual DbSet<InviteLogger> InviteLoggers { get; set; }
        public virtual DbSet<PollsLogger> PollsLoggers { get; set; }
        public virtual DbSet<DefaultSentMessages> DefaultSentMessages { get; set; }
        public virtual DbSet<TicketSystem> TicketSystem { get; set; }
        public virtual DbSet<Giveaway> Giveaways { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(DatabaseManager.SroVtBimBotConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlackListWords>(entity =>
            {
                entity.ToTable("_BlackListWords");

                entity.HasKey(e => e.ID).HasName("PK_dbo._BlackListWords_ID");

                entity.Property(e => e.Word)
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Help>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK_dbo._Help_ID");

                entity.ToTable("_Help");

                entity.HasMany(c => c.HelpEmbeds).WithOne(e => e.Help)
                                    .HasForeignKey(d => d.Help_ID)
                                    .OnDelete(DeleteBehavior.ClientSetNull)
                                    .HasConstraintName("FK_dbo._Help._HelpEmbeds_ID");

                entity.HasMany(c => c.HelpMessages).WithOne(e => e.Help)
                                    .HasForeignKey(d => d.Help_ID)
                                    .OnDelete(DeleteBehavior.ClientSetNull)
                                    .HasConstraintName("FK_dbo._Help._HelpMessages_ID");
            });

            modelBuilder.Entity<HelpEmbed>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK_dbo._HelpEmbed");

                entity.ToTable("_HelpEmbed");
            });

            modelBuilder.Entity<HelpMessage>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK_dbo._HelpMessage");

                entity.ToTable("_HelpMessage");
            });

            modelBuilder.Entity<DefaultGuildCategories>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK_dbo._DefaultGuildCategories");

                entity.ToTable("_DefaultGuildCategories");

                entity.HasMany(c => c.Channels).WithOne(e => e.Category)
                                    .HasForeignKey(d => d.Category_ID)
                                    .OnDelete(DeleteBehavior.ClientSetNull)
                                    .HasConstraintName("FK_dbo._DefaultGuildCategories._Channels_ID");
            });

            modelBuilder.Entity<DefaultGuildCategoriesPermissions>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK_dbo._DefaultGuildCategoriesPermissions");

                entity.ToTable("_DefaultGuildCategoriesPermissions");

                entity.HasMany(c => c.Categories).WithOne(e => e.CategoriesPermissions)
                    .HasForeignKey(d => d.Permission_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo._DefaultGuildCategoriesPermissions._Categories_ID");
            });

            modelBuilder.Entity<DefaultGuildChannels>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK_dbo._DefaultGuildChannels");

                entity.ToTable("_DefaultGuildChannels");
            });

            modelBuilder.Entity<DefaultGuildRoles>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK_dbo._DefaultGuildRoles");

                entity.ToTable("_DefaultGuildRoles");
            });

            modelBuilder.Entity<DefaultGuildRolesPermissions>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK_dbo._DefaultGuildRolesPermissions");

                entity.ToTable("_DefaultGuildRolesPermissions");

                entity.HasMany(c => c.Roles).WithOne(e => e.RolesPermissions)
                    .HasForeignKey(d => d.Permission_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo._DefaultGuildRolesPermissions._Roles_ID");
            });

            modelBuilder.Entity<DatabaseCommands>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK_dbo._DatabaseCommands");

                entity.ToTable("_DatabaseCommands");
            });

            modelBuilder.Entity<UniqueInformation>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK_dbo._UniqueInformation");

                entity.ToTable("_UniqueInformation");

                entity.HasMany(c => c.Records).WithOne(e => e.UniqueInformation)
                    .HasForeignKey(d => d.Unique_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo._UniqueInformation._Records_ID");
            });

            modelBuilder.Entity<UniqueInformationRecords>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK_dbo._UniqueInformationRecords");

                entity.ToTable("_UniqueInformationRecords");
            });

            modelBuilder.Entity<InviteLogger>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK_dbo._InviteLogger");

                entity.ToTable("_InviteLogger");
            });

            modelBuilder.Entity<PollsLogger>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK_dbo._PollsLogger");

                entity.ToTable("_PollsLogger");

                entity.HasMany(c => c.Records).WithOne(e => e.PollsLogger)
                    .HasForeignKey(d => d.Poll_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo._PollsLogger._Records_ID");
            });

            modelBuilder.Entity<PollsLoggerRecords>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK_dbo._PollsLoggerRecords");

                entity.ToTable("_PollsLoggerRecords");
            });

            modelBuilder.Entity<DefaultSentMessages>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK_dbo._DefaultSentMessages");

                entity.ToTable("_DefaultSentMessages");
            });

            modelBuilder.Entity<TicketSystem>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK_dbo._TicketSystem");

                entity.ToTable("_TicketSystem");
            });


            modelBuilder.Entity<Giveaway>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK_dbo._Giveaway");

                entity.ToTable("_Giveaway");

                entity.HasMany(c => c.Records).WithOne(e => e.Giveaway)
                    .HasForeignKey(d => d.Giveaway_ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo._Giveaway._Records_ID");
            });

            modelBuilder.Entity<GiveawayRecords>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK_dbo._GiveawayRecords");

                entity.ToTable("_GiveawayRecords");
            });
        }
    }
}
