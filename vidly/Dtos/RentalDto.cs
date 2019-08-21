using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using vidly.Models;

namespace vidly.Dtos
{
    public class RentalDto
    {
        public int Id { get; set; }
        public MovieDto Movie { get; set; }
        public int MovieId { get; set; }
        public CustomerDto Customer { get; set; }
        public int CustomerId { get; set; }

        [Required]
        public DateTime DateRented { get; set; }

        public DateTime? DateReturned { get; set; }
    }
}