using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class NewRentalDto
    {
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public CustomerDto Customer { get; set; }
        public MovieDto Movie { get; set; }
        public List<int> MovieIds { get; set; }

        public DateTime DateRented { get; set; }
    }
}