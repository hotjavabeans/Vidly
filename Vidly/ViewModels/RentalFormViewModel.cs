using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RentalFormViewModel
    {
        [Display(Name = "Rental ID")]
        public int? Id { get; set; }

        [Display(Name = "Customer ID")]
        [Required]
        public int? CustomerId { get; set; } // navigation property

        [Display(Name = "Movie ID")]
        [Required]
        public int MovieId { get; set; } // navigation property

        [Display(Name = "Movie Rented")]
        public string MovieTitle { get; set; }

        [Display(Name = "Date Rented")]
        [Required]
        public DateTime DateRented { get; set; }

        [Display(Name = "Date Returned")]
        public DateTime? DateReturned { get; set; }

        [Display(Name = "Expected Date of Return")]
        public DateTime? ExpectedReturnDate { get; set; }

        public string Title => (Id != 0) ? "Edit Rental" : "New Rental";

        public RentalFormViewModel()
        {
            Id = 0;
        }

        public RentalFormViewModel(Rental rental)
        {
            Id = rental.Id;
            DateRented = rental.DateRented;
            ExpectedReturnDate = rental.DateRented.AddDays(7);
        }
    }
}