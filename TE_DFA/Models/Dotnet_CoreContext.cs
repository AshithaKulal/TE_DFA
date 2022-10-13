using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TE_DFA.Models
{
    public partial class Dotnet_CoreContext : DbContext
    {
        public Dotnet_CoreContext()
        {
        }

        public Dotnet_CoreContext(DbContextOptions<Dotnet_CoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; } = null!;

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=ELW5101\\SQLEXPRESS;Database=Dotnet_Core; Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__Employee__C190170B15E566A4");

                entity.ToTable("Employee");

                entity.Property(e => e.Eid).HasColumnName("EID");

                entity.Property(e => e.Eage).HasColumnName("EAge");

                entity.Property(e => e.Edes)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("EName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
