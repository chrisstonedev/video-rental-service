using System.Web.Mvc;
using VideoRentalService.Models;

namespace VideoRentalService.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var movie = new Movie
            {
                Name = "Shrek"
            };
            return View(movie);
        }
    }
}