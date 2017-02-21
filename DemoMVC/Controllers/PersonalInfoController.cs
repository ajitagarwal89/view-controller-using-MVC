using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Models;
namespace DemoMVC.Controllers
{
    public class PersonalInfoController : Controller
    {
        // GET: PersonalInfo
        public ActionResult PersonalInfo()
        {
            List<PersonalInfoModel> objPersonal = new List<PersonalInfoModel>()
            {
                new Models.PersonalInfoModel { FirstName ="Ajit",LastName="Agarwal",Gender="Male",Marriage="Singal",Age=28,phone="7063666250",Email="ajitagarwal2010@gmail.com"},
                new Models.PersonalInfoModel { FirstName ="Ranjit",LastName="Agarwal",Gender="Male",Marriage="Singal",Age=25,phone="7063666250",Email="ajitagarwal2010@gmail.com"},
                new Models.PersonalInfoModel { FirstName ="Om",LastName="Gupta",Gender="Male",Marriage="Singal",Age=28,phone="9681785771",Email="ranjitgarwal1994@gmail.com"},
              new Models.PersonalInfoModel { FirstName ="pankaj",LastName="Shaw",Gender="Male",Marriage="Singal",Age=28,phone="7063666250",Email="pankaj@gmail.com"}
                // PersonalInfoModel obj = new PersonalInfoModel();
                //{
                //obj.FirstName = "Ajit";
                //obj.LastName = "Agarwal";
                //obj.Gender = "Male";
                //obj.Marriage = "singal";
                //obj.Age = 28;
                //obj.phone = "7063666250";
                //obj.Email = "ajitagarwal20100@gmail.com";
            };
            return View(objPersonal);
        }
    }
}