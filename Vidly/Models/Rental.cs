using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Rental // Association class
    {
        public int Id { get; set; }

        [Required]
        public Customer Customer { get; set; } // navigation property

        [Required]
        public Movie Movie { get; set; } // navigation property

        public DateTime DateRented { get; set; }

        public DateTime? DateReturned { get; set; }
    }
}