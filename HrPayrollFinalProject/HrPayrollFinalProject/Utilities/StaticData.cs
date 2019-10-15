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

        public const string Admin = "Admin";
        public const string Department = "Department";
        public const string Hr = "Hr";
        public const string Payroll = "Payroll";
    }
}
