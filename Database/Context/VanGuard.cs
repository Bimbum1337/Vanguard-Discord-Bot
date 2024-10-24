using BimBot.Database.VanGuard;
using Microsoft.EntityFrameworkCore;

namespace BimBot.Database.Context
{
    public partial class VanGuard : DbContext
    {
        public VanGuard()
        {
        }

        public virtual DbSet<_GameServerEventScheduling> EventSchedulings { get; set; }
        public virtual DbSet<_GameServerMatching_Register_Participants> MatchingData { get; set; }
        public virtual DbSet<_GameServerOnlinePlayerStatus> OnlinePlayers { get; set; }
        public virtual DbSet<_SharedContentConfig> Configs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlServer(DatabaseManager.VanGuardConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<_GameServerEventScheduling>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK__GameServerEventScheduling_ID");

                entity.ToTable("_GameServerEventScheduling");
            });

            modelBuilder.Entity<_GameServerMatching_Register_Participants>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK__GameServerMatching_Register_Participants");

                entity.ToTable("_GameServerMatching_Register_Participants");
            });

            modelBuilder.Entity<_GameServerOnlinePlayerStatus>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK__GameServerOnlinePlayerStatus");

                entity.ToTable("_GameServerOnlinePlayerStatus");
            });

            modelBuilder.Entity<_SharedContentConfig>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PK__SharedContentConfig");

                entity.ToTable("_SharedContentConfig");
            });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
