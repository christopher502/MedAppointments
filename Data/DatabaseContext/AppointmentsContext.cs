using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Asn1.X509;
using MedAppointments.Enums;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MedAppointments.Data.Entities;
using Microsoft.Extensions.Logging;

namespace MedAppointments.Data.DatabaseContext
{
    public class AppointmentsContext : DbContext
    {
        public DbSet<Visit> visits { get; set; }
        public DbSet<Status> statuses { get; set; }
        public DbSet<Patient> patients { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Appointment> appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost;Database=appointments;Port=5432;User Id=postgres;Password=password";
            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
                .Property(p => p.gender)
                .HasConversion(new EnumToStringConverter<Gender>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
