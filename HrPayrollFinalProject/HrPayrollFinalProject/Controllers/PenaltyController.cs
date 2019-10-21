using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HrPayrollFinalProject.DAL;
using HrPayrollFinalProject.Models;
using HrPayrollFinalProject.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HrPayrollFinalProject.Controllers
{
    [Authorize(Roles ="Admin,Hr")]
    public class PenaltyController : Controller
    {
        private readonly PayrollDbContext context;
        public PenaltyController(PayrollDbContext _context)
        {
            context = _context;
        }
        public async Task<IActionResult> Index()
        {
            List<Penalty> penalty = await context.Penalties.Include(x => x.Employees).ToListAsync();

            return View(penalty);
        }

        [HttpGet]
        public async Task<IActionResult> AddPenalty(int? id)
        {



            //if (id != null)
            //{
            //    var currentEmployee = await context.Employees.Where(x => x.Id == id).FirstOrDefaultAsync();
            //    Bonus penalty = new Bonus();
            //    if (id != null) { penalty.EmployeesId = Convert.ToInt32(id); }
            //    return View(penalty);
            //}
            //return View();


            if (id != null)
            {
                var currentEmployee = await context.Employees.Where(x => x.Id == id).FirstOrDefaultAsync();
                PenaltyViewModel vm = new PenaltyViewModel
                {
                    Name = currentEmployee.Name,
                    Surname = currentEmployee.Surname,
                    EmployeesId = currentEmployee.Id
                };
                return View(vm);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddPenalty([Bind("Amount,Date,EmployeesId,Name,Surname")] PenaltyViewModel model)
        {
            if (ModelState.IsValid)
            {
                Penalty new_penalty = new Penalty()
                {
                    Amount = model.Amount,
                    Date = model.Date,
                    EmployeesId = model.EmployeesId
                };
                await context.Penalties.AddAsync(new_penalty);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> EditPenalty(int? id)
        {
            if (id!=null)
            {
                var current = await context.Penalties.Include(e => e.Employees).Where(x => x.Id == id).FirstOrDefaultAsync();
                if (current!=null)
                {
                    return View(current);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPenalty([Bind("Id,Amount,Date,EmployeesId")] Penalty penalty)
        {
            if (ModelState.IsValid)
            {
                var currentPenalty = await context.Penalties.Where(x => x.Id == penalty.Id).FirstOrDefaultAsync();
                if (currentPenalty != null)
                {
                    currentPenalty.Amount = penalty.Amount;
                    currentPenalty.Date = penalty.Date;

                    await context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> DeletePenalty(int? id)
        {
            if (id!=null)
            {
                var currentPenalty = await context.Penalties.Where(x => x.Id == id).FirstOrDefaultAsync();
                context.Penalties.Remove(currentPenalty);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}