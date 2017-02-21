using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        public ActionResult Education()
        {
            EducationModel objEdu = new EducationModel();
            {
                objEdu.HigherEducation = "MCA";
                objEdu.PassingYear = "2014";
            }
            return View(objEdu);
        }
    }
}