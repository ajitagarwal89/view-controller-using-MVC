﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class BookModel
    {
        public int ID { get; set; }
         public string Title { get; set; }
        public decimal  Price{ get; set; }
        public string Author { get; set; }
    }
}