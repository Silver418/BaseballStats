using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BaseballModel.Entities;

namespace BaseballModel.Context
{
    public partial class BaseballContext : DbContext
    {
        public BaseballContext()
        {
        }

        public BaseballContext(DbContextOptions<BaseballContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AllstarFull> AllstarFulls { get; set; } = null!;
        public virtual DbSet<Appearance> Appearances { get; set; } = null!;
        public virtual DbSet<AwardsManager> AwardsManagers { get; set; } = null!;
        public virtual DbSet<AwardsPlayer> AwardsPlayers { get; set; } = null!;
        public virtual DbSet<AwardsShareManager> AwardsShareManagers { get; set; } = null!;
        public virtual DbSet<AwardsSharePlayer> AwardsSharePlayers { get; set; } = null!;
        public virtual DbSet<Batting> Battings { get; set; } = null!;
        public virtual DbSet<BattingPost> BattingPosts { get; set; } = null!;
        public virtual DbSet<CollegePlaying> CollegePlayings { get; set; } = null!;
        public virtual DbSet<Fielding> Fieldings { get; set; } = null!;
        public virtual DbSet<FieldingOf> FieldingOfs { get; set; } = null!;
        public virtual DbSet<FieldingOfsplit> FieldingOfsplits { get; set; } = null!;
        public virtual DbSet<FieldingPost> FieldingPosts { get; set; } = null!;
        public virtual DbSet<HallOfFame> HallOfFames { get; set; } = null!;
        public virtual DbSet<HomeGame> HomeGames { get; set; } = null!;
        public virtual DbSet<Manager> Managers { get; set; } = null!;
        public virtual DbSet<ManagersHalf> ManagersHalves { get; set; } = null!;
        public virtual DbSet<Park> Parks { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<Pitching> Pitchings { get; set; } = null!;
        public virtual DbSet<PitchingPost> PitchingPosts { get; set; } = null!;
        public virtual DbSet<Salary> Salaries { get; set; } = null!;
        public virtual DbSet<School> Schools { get; set; } = null!;
        public virtual DbSet<SeriesPost> SeriesPosts { get; set; } = null!;
        public virtual DbSet<Team> Teams { get; set; } = null!;
        public virtual DbSet<TeamsFranchise> TeamsFranchises { get; set; } = null!;
        public virtual DbSet<TeamsHalf> TeamsHalves { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=Data\\baseball.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appearance>(entity =>
            {
                entity.HasKey(e => new { e.YearId, e.TeamId, e.PlayerId });
            });

            modelBuilder.Entity<AwardsManager>(entity =>
            {
                entity.HasKey(e => new { e.YearId, e.AwardId, e.LgId, e.PlayerId });
            });

            modelBuilder.Entity<AwardsPlayer>(entity =>
            {
                entity.HasKey(e => new { e.YearId, e.AwardId, e.LgId, e.PlayerId });
            });

            modelBuilder.Entity<AwardsShareManager>(entity =>
            {
                entity.HasKey(e => new { e.AwardId, e.YearId, e.LgId, e.PlayerId });
            });

            modelBuilder.Entity<AwardsSharePlayer>(entity =>
            {
                entity.HasKey(e => new { e.AwardId, e.YearId, e.LgId, e.PlayerId });
            });

            modelBuilder.Entity<Batting>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.YearId, e.Stint });
            });

            modelBuilder.Entity<BattingPost>(entity =>
            {
                entity.HasKey(e => new { e.YearId, e.Round, e.PlayerId });
            });

            modelBuilder.Entity<Fielding>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.YearId, e.Stint, e.Pos });
            });

            modelBuilder.Entity<FieldingOf>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.YearId, e.Stint });
            });

            modelBuilder.Entity<FieldingOfsplit>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.YearId, e.Stint, e.Pos });
            });

            modelBuilder.Entity<FieldingPost>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.YearId, e.Round, e.Pos });
            });

            modelBuilder.Entity<HallOfFame>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.Yearid, e.VotedBy });
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.HasKey(e => new { e.YearId, e.TeamId, e.Inseason });
            });

            modelBuilder.Entity<ManagersHalf>(entity =>
            {
                entity.HasKey(e => new { e.YearId, e.TeamId, e.PlayerId, e.Half });
            });

            modelBuilder.Entity<Pitching>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.YearId, e.Stint });
            });

            modelBuilder.Entity<PitchingPost>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.YearId, e.Round });
            });

            modelBuilder.Entity<Salary>(entity =>
            {
                entity.HasKey(e => new { e.YearId, e.TeamId, e.LgId, e.PlayerId });
            });

            modelBuilder.Entity<SeriesPost>(entity =>
            {
                entity.HasKey(e => new { e.YearId, e.Round });
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasKey(e => new { e.YearId, e.LgId, e.TeamId });
            });

            modelBuilder.Entity<TeamsHalf>(entity =>
            {
                entity.HasKey(e => new { e.YearId, e.TeamId, e.LgId, e.Half });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
