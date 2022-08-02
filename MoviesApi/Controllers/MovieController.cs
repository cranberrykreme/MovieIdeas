using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesApi.Models;

namespace MoviesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        // A list of movie data (dummy data for now), this will be
        // returned in various forms when the api is called.
        List<Movies> moviesList = new List<Movies>
        {
            new Movies {id=1, name="Avengers", rating=9,
            description="A team of heroes work together to save the world",
            releaseDate= new DateTime(2012, 4, 25)},
            new Movies {id=2, name="Avatar", rating=8,
            description="Humans attempt to conquer a distant planet but are resisted by the local population of Navi",
            releaseDate= new DateTime(2009, 12, 17)},
            new Movies {id=3, name="John Wick", rating=10,
            description="After a mans dog is killed by a gang of criminals, he seeks bloody revenge",
            releaseDate= new DateTime(2014, 10, 30)},
        };

        /**
         * Returns the full list of movies
         */
        [HttpGet]
        public ActionResult<IEnumerable<Movies>> GetAll()
        {
            System.Diagnostics.Debug.WriteLine("Basic Get call");
            return moviesList;
        }

        /**
         * Returns the movies that have only the id that is
         * entered in via the api call.
         */
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Movies>> GetById(
            int id
        )
        {
            List<Movies> foundMovie = new List<Movies>();
            IEnumerable<Movies> ret = moviesList.Where(item => item.id == id);
            return Ok(ret);
        }

        /**
         * Returns the movies that have rating greater than
         * or equal to the rating that is entered in via 
         * the api call
         */
        [HttpGet("rate/{rating}")]
        public ActionResult<IEnumerable<Movies>> GetRating(
            int rating)
        {
            List<Movies> foundMovies = new List<Movies>();
            IEnumerable<Movies> ret = moviesList.Where((item) => item.rating >= rating);
            return Ok(ret);
        }

        //HttpGet -> retrieve information
        //HttpPost -> put in a new entry
        //HttpPut -> edit an existing entry
        //HttpDelete -> remove
    }
}