using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BaseballModel.Entities;

namespace BaseballModel.Context
{
    public partial class TransContext : DbContext
    {
        public TransContext()
        {
        }

        public TransContext(DbContextOptions<TransContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SeasonDate> SeasonDates { get; set; } = null!;
        public virtual DbSet<Stint> Stints { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=Data\\transactions.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SeasonDate>(entity =>
            {
                entity.Property(e => e.YearId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Stint>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.YearId, e.StintId });

                entity.Property(e => e.IgnoreStint).HasDefaultValueSql("FALSE");

                entity.Property(e => e.PrimaryStint).HasDefaultValueSql("FALSE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
