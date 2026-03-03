using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HealthyPulse.Models;

public partial class HealthyPulseContext : DbContext
{
    public HealthyPulseContext()
    {
    }

    public HealthyPulseContext(DbContextOptions<HealthyPulseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<Equipment> Equipment { get; set; }

    public virtual DbSet<Measurement> Measurements { get; set; }

    public virtual DbSet<MeasurementType> MeasurementTypes { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Doctors__3214EC0714E3A3E3");

            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.Lastname).HasMaxLength(100);
        });

        modelBuilder.Entity<Equipment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Equipmen__3214EC078EF22685");

            entity.Property(e => e.ModelName).HasMaxLength(100);

            entity.HasOne(d => d.MeasurementTypeNavigation).WithMany(p => p.Equipment)
                .HasForeignKey(d => d.MeasurementType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Equipment__Measu__2A4B4B5E");
        });

        modelBuilder.Entity<Measurement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Measurem__3214EC07BCBC0451");

            entity.HasOne(d => d.Doctor).WithMany(p => p.Measurements)
                .HasForeignKey(d => d.DoctorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Measureme__Docto__2E1BDC42");

            entity.HasOne(d => d.Equipment).WithMany(p => p.Measurements)
                .HasForeignKey(d => d.EquipmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Measureme__Equip__2F10007B");

            entity.HasOne(d => d.MeasurementType).WithMany(p => p.Measurements)
                .HasForeignKey(d => d.MeasurementTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Measureme__Measu__300424B4");

            entity.HasOne(d => d.Patient).WithMany(p => p.Measurements)
                .HasForeignKey(d => d.PatientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Measureme__Measu__2D27B809");
        });

        modelBuilder.Entity<MeasurementType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Measurem__3214EC07B74E4742");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Unit).HasMaxLength(50);
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Patients__3214EC07EEA18946");

            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.Lastname).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
