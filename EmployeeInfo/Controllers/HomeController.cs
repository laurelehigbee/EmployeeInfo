﻿using Microsoft.AspNetCore.Mvc;
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

            return View(context.GetAllEmployees());
        }

    }
}
