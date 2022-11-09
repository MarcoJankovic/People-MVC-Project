using Microsoft.AspNetCore.Mvc;
using People_MVC_Project.Models;
using People_MVC_Project.Models.Repos;
using People_MVC_Project.Models.Services;
using System.Diagnostics;

namespace People_MVC_Project.Controllers
{

    public class HomeController : Controller
    {
        private readonly IPeopleService _peopleService;

        public HomeController()
        {
            _peopleService = new PeopleService(new InMemoryRepo());
        }

       public IActionResult Index()
        {
            return View(_peopleService.LastAdded());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}