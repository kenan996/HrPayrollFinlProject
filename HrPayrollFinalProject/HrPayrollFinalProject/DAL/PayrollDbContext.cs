using HrPayrollFinalProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.DAL
{
    public class PayrollDbContext : IdentityDbContext<AppUser>
    {
        public PayrollDbContext(DbContextOptions<PayrollDbContext> options) : base(options) { }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Bonus> Bonus { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Continuity> Continuities { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Holding> Holdings { get; set; }
        public DbSet<OldWorkPlace> OldWorkPlaces { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<Penalty> Penalties { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<WorkPlace> WorkPlaces { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Employees>()
                .Property(e => e.FamilyState)
                .HasConversion(
                c => c.ToString(),
                c => (FamilyState)Enum.Parse(typeof(FamilyState), c)
                );
                
            builder.Entity<Employees>()
                .Property(a => a.Education)
                .HasConversion(v => v.ToString(),
                v => (Education)Enum.Parse(typeof(Education), v)
                );

            builder.Entity<Employees>()
                .Property(g => g.Gender)
                .HasConversion(c => c.ToString(),
                c => (Gender)Enum.Parse(typeof(Gender), c)
                );
        }
    }

}
