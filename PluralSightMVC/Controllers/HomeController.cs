using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PluralSightMVC.Models;
using WebGrease.Css.Extensions;

namespace PluralSightMVC.Controllers
{
    public class HomeController : Controller
    {

         DataStoreDb db = new DataStoreDb();

        public ActionResult Index()
        {
            var model = db.Restaurants.OrderByDescending(r => r.Reviews.Average(rev => rev.Rating))
                .Take(10)
                .Select( r => new RestaurantListViewModel
                {
                    Id = r.Id,
                    Name = r.Name,
                    City = r.City,
                    Country = r.Country,
                    CountOfReviews = r.Reviews.Count
                });


           /*var model = from r in db.Restaurants
                       orderby r.Reviews.Average(review => review.Rating) descending
                       select new RestaurantListViewModel
                       {
                           Id = r.Id,
                           Name = r.Name,
                           City =  r.City,
                           Country = r.Country,
                           CountOfReviews = r.Reviews.Count
                       };
            */
             
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