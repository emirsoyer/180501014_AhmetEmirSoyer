using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class ApplicationContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "server=DESKTOP-VJ9C9DG\\SQLEXPRESS;database=Zahnklinik;integrated security=True;");
        }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientFile> PatientFiles { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<User> Users { get; set; }

    }
}