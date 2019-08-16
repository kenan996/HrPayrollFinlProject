using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Models
{
    public class OldWorkPlace
    {
        public int Id { get; set; }
        [Required]
        public string WorkPLaceName { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime FireDate { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime HireDate { get; set; }
        [Required]
        public string FireReason { get; set; }
        [Required]
        public int EmployeesId { get; set; }
        [Required]
        public Employees Employees { get; set; }
    }
}
