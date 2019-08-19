using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Models
{
    public class Position
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }       
        public int DepartmentId { get; set; }
        [Required]
        public Department Department { get; set; }
        public int BranchId { get; set; }
        [Required]
        public Branch Branch { get; set; }
        public int HoldingId { get; set; }
        [Required]
        public Holding Holding { get; set; }
        public int CompanyId { get; set; }
        [Required]
        public Company Company { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }

    }
}
