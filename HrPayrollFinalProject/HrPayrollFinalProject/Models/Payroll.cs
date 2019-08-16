using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Models
{
    public class Payroll
    {
        public int Id { get; set; }
        [Required]
        public int EmployeesId { get; set; }
        [Required]
        public Employees Employees { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }
        [Required]
        public int Bonus { get; set; }
        [Required]
        public int Penalty { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public int TotalSalary { get; set; }
    }
}
