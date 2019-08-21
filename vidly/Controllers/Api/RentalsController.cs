using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using vidly.Models;
using AutoMapper;
using vidly.Dtos;

namespace vidly.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/rentals
        public IHttpActionResult GetRentals()
        {
            return Ok(_context.Rentals
                .Include(r => r.Customer)
                .Include(r => r.Movie)
                .ToList()
                .Select(Mapper.Map<Rental, RentalDto>));
        }

        // GET /api/rental/id
        public IHttpActionResult GetRental(int id)
        {
            var rental = _context.Rentals.SingleOrDefault(r => r.Id == id);

            if (rental == null)
            {
                //throw new HttpResponseException(HttpStatusCode.NotFound);
                return NotFound();
            }

            return Ok(Mapper.Map<Rental, RentalDto>(rental));
        }

        // POST /api/rentals
        [HttpPost]
        public IHttpActionResult CreateRental(NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(
                c => c.Id == newRental.CustomerId);

            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id));

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");

                movie.NumberAvailable--;

                var rental = new Rental()
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();
            
            return Ok();
        }

    }
}
