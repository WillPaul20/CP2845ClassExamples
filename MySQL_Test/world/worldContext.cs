using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MySQL_Test.world
{
    public partial class worldContext : DbContext
    {
        public worldContext()
        {
        }

        public worldContext(DbContextOptions<worldContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Countrylanguage> Countrylanguages { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;uid=root;pwd=password;database=world", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.22-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.CountryCode, "CountryCode");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.District)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(35)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PRIMARY");

                entity.ToTable("country");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Code)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Code2)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Continent)
                    .HasColumnType("enum('Asia','Europe','North America','Africa','Oceania','Antarctica','South America')")
                    .HasDefaultValueSql("'Asia'");

                entity.Property(e => e.Gnp)
                    .HasColumnType("float(10,2)")
                    .HasColumnName("GNP");

                entity.Property(e => e.Gnpold)
                    .HasColumnType("float(10,2)")
                    .HasColumnName("GNPOld");

                entity.Property(e => e.GovernmentForm)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.HeadOfState)
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.LifeExpectancy).HasColumnType("float(3,1)");

                entity.Property(e => e.LocalName)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(52)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Region)
                    .HasMaxLength(26)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.SurfaceArea).HasColumnType("float(10,2)");
            });

            modelBuilder.Entity<Countrylanguage>(entity =>
            {
                entity.HasKey(e => new { e.CountryCode, e.Language })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("countrylanguage");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.CountryCode, "CountryCode");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Language)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.IsOfficial)
                    .HasColumnType("enum('T','F')")
                    .HasDefaultValueSql("'F'");

                entity.Property(e => e.Percentage).HasColumnType("float(4,1)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
