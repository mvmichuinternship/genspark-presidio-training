using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ClinicAppDalLibrary.Model
{
    public partial class day20EmployeeTrackerContext : DbContext
    {
        public day20EmployeeTrackerContext()
        {
        }

        public day20EmployeeTrackerContext(DbContextOptions<day20EmployeeTrackerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; } = null!;
        public virtual DbSet<Doctor> Doctors { get; set; } = null!;
        public virtual DbSet<Patient> Patients { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-DPV93JG\\SQLEXPRESS; Integrated Security = true; Initial Catalog = day20EmployeeTracker");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(e => e.Aid)
                    .HasName("pk_Aid");

                entity.ToTable("Appointment");

                entity.Property(e => e.Aid).HasColumnName("AId");

                entity.Property(e => e.Adate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADate");

                entity.Property(e => e.Pid).HasColumnName("PId");

                entity.HasOne(d => d.PidNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.Pid)
                    .HasConstraintName("fk_P_Appt");
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(e => e.Did)
                    .HasName("pk_Did");

                entity.ToTable("Doctor");

                entity.Property(e => e.Did).HasColumnName("DId");

                entity.Property(e => e.Dname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DName");

                entity.Property(e => e.Dsalary).HasColumnName("DSalary");

                entity.Property(e => e.Dspecialization)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DSpecialization");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("pk_Pid");

                entity.ToTable("Patient");

                entity.Property(e => e.Pid).HasColumnName("PId");

                entity.Property(e => e.Pdob)
                    .HasColumnType("date")
                    .HasColumnName("PDob");

                entity.Property(e => e.Pemail)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PEmail");

                entity.Property(e => e.Pgender)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PGender");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PName");

                entity.Property(e => e.Pnumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PNumber");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
