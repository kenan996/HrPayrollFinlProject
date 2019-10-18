using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Models
{
    public class EmployeeAccuredSalary
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int AccuredSalary { get; set; }

    }
}
