using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Utilities
{
    public static class StaticData
    {
        public enum Roles
        {
            Admin=1,
            Department=2,
            Hr=3,
            Payroll=4
        }

        public const string AdminRole = "Admin";
        public const string DepartmentRole = "Department";
        public const string HrRole = "Hr";
        public const string PayrollRole = "Payroll";
    }
}
