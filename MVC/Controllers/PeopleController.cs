using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }
        CapgeminiEntities db = new CapgeminiEntities();
        List<People> person;
        public PartialViewResult GetAllPeople()
        {
            person = db.People1.ToList();
            return PartialView("_AllPeople", person);
        }
        public PartialViewResult GetMalePeople()
        {
            person = db.People1.Where(x => x.gender == "Male").ToList();
            return PartialView("_AllPeople", person);
        }
        public PartialViewResult GetFemalePeople()
        {
            person = db.People1.Where(x => x.gender == "Female").ToList();
            return PartialView("_AllPeople", person);
        }
    }
}