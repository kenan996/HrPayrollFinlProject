using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HrPayrollFinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HrPayrollFinalProject.Controllers
{
    [Authorize]
    public class AppUserController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        public AppUserController(UserManager<AppUser> _userManager)
        {
            userManager = _userManager;
        }
        public IActionResult Index()
        {
            return View(userManager.Users);
        }
    }
}