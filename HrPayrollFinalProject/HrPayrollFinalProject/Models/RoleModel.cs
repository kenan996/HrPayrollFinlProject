using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Models
{
    public class RoleModelDetails
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<AppUser> Members { get; set; }
        public IEnumerable<AppUser> NonMembers { get; set; }
    }

    public class RoleModelEdit
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string[] IdToAdd { get; set; }
        public string[] IdToDelete { get; set; }
    }
}
