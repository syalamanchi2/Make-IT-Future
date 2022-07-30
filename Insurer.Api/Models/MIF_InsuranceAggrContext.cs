using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Insurer.Api.Models
{
    public partial class MIF_InsuranceAggrContext : DbContext
    {
        public MIF_InsuranceAggrContext()
        {
        }

        public MIF_InsuranceAggrContext(DbContextOptions<MIF_InsuranceAggrContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CasualtynsuranceFeature> CasualtynsuranceFeatures { get; set; } = null!;
        public virtual DbSet<CategoryDetail> CategoryDetails { get; set; } = null!;
        public virtual DbSet<HealthInsuranceFeature> HealthInsuranceFeatures { get; set; } = null!;
        public virtual DbSet<ProviderDetail> ProviderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CasualtynsuranceFeature>(entity =>
            {
                entity.HasKey(e => e.CasualtyId)
                    .HasName("PK_CasualtyDetails");

                entity.Property(e => e.Cover).HasMaxLength(250);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Earthquake).HasMaxLength(250);

                entity.Property(e => e.Fire).HasMaxLength(250);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lightning).HasMaxLength(250);

                entity.Property(e => e.Premium).HasMaxLength(250);

                entity.Property(e => e.Theft).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CategoryDetail>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_Category");

                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<HealthInsuranceFeature>(entity =>
            {
                entity.HasKey(e => e.HealthPlanId)
                    .HasName("PK_HealthDetails");

                entity.Property(e => e.ClaimSettlementRatio).HasMaxLength(250);

                entity.Property(e => e.Cover).HasMaxLength(250);

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExistingIllnessCovered).HasMaxLength(250);

                entity.Property(e => e.FreeHealthCheckup).HasMaxLength(250);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Premium).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProviderDetail>(entity =>
            {
                entity.HasKey(e => e.ProviderId);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProviderName).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
