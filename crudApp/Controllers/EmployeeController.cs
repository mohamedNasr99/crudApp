using crudApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace crudApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.AllEmployee);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
           if(ModelState.IsValid)
            {
                Repository.AddEmployee(employee);
                return View("Thanks", employee);
            }
           else
                return View();
        }
        public IActionResult Thanks()
        {
            return View();
        }
        public IActionResult Update(string empName)
        {
            Employee employee = Repository.AllEmployee.Where(e => e.Name == empName).FirstOrDefault();
            return View(employee);
        }
        [HttpPost]
        public IActionResult Update(Employee employee,string empName)
        {
            if(ModelState.IsValid)
            {

                Repository.AllEmployee.Where(e => e.Name == empName).FirstOrDefault().Age = employee.Age;
                Repository.AllEmployee.Where(e => e.Name == empName).FirstOrDefault().Salary = employee.Salary;
                Repository.AllEmployee.Where(e => e.Name == empName).FirstOrDefault().Department = employee.Department;
                Repository.AllEmployee.Where(e => e.Name == empName).FirstOrDefault().Type = employee.Type;
                Repository.AllEmployee.Where(e => e.Name == empName).FirstOrDefault().Name = employee.Name;
                return RedirectToAction("Index");
            }
            else
                return View();
        }
        public IActionResult Delete(string empName) 
        {
            Employee employee = Repository.AllEmployee.Where(e =>e.Name == empName).FirstOrDefault();
            Repository.Delete(employee);
            return RedirectToAction("Index");
        }
    }
}
