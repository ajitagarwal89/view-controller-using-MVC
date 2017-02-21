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
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {

            return View();
        }
    }
}