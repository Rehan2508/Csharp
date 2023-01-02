using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeCoreApplication.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections;

namespace EmployeeCoreApplication.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeeContext _context;

        public EmployeesController(EmployeeContext context)
        {
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
            if (id == null || _context.Employees == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,salary")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Employees == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,salary")] Employee employee)
        {
            if (id != employee.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Employees == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Employees == null)
            {
                return Problem("Entity set 'EmployeeContext.Employees'  is null.");
            }
            var employee = await _context.Employees.FindAsync(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        /*
        public async Task<IActionResult> IncreaseSalary(int?)
        {

        }*/

        public async Task<IActionResult> GetChangedData()
        {
            //Employee employee = new Employee();
            var list = _context.Employees.Select(e => new { name = e.name, salary = e.salary + 10000 });

            List<Employee> elist = new List<Employee>();
            foreach (var item in list)
            {
                Employee e = new Employee();
                e.name = item.name;
                e.salary = item.salary;
                elist.Add(e);
            }
            return View(elist);
        }

        public async Task<IActionResult> GetMaxSalary()
        {
            Employee employee = new Employee();
            employee.salary = _context.Employees.Select(e => e.salary).Max();
            return View(employee);
        }

        public async Task<IActionResult> GetEmployeesBasedOnSalary()
        {
            List<List<Employee>> employees = new List<List<Employee>>();
            List<Employee> SalAbove60K = _context.Employees.Where(e => e.salary > 60000).ToList();
            List<Employee> SalBelow60K = _context.Employees.Where(e => e.salary < 60000).ToList();
            employees.Add(SalBelow60K);
            employees.Add(SalAbove60K);
            List<Employee> empList = employees.SelectMany(e => e).ToList();

            /*
            ArrayList ary = new ArrayList();
            ary.Add("test");
            ary.Add(222);
            ary.Add("Welcom");
            List<string> aryList = ary.OfType<string>().ToList();*/

            return View(empList);
        }

        private bool EmployeeExists(int id)
        {
          return _context.Employees.Any(e => e.id == id);
        }
    }
}
