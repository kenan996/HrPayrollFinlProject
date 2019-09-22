using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Models
{
    public class Penalty
    {
        public int Id { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        public int EmployeesId { get; set; }
        [Required]
        public Employees Employees { get; set; }
    }
}
