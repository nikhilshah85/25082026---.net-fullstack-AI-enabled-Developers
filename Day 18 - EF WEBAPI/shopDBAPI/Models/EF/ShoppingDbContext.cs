using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace shopDBAPI.Models.EF;

public partial class ShoppingDbContext : DbContext
{
    public ShoppingDbContext()
    {
    }

    public ShoppingDbContext(DbContextOptions<ShoppingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=NIKHILPC\\MUMBAISERVER;database=shoppingDB;Trusted_Connection=true;trustservercertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.PId).HasName("pk_pID");

            entity.Property(e => e.PId)
                .ValueGeneratedNever()
                .HasColumnName("pID");
            entity.Property(e => e.PCategory)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("pCategory");
            entity.Property(e => e.PIsInStock).HasColumnName("pIsInStock");
            entity.Property(e => e.PName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("pName");
            entity.Property(e => e.PPrice)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("pPrice");
            entity.Property(e => e.PQty).HasColumnName("pQty");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
