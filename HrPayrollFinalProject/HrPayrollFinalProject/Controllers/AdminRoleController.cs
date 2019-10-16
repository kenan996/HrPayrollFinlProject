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
    [Authorize(Roles = "Admin")]
    public class AdminRoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<AppUser> userManager;

        public AdminRoleController(RoleManager<IdentityRole> _roleManager, UserManager<AppUser> _userManager)
        {
            roleManager = _roleManager;
            userManager = _userManager;
        }
        public IActionResult Index()
        {
            return View(roleManager.Roles);
        }

        [HttpGet]
            public async Task<IActionResult> Edit(string Id)
        {
            IdentityRole role = await roleManager.FindByIdAsync(Id);
            var members = new List<AppUser>();
            var nonMembers = new List<AppUser>();

            foreach (var item in userManager.Users)
            {
                var list = await userManager.IsInRoleAsync(item, role.Name)
                    ? members : nonMembers;

                list.Add(item);
            }

            var model = new RoleModelDetails()
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(RoleModelEdit roleModelEdit)
        {
            IdentityResult result;

            if (ModelState.IsValid)
            {
                foreach (var userId in roleModelEdit.IdToAdd ?? new string[] { })
                {
                    var user = await userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        result = await userManager.AddToRoleAsync(user, roleModelEdit.RoleName);

                        if (!result.Succeeded)
                        {
                            foreach (var item in result.Errors)
                            {
                                ModelState.AddModelError("", item.Description);
                            }
                        }
                    }

                }

                foreach (var userId in roleModelEdit.IdToDelete ?? new string[] { })
                {
                    var user = await userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        result = await userManager.RemoveFromRoleAsync(user, roleModelEdit.RoleName);

                        if (!result.Succeeded)
                        {
                            foreach (var item in result.Errors)
                            {
                                ModelState.AddModelError("", item.Description);
                            }
                        }
                    }

                }
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }


            return RedirectToAction(nameof(Edit), roleModelEdit.RoleId);
        }




    }

}