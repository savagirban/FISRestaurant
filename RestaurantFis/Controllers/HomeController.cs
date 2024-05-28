using Microsoft.AspNetCore.Mvc;
using RestaurantFis.Models;
using RestaurantFis.Models.Domain.Interfaces;
using RestaurantFis.Models.Domain.Models;
using RestaurantFis.Models.Domain.Usecase;
using RestaurantFis.Models.Mock.Data.Repos;
using System.Diagnostics;

namespace RestaurantFis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;


            IRepoUtilizator repo = new MockRepoUtilizator();
            ServiciuAutentificare autentificare = new(repo);
            var usr=autentificare.Autentificare("vlador", "1234");
            if (usr != null) {
                FileLogger.Write($"AUTH:Succefuly authetificated {usr.Nume}");
            }

        }

        public IActionResult Index()
        {
            return View();
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
