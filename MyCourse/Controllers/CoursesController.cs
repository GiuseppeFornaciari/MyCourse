using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class CoursesController: Controller
    {
        public IActionResult Index()
        {
            return Content("sono index");
        }

        public IActionResult Detail(string id)
        {
            return Content($"Sono detail ed ho ricevuto l'id: {id}");

        }
    }
}