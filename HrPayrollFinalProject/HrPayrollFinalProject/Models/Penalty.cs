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
        public int Amount { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int EmployeesId { get; set; }
        public virtual Employees Employees { get; set; }
    }
}
