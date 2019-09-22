using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HrPayrollFinalProject.ViewModel;
using HrPayrollFinalProject.DAL;
using Microsoft.AspNetCore.Identity;
using HrPayrollFinalProject.Models;

namespace HrPayrollFinalProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly PayrollDbContext dbContext;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        public AccountController
            (
            PayrollDbContext _dbContext,
            UserManager<AppUser> _userManager,
            SignInManager<AppUser> _signInManager
            )

        {
            userManager = _userManager;
            dbContext = _dbContext;
            signInManager = _signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (!ModelState.IsValid) return View(registerViewModel);

            AppUser newAppUser = new AppUser
            {
                Name = registerViewModel.Name,
                Surname = registerViewModel.Surname,
                Email = registerViewModel.Email,
                UserName = registerViewModel.Username,
            };

            IdentityResult identityResult = await userManager.CreateAsync(newAppUser, registerViewModel.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}