using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirstAppPK.Models;

public partial class CarDbContext : DbContext
{
    public CarDbContext()
    {
    }

    public CarDbContext(DbContextOptions<CarDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CarTable> CarTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=CarDB;Integrated Security=True;Encrypt = False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CarTable>(entity =>
        {
            entity.HasKey(e => e.CarId);

            entity.ToTable("Car_Table");

            entity.Property(e => e.CarId).HasColumnName("carID");
            entity.Property(e => e.CarBrand)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carBrand");
            entity.Property(e => e.CarModel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carModel");
            entity.Property(e => e.CarPrice)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("carPrice");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
