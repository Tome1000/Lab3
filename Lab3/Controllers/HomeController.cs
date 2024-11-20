using Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new User());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    

        [HttpPost]
        public IActionResult Index(User model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.RegistrationSuccess = true;
                return View("Success", model);
            }

            ViewBag.RegistrationSuccess = false;
            return View(model);
        }
    }
}
