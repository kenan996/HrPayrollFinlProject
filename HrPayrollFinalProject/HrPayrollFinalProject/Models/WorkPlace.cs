using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Models
{
    public class WorkPlace
    {
        public int Id { get; set; }
        [Required]
        public int BranchId { get; set; }
        [Required]
        public Branch Branch { get; set; }
        [Required]
        public int PositionId { get; set; }
        [Required]
        public Position Position { get; set; }
        [Required]
        public int EmployeesId { get; set; }
        [Required]
        public Employees Employees { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Entry date")]
        public DateTime EntryDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="End Date")]
        public DateTime EndDate { get; set; }
    }
}
