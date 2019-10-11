using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HrPayrollFinalProject.DAL;
using HrPayrollFinalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace HrPayrollFinalProject.SeedHost
{
    public class Seed
    {
        internal static async Task InvokeAsync(IServiceScope scope, PayrollDbContext dbContext)
        {
            if(!dbContext.Users.Any())
            {
                var usermanager = scope.ServiceProvider.GetService<UserManager<AppUser>>();
                var roleManager = scope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
                var hashpassword = scope.ServiceProvider.GetRequiredService<IPasswordHasher<AppUser>>();

                AppUser appUser = new AppUser
                {
                    Name = "Kenan",
                    Surname = "Behbudov",
                    Email = "kenan996@gmail.com",
                    UserName = "kenan996"
                };
               appUser.PasswordHash =  hashpassword.HashPassword(appUser, "Kenan111");

                IdentityResult result =  await usermanager.CreateAsync(appUser);
                
                if(result.Succeeded)
                {
                    string[] vs = { "Admin", "Hr", "Payroll", "Department"};

                    foreach(string elm in vs)
                    {
                       await roleManager.CreateAsync(new IdentityRole { Name = elm });
                    }
                     await usermanager.AddToRoleAsync(appUser, "Admin");
                }
            }
        }
    }
}