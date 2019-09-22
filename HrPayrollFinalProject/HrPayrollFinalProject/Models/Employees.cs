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
        [MaxLength(20),MinLength(3)]
        public string Name { get; set; }
        [Required]
        [MaxLength(25),MinLength(3)]
        public string Surname { get; set; }
        [Required]
        [MaxLength(15),MinLength(3)]
        [Display(Name ="Fathers Name")]
        public string FathersName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Birth Date")]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Influnce { get; set; }
        [Required]
        [Display(Name ="Passport No")]
        public string PassportNo { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Passport Expire Date")]
        public DateTime PassportExpireDate { get; set; }
        [Required]
        [EnumDataType(typeof(Education))]
        public Education Education { get; set; }
        [Required]
        [Display(Name ="Family State")]
        [EnumDataType(typeof(FamilyState))]
        public FamilyState FamilyState { get; set; }
        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }
        [Required]
        [DataType(DataType.Upload)]
        public string Photo { get; set; }
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
