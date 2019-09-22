using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Models
{
    public class Continuity
    {
        public int Id { get; set; }
        [Required]
        public bool Permission { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        public string Reason { get; set; }
        [Required]
        public int EmployeesId { get; set; }
        [Required]
        public Employees Employees { get; set; }
        [Required]
        [EnumDataType(typeof(Attendance))]
        public Attendance Attendance { get; set; }
    }
}
