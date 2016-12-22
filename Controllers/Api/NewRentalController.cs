using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;
using System.Data.Entity;
using Vidly.Dtos;

namespace Vidly.Controllers.Api
{
    public class NewRentalController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            // Check to see if the user has selected any movies
            if (newRental.MovieIds.Count == 0)
                return BadRequest("No Movie Ids have been given");

            // Obtain customer ID from the database
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);
            
            // Check to see if customer ID is valid
            if (customer == null)
                return BadRequest("Customer ID is not valid");

            // Using the ID/s entered as parameters from newRental put all movies from the DB with matching ID's into a list
            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();

            // Check to see if the Movies selected are valid
            if (movies.Count != newRental.MovieIds.Count)
                return BadRequest("One or more MovieIds are invalid");

            foreach (var movie in movies)
            {
                // Check to see if the movies ordered are available
                if(movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");

                movie.NumberAvailable--;

                // Create new rental object for each movie
                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                // Add new object to database
                _context.Rentals.Add(rental);
            }
            // Save Changes
            _context.SaveChanges();

            return Ok();
        }
    }
}
