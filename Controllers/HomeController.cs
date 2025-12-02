using System.Diagnostics;
using FullStackProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FullStackProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeReposiory _employeeRepository;
        public HomeController(IEmployeeReposiory employeeReposiory)
        {
            _employeeRepository = employeeReposiory;
        }

        public ViewResult Index()
        {
            IEnumerable<Employee> emp = _employeeRepository.GetAllEmployee();
            
            //ViewBag.Employee = emp;
            return View(emp);
            //return View(emp);
        }
        //View Data is not mostly use
        //public JsonResult Details()
        //{
        //    Employee emp=  _employeeRepository.GetEmployee(1);
        //    return Json(emp);
        //}
        public ViewResult Details(int Id)
        {
            Employee emp = _employeeRepository.GetEmployeeById(Id);
            return View(emp);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                Employee newEmp = _employeeRepository.Add(emp);
                return RedirectToAction("details", new { id = newEmp.Id });
            }
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
