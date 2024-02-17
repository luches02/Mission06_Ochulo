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
            return View();
        }
        [HttpPost]
        public IActionResult EnterMovie(MovieEntry response)
        {
            _movieEntryContext.MovieEntries.Add(response);
            _movieEntryContext.SaveChanges();   
            return View("Confirmation", response);
        }
    }
}
