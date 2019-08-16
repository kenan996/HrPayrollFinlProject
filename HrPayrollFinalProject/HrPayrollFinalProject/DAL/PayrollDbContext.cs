﻿using HrPayrollFinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.DAL
{
    public class PayrollDbContext:DbContext
    {
        public PayrollDbContext(DbContextOptions<PayrollDbContext> options) : base(options) { }
        public DbSet<Employees> employees { get; set; }
        public DbSet<Bonus> Bonus { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyDepartment> CompanyDepartments { get; set; }
        public DbSet<Continuity> Continuities { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Holding> Holdings { get; set; }
        public DbSet<HoldingDepartment> HoldingDepartments { get; set; }
        public DbSet<OldWorkPlace> OldWorkPlaces { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<Penalty> Penalties { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<WorkPlace> WorkPlaces { get; set; }
    }
}
