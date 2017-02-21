using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Models;
using System.Dynamic;
using DemoMVC.Controllers;
namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.Message = "Registarion!";
            dynamic mymodel = new ExpandoObject();
            
            return View();
        }

        public ActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public new string Profile()
        {


            return "wel come to Kolkata Tech";
        }
    }
}