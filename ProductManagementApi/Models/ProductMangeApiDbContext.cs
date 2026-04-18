using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProductManagementApi.Models;

public partial class ProductMangeApiDbContext : DbContext
{
    public ProductMangeApiDbContext()
    {
    }

    public ProductMangeApiDbContext(DbContextOptions<ProductMangeApiDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblProduct> TblProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-MGNUF0MQ\\SQLEXPRESS;Database=ProductMangeApiDb;TrustServerCertificate=True;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblProdu__3213E83FC7C49CA8");

            entity.ToTable("TblProduct");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
