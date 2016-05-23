using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PluralSightMVC.Models;

namespace PluralSightMVC.Controllers
{
    public class ReviewsController : Controller
    {
        // GET: Reviews
        public ActionResult Index()
        {
            var model = reviews.OrderBy(r => r.Country);

            return View(model);
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reviews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reviews/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reviews/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reviews/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reviews/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // test data
        static List<ResturantReview> reviews = new List<ResturantReview>
        {
            new ResturantReview()
            {
                Id = 1,
                Name = "test1",
                City = "city1",
                Country = "country1",
                Rating = 1
            },
            new ResturantReview()
            {
                Id = 2,
                Name = "test2",
                City = "city2",
                Country = "country2",
                Rating = 2
            },
            new ResturantReview()
            {
                Id = 3,
                Name = "test3",
                City = "city3",
                Country =  "country3",
                Rating = 3
            },
            new ResturantReview()
            {
                Id = 4,
                Name = "test4",
                City = "city4",
                Country =  "country4",
                Rating = 4
            },
            new ResturantReview()
            {
                Id = 5,
                Name = "test5",
                City = "city5",
                Country = "country5",
                Rating = 5
            },
        };
    }
}
