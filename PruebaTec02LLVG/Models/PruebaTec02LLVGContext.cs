using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PruebaTec02LLVG.Models
{
    public partial class PruebaTec02LLVGContext : DbContext
    {
        public PruebaTec02LLVGContext()
        {
        }

        public PruebaTec02LLVGContext(DbContextOptions<PruebaTec02LLVGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Departamento> Departamentos { get; set; } = null!;
        public virtual DbSet<Empleado> Empleados { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-OAO2BUA\\MSSQLSERVER01;Initial Catalog=PruebaTec02LLVG;Integrated Security=True;Encrypt=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.DeptNo)
                    .HasName("PK__departam__DCA63FA6EAD2F816");

                entity.ToTable("departamentos");

                entity.Property(e => e.DeptNo).HasColumnName("dept_no");

                entity.Property(e => e.Dnombre)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dnombre");

                entity.Property(e => e.Loc)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("loc");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.EmpNo)
                    .HasName("PK__empleado__129850FA8AED48D4");

                entity.ToTable("empleados");

                entity.Property(e => e.EmpNo).HasColumnName("emp_no");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("comision");

                entity.Property(e => e.DeptNo).HasColumnName("dept_no");

                entity.Property(e => e.Dir).HasColumnName("dir");

                entity.Property(e => e.FechaAlt)
                    .HasColumnType("date")
                    .HasColumnName("fecha_alt");

                entity.Property(e => e.Imagen)
                    .HasColumnType("image")
                    .HasColumnName("imagen");

                entity.Property(e => e.Oficio)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("oficio");

                entity.Property(e => e.Salario)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("salario");

                entity.HasOne(d => d.DeptNoNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.DeptNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__empleados__dept___47DBAE45");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
