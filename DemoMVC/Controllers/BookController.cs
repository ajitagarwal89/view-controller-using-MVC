using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            BookModel bm = new BookModel()
            {
                ID = 101, Title = "MVC.NET", Price = 500, Author = "BlackBook"
            };
            Session["BookIDetila"] = bm;
            return RedirectToAction("DisplaayBook");
            //return View(bm);
        }
        public ViewResult DisplaayBook()
        {
            //BookModel bm = new BookModel()
            //{
            //    ID = 101,
            //    Title = "MVC.NET",
            //    Price = 500,
            //    Author = "BlackBook"
            //};
            //Session["BookIDetilal"] = bm;

            return View();
        }
        public ActionResult BookList()
        {
            List<BookModel> objlist = new List<BookModel>()
            {
           new BookModel { ID=101,Title="C#",Price=500,Author="unleased"},
           new BookModel { ID=102,Title="C",Price=180,Author="Yashavant-Kanetkar"},
           new BookModel { ID=103,Title="C++",Price=320,Author="balaguruswamy "},
            new BookModel { ID=104,Title="SQL SERVER",Price=300,Author="YSandipPani"}
            };
            Session["Books"] = objlist;
            return RedirectToAction("Bookinfo");
                
                }
        public  ViewResult Bookinfo() 
            {
            return View();
            }

    }
}