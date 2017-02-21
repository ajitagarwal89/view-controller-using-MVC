using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoMVC.Models;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class RegistrationModel
    {
        public AddressModel a { get; set; }
        public OtherInfoModel o;
        public EducationModel e;
        public List<PersonalInfoModel> p { set; get; }
    }
}