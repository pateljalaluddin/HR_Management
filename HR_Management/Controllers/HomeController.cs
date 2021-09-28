using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR_Management.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //var listofData = _context.TblEmployee.ToList();
            //var listofData = TblEmployee.ToList();
            //return View(listofData);
            return View();
        }
    }
}