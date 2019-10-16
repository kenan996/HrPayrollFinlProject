using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HrPayrollFinalProject.Core;
using HrPayrollFinalProject.DAL;
using HrPayrollFinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace HrPayrollFinalProject.Controllers
{
    [Authorize(Roles ="Admin,Department")]
    public class BonusController : Controller
    {
        private readonly PayrollDbContext context;

        public BonusController(PayrollDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Bonus(int? id)
        {
            if (id.HasValue)
            {
                if (await context.Employees.AnyAsync(x => x.Id == id))
                {
                    HttpContext.Session.Set<int>("id", (int)id);
                    return View();
                }
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<ActionResult> Bonus(Bonus bonus)
        {
            if (ModelState.IsValid)
            {
                int id = HttpContext.Session.Get<int>("id");

                if (id != 0)
                {
                    bonus.EmlpoyeesId = id;
                    await context.Bonus.AddAsync(bonus);
                    await context.SaveChangesAsync();
                }

            }
            return View();
        }
    }
}