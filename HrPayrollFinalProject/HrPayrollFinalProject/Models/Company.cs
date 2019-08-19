using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int HoldingId { get; set; }
        [Required]
        public Holding Holding { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
    }
}
