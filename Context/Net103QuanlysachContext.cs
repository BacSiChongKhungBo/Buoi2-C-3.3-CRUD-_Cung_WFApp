using System;
using System.Collections.Generic;
using Buoi2_C_3._3__CRUD__Cung_WFApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Buoi2_C_3._3__CRUD__Cung_WFApp.Context;

public partial class Net103QuanlysachContext : DbContext
{
    public Net103QuanlysachContext()
    {
    }

    public Net103QuanlysachContext(DbContextOptions<Net103QuanlysachContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Sach> Saches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-GAT3RNS\\SQLEXPRESS;Database=NET103_QUANLYSACH;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SACH__3214EC2719FCF314");

            entity.ToTable("SACH");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Giatien).HasColumnName("GIATIEN");
            entity.Property(e => e.Nxb)
                .HasMaxLength(50)
                .HasColumnName("NXB");
            entity.Property(e => e.Tacgia)
                .HasMaxLength(50)
                .HasColumnName("TACGIA");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
