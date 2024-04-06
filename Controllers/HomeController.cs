using Microsoft.AspNetCore.Mvc;
using mypersonalwebsite.Models;
using mypersonalwebsite.Repository;

namespace mypersonalwebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactTuseRepository _repository;

        public HomeController(IContactTuseRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ContactMe()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ContactMe(ContactTuse model)
        {
            if (ModelState.IsValid)
            {
                await _repository.CreateRecord(model);
                TempData["notification"] = "Thanks for the message!";
                return RedirectToAction(nameof(Index));

            }
            else
            {
                ModelState.AddModelError(string.Empty, "Data was not saved.");
                return View(model);
            }
        }

        public IActionResult AboutMe()
        {
            return View();
        }

    }
}
