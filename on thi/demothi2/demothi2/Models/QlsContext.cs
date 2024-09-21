using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace demothi2.Models;

public partial class QlsContext : DbContext
{
    public QlsContext()
    {
    }

    public QlsContext(DbContextOptions<QlsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Nxb> Nxbs { get; set; }

    public virtual DbSet<Sach> Saches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-TNHA9R6\\SQLEXPRESS;Initial Catalog=qls;Integrated Security=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Nxb>(entity =>
        {
            entity.HasKey(e => e.Manxb).HasName("PK__nxb__0A7B7E7E575A33BE");

            entity.ToTable("nxb");

            entity.Property(e => e.Manxb)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("manxb");
            entity.Property(e => e.Tennxb)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("tennxb");
        });

        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.Masach).HasName("PK__sach__C4F27006F80FAC02");

            entity.ToTable("sach");

            entity.Property(e => e.Masach)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("masach");
            entity.Property(e => e.Manxb)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("manxb");
            entity.Property(e => e.Sotrang).HasColumnName("sotrang");
            entity.Property(e => e.Tensach)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("tensach");

            entity.HasOne(d => d.ManxbNavigation).WithMany(p => p.Saches)
                .HasForeignKey(d => d.Manxb)
                .HasConstraintName("fk_s_nxbb");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
