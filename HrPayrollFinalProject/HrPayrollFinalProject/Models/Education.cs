using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Models
{
    public enum Education
    {
        [Display(Name ="Secondary School")]
        SecondarySchool = 1,
        Bachelor = 2,
        Master = 3,
        Other = 4
    }
}
