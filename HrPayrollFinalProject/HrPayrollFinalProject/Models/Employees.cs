using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FathersName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Adress { get; set; }
        public string Influnce { get; set; }
        public int PassportNo { get; set; }
        public DateTime PassportExpireDate { get; set; }
        public Education Education { get; set; }
        public FamilyState FamilyState { get; set; }
        public Gender Gender { get; set; }
    }
}
