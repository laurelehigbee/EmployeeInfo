using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using EmployeeInfo.Models;
using System.Diagnostics;

namespace EmployeeInfo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() //return get request for the View Movies table
        {
            EmployeesDbContext context = HttpContext.RequestServices.GetService(typeof(EmployeeInfo.Models.EmployeesDbContext)) as EmployeesDbContext;
            StudentJobDbContext context2 = HttpContext.RequestServices.GetService(typeof(EmployeeInfo.Models.StudentJobDbContext)) as StudentJobDbContext;


            return View(context.GetAllEmployees());
        }

        public IActionResult Metrics()
        {
            return View();
        }

        public IActionResult Jobs()
        {
            return View();
        }

        public IActionResult EmployeeDetails()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Export(string GridHtml)
        {
            return File(System.Text.Encoding.ASCII.GetBytes(GridHtml), "application/vnd.ms-excel", "EmployeeInfo.xls");
        }
    }
}
