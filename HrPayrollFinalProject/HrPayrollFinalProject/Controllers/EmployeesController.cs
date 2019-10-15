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
    [Authorize(Roles = "Admin")]
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
        [AllowAnonymous]
        public async Task<IActionResult> Create([Bind("Id,Name,Surname,FathersName,BirthDate,Adress,Influnce,PassportNo,PassportExpireDate,Education,FamilyState,Gender,Photo,")] Employees employees)
        {
            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }

            if (!employees.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "File type should be image");
                return View();
            }

            string fileName = await employees.Photo.Save(_hostingEnvironment.WebRootPath, "EmployeeImg");

            employees.ImageUrl = fileName;
            await _context.Employees.AddAsync(employees);
            await _context.SaveChangesAsync();


            if (ModelState.IsValid)
            {
                _context.Add(employees);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction("Index");
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Surname,FathersName,BirthDate,Adress,Influnce,PassportNo,PassportExpireDate,Education,FamilyState,Gender,Photo")] Employees employeeEditViewModel)
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







            //if (id != employees.Id)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(employees);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!EmployeesExists(employees.Id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(employees);
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
    }
}