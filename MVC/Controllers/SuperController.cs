﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class SuperController : Controller
    {
        // GET: Super
        public ActionResult Index()
        {
            return View();
        }
    }
}