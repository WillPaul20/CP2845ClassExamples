﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Chapter22_DataGridView.Models.DataLayer
{
    public partial class MMABooksContext : DbContext
    {
        public MMABooksContext()
        {
        }

        public MMABooksContext(DbContextOptions<MMABooksContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<InvoiceLineItems> InvoiceLineItems { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<OrderOptions> OrderOptions { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<States> States { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB; AttachDBFilename=C:\\C#\\Database\\MMABooks.mdf;Integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>(entity =>
            {
                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.State)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ZipCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.State)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customers_States");
            });

            modelBuilder.Entity<InvoiceLineItems>(entity =>
            {
                entity.HasKey(e => new { e.InvoiceId, e.ProductCode });

                entity.Property(e => e.ProductCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_InvoiceLineItems_Invoices");

                entity.HasOne(d => d.ProductCodeNavigation)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.ProductCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceLineItems_Products");
            });

            modelBuilder.Entity<Invoices>(entity =>
            {
                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Invoices_Customers");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.Property(e => e.ProductCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Description).IsUnicode(false);
            });

            modelBuilder.Entity<States>(entity =>
            {
                entity.Property(e => e.StateCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StateName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
