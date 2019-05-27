using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserLogin(string uname,string pwd)
        {
            CapgeminiEntities db = new CapgeminiEntities();
            tblUser u = db.tblUsers.SingleOrDefault(x => x.uname ==uname && x.pwd == pwd);
            if (u != null && u.roleid == 1)
                return RedirectToAction("Index", "Admin");
            else if (u != null && u.roleid == 2)
                return RedirectToAction("Index", "Super");
            else if (u != null && u.roleid == 3)
                return RedirectToAction("Index", "Regular");
            else
                ViewBag.msg = "Invalid input credentials";


            return View();
        }
    }
}