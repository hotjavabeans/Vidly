using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();  
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        [Route("customers")]
        public ViewResult Index()
        {
            //var customers = GetCustomers();
            //var customers = _context.Customers; //deferred execution
            //var customers = _context.Customers.ToList(); //immediate execution
            var customers = _context.Customers.Include(c => c.MembershipType).ToList(); //eager loading

            return View(customers);
        }

        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            //var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id); //immediate execution

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
        //private IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //    {
        //        new Customer { Id = 1, Name = "James Ware" },
        //        new Customer { Id = 2, Name = "Beth Moignard" },
        //        new Customer { Id = 3, Name = "Nyx" }
        //    };
        //}
    }
}