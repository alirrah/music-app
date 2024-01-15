using Microsoft.AspNetCore.Mvc;
using music_app.Models;
using System.Diagnostics;

namespace music_app.Controllers
{
    public class MusicController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public MusicController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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