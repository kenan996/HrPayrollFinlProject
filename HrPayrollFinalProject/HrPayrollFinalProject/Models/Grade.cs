using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Models
{
    public class Grade
    {
        public int Id { get; set; }
        [Required]
        public int BranchId { get; set; }
        [Required]
        public Branch Branch { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }
        [Required]
        [Display(Name ="From Amount")]
        public decimal FromAmount { get; set; }
        [Required]
        [Display(Name ="To Amount")]
        public decimal ToAmount { get; set; }
        [Required]
        public int Bonus { get; set; }
    }
}
