using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HrPayrollFinalProject.ViewModel;
using HrPayrollFinalProject.DAL;
using Microsoft.AspNetCore.Identity;
using HrPayrollFinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using HrPayrollFinalProject.Utilities;
using static HrPayrollFinalProject.Utilities.StaticData;

namespace HrPayrollFinalProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly PayrollDbContext dbContext;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController
            (
            PayrollDbContext _dbContext,
            UserManager<AppUser> _userManager,
            SignInManager<AppUser> _signInManager,
            RoleManager<IdentityRole> _roleManager
            )
        {
            userManager = _userManager;
            dbContext = _dbContext;
            signInManager = _signInManager;
            roleManager = _roleManager;
        }


        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = await userManager.FindByEmailAsync(loginViewModel.Username) ?? await userManager.FindByNameAsync(loginViewModel.Username);
                if (appUser==null)
                {
                    ModelState.AddModelError("", "Username or password invalid");
                    return View();
                }

                Microsoft.AspNetCore.Identity.SignInResult signInResult = await signInManager.PasswordSignInAsync(appUser.UserName,loginViewModel.Password, false, true);
                if (signInResult.Succeeded)
                  {
                        return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Incorrect password. Try again or click to reset password");
                
            }
            return View();
        }
    }
}