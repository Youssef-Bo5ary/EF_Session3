using EF_Session3.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Session3.Contexts
{
    internal class CompanyDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TPH ( Table per Hierarchy)
            modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
            modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();

            //TPH => Map Full Time Employee & PartTimeEmployee to one table EMployee
            //Add new column Navbar Named Disclaimer[FullTime | Parttime]

            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = Company ; Trusted_Connection = true ; Encrypt = False");
        }
        public DbSet<PartTimeEmployee> partTimeEmployees { get; set; }
        public DbSet<FullTimeEmployee> fullTimeEmployees { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}
