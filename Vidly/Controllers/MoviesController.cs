using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        //Get: Movies/Random
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Sherk!" }; 
            return View(movie);
            
        }

        public IActionResult Edit(int id)
        {
            return Content("id =" + id);
        }
    }
}
