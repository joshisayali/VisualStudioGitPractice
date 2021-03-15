using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VisualStudioGitPractice.Models;

namespace VisualStudioGitPractice.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            Employee emp = new Employee();
            emp.Name = "John Doe";
            emp.Location = "MOH";
            return View(emp);
        }
    }
}