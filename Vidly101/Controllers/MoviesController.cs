using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly101.Models;
using System.Data.Entity;
using Vidly101.ViewModels;
using System.Data.Entity.Validation;

namespace Vidly101.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var genre = _context.Genre.ToList();
            var viewModel = new MovieFormViewModel
            {
                Genre = genre
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
                _context.Movies.Add(movie);

            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);

                // Mapper.Map(movie, movieInDb)

                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;

                
            }

            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

                Console.WriteLine(e);
            }
            

            return RedirectToAction("Index", "Movies");


        }
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genre = _context.Genre.ToList()
            };

            return View("MovieForm", viewModel);
        }


        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }




        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound(); 


            return View(movie);

        }


        //public IEnumerable<Movie> GetMovies()
        //{
        //    return new List<Movie>
        //    {
        //        new Movie {Id=1, Name ="Shrek" },
        //        new Movie {Id=2, Name ="Wall-e" }
        //    };
        //}

    }
}