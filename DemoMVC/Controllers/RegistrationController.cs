using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            
            var ad= new List<AddressModel>();
            var reg = new RegistrationModel(ad);
            ad.Address = "gandu";
            //var x = AddressModel();
            //reg.p.FirstName = "Ajit";
            //reg.p.LastName = "Agarwal";
            //reg.p.Gender = "Male";
            //reg.p.Marriage = "singal";
            //reg.p.Age = 28;
            //reg.p.phone = "7063666250";
            //reg.p.Email = "ajitagarwal20100@gmail.com";
            //reg.GetType. = "72/Akhil Mistry Lane";
            reg.a.Country = "INDIA";
            reg.a.State = "West Bengal";
            reg.a.City = "Kolkata";
            reg.a.ZipCode = "700009";
            //reg.e.HigherEducation = "MCA";
            //reg.e.PassingYear = "2014";
            //reg.o.companyName="Swastik infotech Services";
            //reg.o.DOJ = "2015";
           


            return View(reg);
        }

        // GET: Registration/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Registration/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registration/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Registration/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Registration/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Registration/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Registration/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
