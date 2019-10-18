using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HrPayrollFinalProject.DAL;
using HrPayrollFinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Hosting;
using static HrPayrollFinalProject.Extensions.IFormExtensions;
using static HrPayrollFinalProject.Utilities.RemoveFile;
using HrPayrollFinalProject.ViewModel;


namespace HrPayrollFinalProject.Controllers
{
    [Authorize(Roles = "Admin,Hr")]
    public class EmployeesController : Controller
    {
        private readonly PayrollDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public EmployeesController(PayrollDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Employees
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var employees = await _context.Employees.FirstOrDefaultAsync(m => m.Id == id);

            if (employees == null)
                return NotFound();


            return View(employees);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Surname,FathersName,BirthDate,Email,Number,Adress,Influnce,PassportNo,PassportExpireDate,Education,FamilyState,Gender,Photo,")] Employees employees)
        {
            var data = await _context.Employees.ToListAsync();
            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }

            if (!employees.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "File type should be image");
                return View(data);
            }

            string fileName = await employees.Photo.Save(_hostingEnvironment.WebRootPath, "EmployeeImg");

            employees.ImageUrl = fileName;
            await _context.Employees.AddAsync(employees);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employees = await _context.Employees.FindAsync(id);
            if (employees == null)
            {
                return NotFound();
            }
            return View(employees);
        }


        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Surname,FathersName,BirthDate,Email,Number,Adress,Influnce,PassportNo,PassportExpireDate,Education,FamilyState,Gender,Photo")] Employees employeeEditViewModel)
        {
            if (!ModelState.IsValid)
                return View(employeeEditViewModel);

            Employees employeeFromDb = await _context.Employees.FindAsync(id);

            if (employeeEditViewModel.Photo != null)
            {
                if (!employeeEditViewModel.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "File type invalid");
                    return View(employeeEditViewModel);
                }

                //Delete image
                RemoveImage(_hostingEnvironment.WebRootPath, employeeFromDb.ImageUrl);
                //Update image
                employeeFromDb.ImageUrl = await employeeEditViewModel.Photo.Save(_hostingEnvironment.WebRootPath, "EmployeeImg");

            }
            employeeFromDb.Surname = employeeEditViewModel.Surname;
            employeeFromDb.Name = employeeEditViewModel.Name;
            employeeFromDb.FathersName = employeeEditViewModel.FathersName;
            employeeFromDb.BirthDate = employeeEditViewModel.BirthDate;
            employeeFromDb.Adress = employeeEditViewModel.Adress;
            employeeFromDb.Influnce = employeeEditViewModel.Influnce;
            employeeFromDb.PassportNo = employeeEditViewModel.PassportNo;
            employeeFromDb.Education = employeeEditViewModel.Education;
            employeeFromDb.FamilyState = employeeEditViewModel.FamilyState;
            employeeFromDb.Gender = employeeEditViewModel.Gender;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    
        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employees = await _context.Employees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employees == null)
            {
                return NotFound();
            }

            return View(employees);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var employees = await _context.Employees.FindAsync(id);

            RemoveImage(_hostingEnvironment.WebRootPath, employees.ImageUrl);
            _context.Employees.Remove(employees);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeesExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }

        public async Task<ActionResult> Calculate()
        {
           var data =  await _context.EmployeeAccureds.ToListAsync();
            return View(data);
        }

        [HttpPost]
        public async Task<ActionResult> Calculate(int []id)
        {
            //Default
            var salary = 300;
            if (id.Length != 0)
            {
                foreach(var elm in id)
                {
                  var data = _context.Employees
                              .Where(x => x.Id == elm)
                                 .Include(x => x.Bonus)
                                   .Include(x => x.GetVacations)
                                      .Include(x => x.Penalties)
                                         .FirstOrDefault();

                    var bonus = data.Bonus.Sum(x => x.Amount);

                    var penalty = data.Penalties.Sum(x => x.Amount);

                    //mezuniyyetde oldugu gun sayi
                    //var vacationStart = data.GetVacations.FirstOrDefault().StartDate;
                    //var vacationEnd = data.GetVacations.FirstOrDefault().EndDate;
                    //var days = vacationEnd.Day - vacationStart.Day;

                    //maas hesabladigin ayin gunu
                    //var day = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

                    var price = salary + bonus - penalty;

                    EmployeeAccuredSalary accuredSalary = new EmployeeAccuredSalary
                    {
                        FirstName = data.Name,
                        SecondName = data.Surname,
                        Email=data.Email,
                        PhoneNumber=data.Number,
                        AccuredSalary = price
                    };
                    _context.EmployeeAccureds.Add(accuredSalary);
                    await _context.SaveChangesAsync();
                }
                await Task.Delay(0);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
