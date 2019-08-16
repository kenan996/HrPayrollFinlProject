using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Models
{
    public class Salary
    {
        public int Id { get; set; }
        [Required]
        public decimal SalaryCost { get; set; }
        [Required]
        public int PositionId { get; set; }
        [Required]
        public Position Position { get; set; }
        [Required]
        public int CompanyId { get; set; }
        [Required]
        public Company Company { get; set; }
    }
}
