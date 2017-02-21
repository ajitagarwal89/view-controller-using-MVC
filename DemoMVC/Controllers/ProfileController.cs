using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Models;


namespace DemoMVC.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            ViewData["Name"] = "Rakesh Sir";
            ViewBag.age = 36;
            TempData["Address"] = "Naresh IT Ameerpet"; 
            return View();
        }
        public ActionResult read()
        {
            return RedirectToAction("Index");
        }
        public ActionResult Company()
        {
            CompanyModel obj = new CompanyModel();
            obj.ID = "E1010";
            obj.Name = "Pragati infotech";
            obj.Url = "kolkata.tech.com";
            return View(obj);
            }
        public ActionResult MDList()
        {
            List<CompanyModel> MDList = new List<CompanyModel> ()
            { new Models.CompanyModel { }
            };
            return View(MDList);

        }
        public ActionResult  List()

        {
            ViewBag.coutries=new List<string >()
            { "INDIA","USA","UK","NEPAL"};
            ViewBag.State = new List<string>()
            {
                "Kolkata","California","London","Khatamandu"
            };
            return View();
        }


    }
}