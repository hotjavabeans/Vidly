using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class RentalsController : Controller
    {
        private ApplicationDbContext _context;
        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();    
        }

        // GET: Rentals
        [Route("rentals")]
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageMovies))
                return View("List");

            return View("ReadOnlyList");
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult New()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            var rental = _context.Rentals.SingleOrDefault(r => r.Id == id);
            if (rental == null)
                return HttpNotFound();

            var viewModel = new RentalFormViewModel(rental)
            {

            };

            return View("RentalForm", viewModel);
        }

        public ActionResult Save(Rental rental)
        {
            if (!ModelState.IsValid)
            {
                return View("RentalForm");
            }
            
            if (rental.Id == 0)
            {
                rental.DateRented = DateTime.Now;
                _context.Rentals.Add(rental);   
            }
            else
            {
                var rentalInDb = _context.Rentals.Single(r => r.Id == rental.Id);

                // set other properties
            }
            _context.SaveChanges();

            return RedirectToAction("List", "Rentals");
        }
    }
}