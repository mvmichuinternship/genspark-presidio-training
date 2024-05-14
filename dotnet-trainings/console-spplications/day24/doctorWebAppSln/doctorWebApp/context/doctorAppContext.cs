using doctorWebApp.models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace doctorWebApp.context
{
    public class doctorAppContext : DbContext
    {
        public doctorAppContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Doctor> Doctors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor() { Id = 101, Name = "mv",Specialization="Cardio", Experience=2, Salary=1000},
                new Doctor() {Id = 102, Name = "vk", Specialization = "Neuro", Experience = 2, Salary = 1500 },
                new Doctor() {Id = 103, Name = "mk", Specialization = "Gastro", Experience = 2, Salary = 1500 }
                );
        }
    }
}
