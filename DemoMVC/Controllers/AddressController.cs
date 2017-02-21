using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class AddressController : Controller
    {
        // GET: Address
        public ActionResult Address()
        {
            AddressModel objAdd = new AddressModel();
            {
                objAdd.Address = "72/Akhil Mistry Lane";
                objAdd.Country = "INDIA";
                objAdd.State = "West Bengal";
                objAdd.City = "Kolkata";
                objAdd.ZipCode = "700009";
            }
            return View();
        }
    }
}