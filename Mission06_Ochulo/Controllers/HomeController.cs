using Microsoft.AspNetCore.Mvc;
using Mission06_Ochulo.Models;
using System.Diagnostics;

namespace Mission06_Ochulo.Controllers
{
    public class HomeController : Controller
    {
       //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private MovieEntryContext _movieEntryContext;
        public HomeController(MovieEntryContext temp) //Constructor
            {
                _movieEntryContext = temp;
            }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutJoel()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EnterMovie()
        {
            ViewBag.Categories = _movieEntryContext.Categories
                .OrderBy(x =>  x.CategoryName)
                .ToList();
            return View();
        }
        [HttpPost]
        public IActionResult EnterMovie(MovieEntry response)
        {
            _movieEntryContext.Movies.Add(response); //adding to our context file/ liaison to the db
            _movieEntryContext.SaveChanges();   
            return View("Confirmation", response);
        }

        public IActionResult MovieCollection()
        {
            //linq
            var movies = _movieEntryContext.Movies
                .OrderBy(x => x.Title).ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id) //variable passed here should match optional path in program.cs
        {
            var recordToEdit = _movieEntryContext.Movies
                .Single(x => x.MovieId == id); //variable passed here should match optional path in program.cs
            
            ViewBag.Categories = _movieEntryContext.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("EnterMovie", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(MovieEntry updatedInfo) 
        {
            _movieEntryContext.Update(updatedInfo);
            _movieEntryContext.SaveChanges();

            return RedirectToAction("MovieCollection");
        }

        [HttpGet]
        public IActionResult Delete (int id)
        {
            var recordToDelete = _movieEntryContext.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]  
        public IActionResult Delete(MovieEntry movieToDelete)
        {
            _movieEntryContext.Movies.Remove(movieToDelete);
            _movieEntryContext.SaveChanges();

            return RedirectToAction("MovieCollection");
        }
    }
}
