using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Models
{
    public class HoldingDepartment
    {
        public int Id { get; set; }
        [Required]
        public int HoldingId { get; set; }
        [Required]
        public Holding Holding { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        [Required]
        public Department Department { get; set; }
    }
}
