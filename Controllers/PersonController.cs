using Microsoft.AspNetCore.Mvc;
using ASM_Day7.Interfaces;
using ASM_Day7.Models;
using ASM_Day7.Data;

namespace ASM_Day7.Controllers
{
    public class PersonController : Controller
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonService _service;

        public PersonController(ILogger<PersonController> logger, IPersonService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            return View(PeopleData.People);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(PersonModel person)
        {
            _service.AddPerson(person);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var data = _service.GetPersonDetail(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Update(PersonModel person)
        {
            _service.UpdatePerson(person);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            return View(_service.GetPersonDetail(id));
        }

        public IActionResult Delete(PersonModel person)
        {
            HttpContext.Session.SetString("name", person.FullName);
            return View(person);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var person = _service.GetPersonDetail(id);
            _service.DeletePerson(id);
            return RedirectToAction("Delete", person);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}