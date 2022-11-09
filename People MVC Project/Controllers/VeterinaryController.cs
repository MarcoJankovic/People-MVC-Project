using Microsoft.AspNetCore.Mvc;

namespace People_MVC_Project.Controllers
{
    public class VeterinaryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
