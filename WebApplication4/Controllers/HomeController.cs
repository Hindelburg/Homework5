using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.DAL;
using WebApplication4.Models;

namespace WebApplication4.Models
{
    public class HomeController : Controller
    {
        private AddressContext db = new AddressContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add([Bind(Include = "customerNum,dob,currentDate,fullName,city,st,zip,street")] Address address)
        {
            if (ModelState.IsValid)
            {
                db.Addresses.Add(address);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(address);
        }

        public ActionResult List()
        {
            return View(db.Addresses.ToList());
        }
    }
}
