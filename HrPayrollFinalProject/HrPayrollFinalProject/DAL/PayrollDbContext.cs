using HrPayrollFinalProject.Models;
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

    }
}
