using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication16.Models;

namespace WebApplication16.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Student()
        {
            Student std = new Student();
            std.ID = 12;
            std.Name = "Ali";
            std.Address = "Karachi";
            std.Contact = 0340;

            return View(std);
        }

        public ActionResult Employee()
        {
            Employee emp = new Employee();
            emp.ID = 12;
            emp.Name = "Noor";
            emp.Address = "Karachi";
            emp.Salary = 30000;

            return View(emp);
        }
    }
}