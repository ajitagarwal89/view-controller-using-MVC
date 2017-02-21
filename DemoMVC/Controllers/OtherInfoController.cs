using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class OtherInfoController : Controller
    {
        // GET: OtherInfo
        public ActionResult OtherInfo()
        {
            OtherInfoModel objoth = new Models.OtherInfoModel();
            { objoth.companyName = "Swastik Infotech Services";
                objoth.DOJ = "13 - 04 - 2015";
            }
            return View();
        }
    }
}