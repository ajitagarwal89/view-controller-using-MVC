using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class CompanyModel
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Url { get; set; }

    }
    public class Employee
    {
        float balance { get; set; }
        int age { get; set; }
        string eyeColor { get; set; }
        string name { get; set; }
        string gender { get; set; }
        string company { get; set; }
        string email { get; set; }
        string phone { get; set; }
    }
}