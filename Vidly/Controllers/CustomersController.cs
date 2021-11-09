using System;
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
        // GET: Customers
        [Route("customers")]
        public ActionResult Customers()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "James Ware" },
                new Customer { Name = "Beth Moignard" },
                new Customer { Name = "Nyx" }
            };

            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }
    }
}