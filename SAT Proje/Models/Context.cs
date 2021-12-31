using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAT_Proje.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-5PH0MPI\\SQLEXPRESS; database=Sat_Proje; integrated security=true;");
            optionsBuilder.EnableSensitiveDataLogging(true);
        }

        public DbSet<Urun> Uruns { get; set; }
        public DbSet<Musterı> Musterı { get; set; }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<Durum> Durums { get; set; }
       
       
    }
}
