using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly101.Models;

namespace Vidly101.Controllers
{
    public class MoviesController : Controller
    {
       
        public ActionResult Index()
        {
            var movie = GetMovies();
                        
            return View(movie);
            
        }

       

        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound(); 

            return View(movie);

        }
        
        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id=1, Name ="Shrek" },
                new Movie {Id=2, Name ="Wall-e" }
            };
        }

    }
}