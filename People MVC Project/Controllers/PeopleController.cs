using People_MVC_Project.Models;
using People_MVC_Project.Models.Repos;
using People_MVC_Project.Models.Services;
using People_MVC_Project.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace People_MVC_Project.Controllers
{
    public class PeopleController : Controller
    {
        IPeopleService _peopleService;

        public PeopleController()
        {
            _peopleService = new PeopleService(new InMemoryRepo());
        }
        public IActionResult Human()
        {
            return View(_peopleService.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreatePeopleViewModel());
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(CreatePeopleViewModel createPeople)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _peopleService.Create(createPeople);
                }
                catch (ArgumentException ex)
                {
                    // Add our own message
                    ModelState.AddModelError("People & City", ex.Message);
                    return View(createPeople);
                }
                return RedirectToAction(nameof(Human));
            }
            return View(createPeople);
        }
        public IActionResult Details(int id)
        {
            People people = _peopleService.FindById(id);
            if (people == null)
            {
                return RedirectToAction(nameof(Human));
            }
            return View(people);
        }
    }
}
