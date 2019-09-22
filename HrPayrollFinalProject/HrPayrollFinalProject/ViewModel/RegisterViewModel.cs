using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [MaxLength(20), MinLength(4)]
        public string Name { get; set; }
        [Required]
        [MaxLength(20), MinLength(4)]
        public string Surname { get; set; }
        [Required]
        [EmailAddress,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [MaxLength(30), MinLength(5)]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name ="Confirm Password")]
        [DataType(DataType.Password),Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }

    public class LoginModel
    {
        [Required,EmailAddress,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required,DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
