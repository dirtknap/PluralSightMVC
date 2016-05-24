using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PluralSightMVC.Models;

namespace PluralSightMVC.Controllers
{
    public class HomeController : Controller
    {

         DataStoreDb db = new DataStoreDb();

        public ActionResult Index()
        {
            var model = db.Resturants.ToList();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db?.Dispose();

            base.Dispose(disposing);
        }
    }
}