using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: /Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shreak!" };
            //return View(movie);
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            return RedirectToAction("index", "Home", new{page=1, SortBy = "name" });
        }
	}
}