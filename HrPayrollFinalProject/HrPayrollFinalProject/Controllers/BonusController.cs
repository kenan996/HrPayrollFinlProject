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

        public async Task<IActionResult> Index()
        {

            List<Bonus> bonus =await context.Bonus.Include(x => x.Employees).ToListAsync();
            return View(bonus);
        }

        [HttpGet]
        public async Task<ActionResult> AddBonus(int? id)
        {
            if (id!=null)
            {
                var currentEmployee = await context.Employees.Where(x => x.Id == id).FirstOrDefaultAsync();
                Bonus bonus = new Bonus();
                if (id != null) { bonus.EmployeesId = Convert.ToInt32(id); }
                return View(bonus);
            }
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddBonus([Bind("Id,Amount,Date,EmployeesId")] Bonus bonus)
        {
                Bonus newBonus = new Bonus
                {
                    Amount = bonus.Amount,
                    Date = bonus.Date,
                    EmployeesId = bonus.EmployeesId,
                    EmlpoyeesId=bonus.EmlpoyeesId
                };

                    await context.Bonus.AddAsync(newBonus);
                    await context.SaveChangesAsync();

            //return View(nameof(Index),model);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> DeleteBonus(int? id)
        {
            if (id != null)
            {
                var currentBonus = await context.Bonus.Where(x => x.Id == id).FirstOrDefaultAsync();
                context.Bonus.Remove(currentBonus);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}