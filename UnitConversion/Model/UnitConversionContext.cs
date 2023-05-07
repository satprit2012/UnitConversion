using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace UnitConversion.Model;

public partial class UnitConversionContext : DbContext
{
    public UnitConversionContext()
    {
    }

    public UnitConversionContext(DbContextOptions<UnitConversionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ConversionDetail> ConversionDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-EJO0DN4\\MSSQLSERVER1;Database=UnitConversion;Trusted_Connection=True;Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ConversionDetail>(entity =>
        {
            entity.HasKey(e => e.UnitId);

            entity.Property(e => e.UnitFormula).HasMaxLength(50);
            entity.Property(e => e.UnitName)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.UnitSign)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UnitType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
