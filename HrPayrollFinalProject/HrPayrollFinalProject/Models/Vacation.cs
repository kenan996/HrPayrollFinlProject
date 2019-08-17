using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Models
{
    public class Vacation
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name ="Start Date")]
        public DateTime StartDate { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Required]
        public int EmployeesId { get; set; }
        [Required]
        public Employees Employees { get; set; }
    }
}
