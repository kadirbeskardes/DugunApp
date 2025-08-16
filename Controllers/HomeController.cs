using System.Diagnostics;
using DugunApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DugunApp.Controllers
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
            return View();
        }

        public IActionResult HowItWorks()
        {
            return View();
        }

        public IActionResult Pricing()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Order()
        {
            return View(new OrderViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Order(OrderViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // TODO: Ödeme/işlem akışı burada ele alınabilir
            return RedirectToAction(nameof(OrderSuccess));
        }

        [HttpGet]
        public IActionResult OrderSuccess()
        {
            return View();
        }

        [HttpGet]
        [Route("w/{slug}")]
        public IActionResult Upload(string slug)
        {
            ViewData["Slug"] = slug;
            return View(new UploadViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("w/{slug}")]
        public IActionResult Upload(string slug, UploadViewModel model)
        {
            ViewData["Slug"] = slug;

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // TODO: Dosyaları kaydet / Drive'a yükle
            TempData["UploadSuccess"] = true;
            return RedirectToAction("Upload", new { slug });
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
    }
}
