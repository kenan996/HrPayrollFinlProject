using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Models
{
    public class Branch
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool IsHead { get; set; }
        public int EmployeesId { get; set; }
        [Required]
        public Employees Employees { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
    }
}
