using HrPayrollFinalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Infrastucture
{
    [HtmlTargetElement("td",Attributes ="identity-role")]
    public class RoleUsersTagHelper:TagHelper
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public RoleUsersTagHelper(UserManager<AppUser> _userManager, RoleManager<IdentityRole> _roleManager)
        {
            userManager = _userManager;
            roleManager = _roleManager;
        }

        [HtmlAttributeName("identity-role")]
        public string Role { get; set; }

        
         
        public override async  Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            List<string> names = new List<string>();
            var role = await roleManager.FindByIdAsync(Role);  
            if (role!=null)
            {
                foreach (var item in userManager.Users)
                {
                    if (item!=null && await userManager.IsInRoleAsync(item, role.Name))
                    {
                        names.Add(item.UserName);
                    }
                }
            }
            output.Content.SetContent(names.Count == 0 ? "No users":string.Join(",", names));
        }
    }
}
