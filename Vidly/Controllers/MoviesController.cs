using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "12 Monkeys" };

            var customers = new List<Customer>
            {
                new Customer { Name = "James Ware" },
                new Customer { Name = "Beth Moignard" },
                new Customer { Name = "Nyx" }
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };


            return View(viewModel);

            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model

            //ViewData["RandomMovie"] = movie;
            //ViewBag.Movie = movie; runtime, no compile-time safety

            //return new ViewResult(); less common method of returning a View. Best practice: use View helper method.
            //return Content("Hello World!"); plain string content
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});
        }

        [Route("movies")]
        public ViewResult Index()
        {
            var movies = GetMovies();
               
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "12 Monkeys"},
                new Movie {Id = 2, Name = "The Game"},
                new Movie {Id = 3, Name = "Meet Joe Black"}
            };
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]

        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }


        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}