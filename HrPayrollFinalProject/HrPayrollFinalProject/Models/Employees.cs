using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Models
{
    public class Employees
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string FathersName { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Influnce { get; set; }
        [Required]
        public string PassportNo { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime PassportExpireDate { get; set; }
        [Required]
        public Education Education { get; set; }
        [Required]
        public FamilyState FamilyState { get; set; }
        [Required]
        public bool Gender { get; set; }

        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<OldWorkPlace> OldWorkPlaces { get; set; }
        public virtual ICollection<WorkPlace> WorkPlaces { get; set; }
        public virtual ICollection<Payroll> Payrolls { get; set; }
        public virtual ICollection<Continuity> Continuities { get; set; }
        public virtual ICollection<Bonus> Bonus { get; set; }
        public virtual ICollection<Vacation> GetVacations { get; set; }
        public virtual ICollection<Penalty> Penalties { get; set; }
    }
}
