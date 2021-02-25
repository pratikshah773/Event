﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mydbclass2.DBoperations;
using EmployeeModel;

namespace Application1.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(employee emp)
        {
            if (ModelState.IsValid)
            {

                employee Emailins = new employee();
                string emailval = emp.Email;

                ViewBag.name = emp.FullName;

                employeeRepository emprepoobj = new employeeRepository();
                emprepoobj.Addemployee(emp);

                return View("Welcome");
            }
            else return View();

        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
    }
}