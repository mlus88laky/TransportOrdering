using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TransportOrdering.Data;

namespace TransportOrdering.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<VehicleType> VehicleType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-746ECUV;Database=TransportOrderDB;Trusted_Connection=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id).UseIdentityColumn()
                                           .IsRequired();

                entity.Property(e => e.Date).HasColumnType("datetime")
                                            .IsRequired()
                                            .HasMaxLength(50)
                                            .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime")
                      .IsRequired()
                      .HasMaxLength(50)
                      .IsUnicode(false);

                entity.Property(e => e.VehicleTypeId)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.VehicleCapacity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.StartAddress)
                    .IsRequired()
                    .IsFixedLength();

                entity.Property(e => e.EndAddress)
                    .IsRequired()
                    .IsFixedLength();

                entity.Property(e => e.FullName)
                   .IsRequired()
                   .HasMaxLength(50)
                   .IsFixedLength();

                entity.Property(e => e.Email)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsFixedLength();

                entity.Property(e => e.MobileNumber)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsFixedLength();

                entity.Property(e => e.ReferenceNumber)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsFixedLength();

                entity.HasOne(d => d.VehicleTypes)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_VehicleTypes");
            });

            modelBuilder.Entity<VehicleType>(entity =>
            {
                entity.Property(e => e.Id)
                                          .IsRequired().ValueGeneratedNever();

                entity.Property(e => e.Description)
                 .IsRequired()
                 .HasMaxLength(50)
                 .IsFixedLength();

            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).UseIdentityColumn()
                                          .IsRequired();

                entity.Property(e => e.UserName)
                 .IsRequired()
                 .HasMaxLength(50)
                 .IsFixedLength();

                entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(50)
                .IsFixedLength();

                entity.Property(e => e.IsActive)
                .IsRequired()
                .HasMaxLength(50)
                .IsFixedLength();

            });

        }
    }
}