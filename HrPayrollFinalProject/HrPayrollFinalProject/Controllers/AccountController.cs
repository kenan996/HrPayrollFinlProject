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
            return RedirectToAction("Login", "Account");
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Register", "Account");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid) return View(loginViewModel);

            AppUser appUser = await userManager.FindByNameAsync(loginViewModel.Username);

            if (appUser == null)
            {
                ModelState.AddModelError("", "Username or password isvalid");
                return View(loginViewModel);
            }
            Microsoft.AspNetCore.Identity.SignInResult signInResult =
                await signInManager.PasswordSignInAsync(appUser, loginViewModel.Password, true, false);

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Username or password isvalid");
            }

            return RedirectToAction("Index", "Home");
        }
    
    }
}